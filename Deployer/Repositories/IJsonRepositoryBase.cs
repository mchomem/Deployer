namespace Deployer.Repositories;

public interface IJsonRepositoryBase<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetAsync(string code);
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(string code, TEntity updatedEntity);
    Task<bool> CheckIfExistsAnyAsync();
}
