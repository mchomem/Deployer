namespace Deployer.Repositories;

public class JsonRepositoryBase<TEntity> : IJsonRepositoryBase<TEntity> where TEntity : class
{
    private readonly string filePath;

    public JsonRepositoryBase()
    {
        this.filePath = $"{typeof(TEntity).Name}.json";
    }

    public async Task<TEntity> Read()
    {
        if (!File.Exists(filePath)) return default!;

        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            var entity = await JsonSerializer.DeserializeAsync<TEntity>(stream);
            return entity!;
        }
    }

    public async Task Write(TEntity entity)
    {
        using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await JsonSerializer.SerializeAsync(stream, entity, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    public async Task<bool> CheckIfExists()
    {
        var exists = await Task.Run(() =>
        {
            var exists = File.Exists(filePath);
            return exists;
        });

        return exists;
    }
}
