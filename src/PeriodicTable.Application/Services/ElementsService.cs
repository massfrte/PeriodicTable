using PeriodicTable.Application.DTO.Request;
using PeriodicTable.Application.DTO.Response;
using PeriodicTable.Application.Exceptions;
using PeriodicTable.Application.ServiceContracts;
using PeriodicTable.Application.Services.Helpers;
using PeriodicTable.Application.Services.Mappers;
using PeriodicTable.Domain.RepositoryContracts;
using System.Xml.Linq;

namespace PeriodicTable.Application.Services
{
	public class ElementsService : IElementsService
	{
		private readonly IElementsRepository _elementsRepository;
		private readonly ElementMapper _elementMapper;

		public ElementsService(IElementsRepository elementsRepository)
		{
			_elementsRepository = elementsRepository;
			_elementMapper = new ElementMapper();
		}

		public async Task AddElementAsync(ElementAddRequest? request)
		{
			await ValidationHelper.ValidateObjects(request);

			var element = _elementMapper.ToEntity(request);

			element.Id = Guid.NewGuid();

			await _elementsRepository.AddAsync(element);
		}

		public async Task DeleteElementAsync(ElementRemoveRequest? request)
		{
			await ValidationHelper.ValidateObjects(request);

			if (!await _elementsRepository.ExistsAsync(request.Id.Value))
			{
				throw new ElementNotFoundException(request.Id.Value);
			}

			await _elementsRepository.DeleteAsync(request.Id.Value);
		}

		public async Task<IEnumerable<ElementResponse>> GetAllElementsAsync()
		{
			var elements = await _elementsRepository.GetAllAsync();

			return _elementMapper.ToResponse(elements);
		}

		public async Task<ElementResponse> GetByIdAsync(Guid? id)
		{
			await ValidationHelper.ValidateObjects(id);

			var element = await _elementsRepository.GetByIdAsync(id.Value);

			if (element is null)
			{
				throw new ElementNotFoundException(id.Value);
			}

			return _elementMapper.ToResponse(element);
		}

		public async Task<IEnumerable<ElementResponse>> SearchByNameAsync(string? name)
		{
			await ValidationHelper.ValidateObjects(name);

			var elements = await _elementsRepository.SearchBy(x => x.Name.Contains(name));

			return _elementMapper.ToResponse(elements);
		}

		public async Task<IEnumerable<ElementResponse>> SearchBySymbolAsync(string? symbol)
		{
			await ValidationHelper.ValidateObjects(symbol);

			var elements = await _elementsRepository.SearchBy(x => x.Symbol.Contains(symbol));

			return _elementMapper.ToResponse(elements);
		}

		public async Task UpdateElementAsync(Guid? id, ElementUpdateRequest? request)
		{
			await ValidationHelper.ValidateObjects(id, request);

			if (!await _elementsRepository.ExistsAsync(id.Value))
			{
				throw new ElementNotFoundException(id.Value);
			}

			var element = _elementMapper.ToEntity(request);
			element.Id = id.Value;

			await _elementsRepository.UpdateAsync(id.Value, element);
		}
	}
}
