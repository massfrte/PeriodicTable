namespace PeriodicTable.Domain.RepositoryContracts.Abstractions
{
	public interface IRepository<TEntity, TKey>
	{
		Task<TEntity> GetById(TKey key);

		Task<IEnumerable<TEntity>> GetAll();

		Task Add(TEntity item);

		Task Update(TKey key, TEntity item);

		Task Delete(TKey key);
	}
}
