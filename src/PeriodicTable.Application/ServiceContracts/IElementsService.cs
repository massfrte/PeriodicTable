using PeriodicTable.Application.DTO.Request;
using PeriodicTable.Application.DTO.Response;

namespace PeriodicTable.Application.ServiceContracts
{
	public interface IElementsService
	{
		Task<IEnumerable<ElementResponse>> GetAllElementsAsync();

		Task<ElementResponse> GetByIdAsync(Guid? id);

		Task AddElementAsync(ElementAddRequest? request);

		Task DeleteElementAsync(ElementRemoveRequest? request);

		Task UpdateElementAsync(Guid? id, ElementUpdateRequest? request);

        Task<IEnumerable<ElementResponse>> SearchByGroupAsync(string? group);

        Task<IEnumerable<ElementResponse>> SearchBySymbolAsync(string? symbol);

		Task<IEnumerable<ElementResponse>> SearchByNameAsync(string? name);
	}
}
