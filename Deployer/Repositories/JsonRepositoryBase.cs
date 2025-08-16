namespace Deployer.Repositories;

public class JsonRepositoryBase<TEntity> : IJsonRepositoryBase<TEntity> where TEntity : class
{
    private readonly string filePath;

    public JsonRepositoryBase()
    {
        this.filePath = $"{typeof(TEntity).Name}.json";
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        if (!File.Exists(filePath)) return default!;

        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            var entity = await JsonSerializer.DeserializeAsync<IEnumerable<TEntity>>(stream);
            return entity!;
        }
    }

    public async Task<TEntity> GetAsync(string code)
    {
        if (!File.Exists(filePath))
            return default!;

        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            var entities = await JsonSerializer.DeserializeAsync<List<TEntity>>(stream);

            if (entities == null || entities.Count == 0)
                return default;

            // Busca via reflection pela propriedade "Code"
            var entity = entities.FirstOrDefault(e =>
            {
                var prop = typeof(TEntity).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (prop == null) return false;

                var value = prop.GetValue(e)?.ToString();
                return string.Equals(value, code, StringComparison.OrdinalIgnoreCase);
            });

            return entity;
        }
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        var entities = (await GetAllAsync() ?? Enumerable.Empty<TEntity>()).ToList();

        // Busca o valor da propriedade "Code" da nova entidade para verificar se já existe
        var prop = typeof(TEntity).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
        if (prop == null) throw new InvalidOperationException("The entity must contain a 'Code' property.");

        var newCode = prop.GetValue(entity)?.ToString();

        // Verifica se já existe um registro com o mesmo 'Code'
        var existingEntity = entities.FirstOrDefault(e =>
        {
            var existingCode = prop.GetValue(e)?.ToString();
            return string.Equals(existingCode, newCode, StringComparison.OrdinalIgnoreCase);
        });

        if (existingEntity != null)
        {
            throw new InvalidOperationException($"An entity with the code already exists '{newCode}'.");
        }

        // Adiciona a nova entidade à lista
        entities.Add(entity);

        // Salva a lista completa de volta no arquivo
        await WriteAllAsync(entities);

        return entity;
    }

    public async Task<TEntity> UpdateAsync(string code, TEntity updatedEntity)
    {
        var entities = (await GetAllAsync() ?? Enumerable.Empty<TEntity>()).ToList();
        var entityToUpdate = entities.FirstOrDefault(e =>
        {
            var prop = typeof(TEntity).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (prop == null) return false;

            var value = prop.GetValue(e)?.ToString();
            return string.Equals(value, code, StringComparison.OrdinalIgnoreCase);
        });

        if (entityToUpdate == null)
        {
            throw new InvalidOperationException($"No entity found with code '{code}' for update.");
        }

        entities.Remove(entityToUpdate);
        entities.Add(updatedEntity);

        // Salva a lista completa atualizada no arquivo
        await WriteAllAsync(entities);

        return updatedEntity;
    }

    private async Task WriteAllAsync(IEnumerable<TEntity> entities)
    {
        using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await JsonSerializer.SerializeAsync(stream, entities, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    public async Task<bool> CheckIfExistsAnyAsync()
    {
        var entities = await GetAllAsync();

        if (entities == null || !entities.Any())
            return false;

        return true;
    }
}
