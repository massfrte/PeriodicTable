using PeriodicTable.Domain.Entities;
using PeriodicTable.Domain.RepositoryContracts.Abstractions;
using System.Linq.Expressions;

namespace PeriodicTable.Domain.RepositoryContracts
{
	public interface IElementsRepository : IRepository<ChemicalElement, Guid>
	{
		Task<IEnumerable<ChemicalElement>> SearchBy(Expression<Func<ChemicalElement, bool>> predicate);
	}
}
