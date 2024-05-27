using System.ComponentModel.DataAnnotations;

namespace PeriodicTable.Application.DTO.Request
{
	public class ElementRemoveRequest
	{
		[Required]
		public Guid Id { get; set; }
	}
}
