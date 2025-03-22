namespace Deployer.Repositories;

public interface IJsonRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity> Read();
    Task Write(TEntity entity);
    Task<bool> CheckIfExists();
}
