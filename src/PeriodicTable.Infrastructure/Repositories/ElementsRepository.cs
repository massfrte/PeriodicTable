using Microsoft.EntityFrameworkCore;
using PeriodicTable.Domain.Entities;
using PeriodicTable.Domain.RepositoryContracts;
using PeriodicTable.Infrastructure.Database;

namespace PeriodicTable.Infrastructure.Repositories
{
	public class ElementsRepository : IElementsRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public ElementsRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task AddAsync(ChemicalElement item)
		{
			await _dbContext.ChemicalElements.AddAsync(item);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(Guid key)
		{
			var found = await GetByIdAsync(key);

			_dbContext.ChemicalElements.Remove(found);
		}

		public async Task<bool> ExistsAsync(Guid key)
		{
			return (await _dbContext.ChemicalElements.FindAsync(key)) is not null;
		}

		public async Task<IEnumerable<ChemicalElement>> GetAllAsync()
		{
			return await _dbContext.ChemicalElements.ToListAsync();
		}

		public async Task<ChemicalElement?> GetByIdAsync(Guid key)
		{
			return await _dbContext.ChemicalElements.FindAsync(key);
		}

		public async Task<IEnumerable<ChemicalElement>> SearchBy(Predicate<ChemicalElement> predicate)
		{
			return await _dbContext.ChemicalElements.Where(element => predicate(element)).ToListAsync();
		}

		public async Task UpdateAsync(Guid key, ChemicalElement item)
		{
			var found = await GetByIdAsync(key);

			_dbContext.Entry(found).CurrentValues.SetValues(item);

			await _dbContext.SaveChangesAsync();
		}
	}
}
