using PeriodicTable.Domain.Entities;
using PeriodicTable.Domain.RepositoryContracts.Abstractions;

namespace PeriodicTable.Domain.RepositoryContracts
{
	public interface IElementsRepository : IRepository<ChemicalElement, Guid>
	{
		Task<IEnumerable<ChemicalElement>> SearchBy(Predicate<ChemicalElement> predicate);
	}
}
