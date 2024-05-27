using PeriodicTable.Application.DTO.Request;
using PeriodicTable.Application.DTO.Response;
using PeriodicTable.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace PeriodicTable.Application.Services.Mappers
{
	[Mapper]
	public partial class ElementMapper
	{
		public partial ChemicalElement ToEntity(ElementAddRequest request);

		public partial ChemicalElement ToEntity(ElementUpdateRequest request);

		public partial ElementResponse ToResponse(ChemicalElement element);

		public partial IEnumerable<ElementResponse> ToResponse(IEnumerable<ChemicalElement> element);
	}
}
