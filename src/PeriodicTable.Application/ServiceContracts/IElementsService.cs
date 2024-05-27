﻿using PeriodicTable.Application.DTO.Request;
using PeriodicTable.Application.DTO.Response;

namespace PeriodicTable.Application.ServiceContracts
{
	public interface IElementsService
	{
		Task<IEnumerable<ElementResponse>> GetAllElementsAsync();

		Task<ElementResponse> GetByIdAsync(Guid? id);

		Task AddElementAsync(ElementAddRequest? request);

		Task DeleteElementAsync(ElementRemoveRequest? request);

		Task UpdateElementAsync(ElementUpdateRequest? request);

		Task<IEnumerable<ElementResponse>> SearchBySymbolAsync(string? symbol);

		Task<IEnumerable<ElementResponse>> SearchByNameAsync(string? name);
	}
}