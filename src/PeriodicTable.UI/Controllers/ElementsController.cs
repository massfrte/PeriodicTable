using Microsoft.AspNetCore.Mvc;
using PeriodicTable.Application.DTO.Request;
using PeriodicTable.Application.ServiceContracts;

namespace PeriodicTable.UI.Controllers
{
	[Route("[controller]")]
	public class ElementsController : Controller
	{
		private readonly IElementsService _elementsService;

		public ElementsController(IElementsService elementsService)
		{
			_elementsService = elementsService;
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			return View(await _elementsService.GetAllElementsAsync());
		}

        [HttpPost("[action]")]
        public async Task<IActionResult> SearchByName(string? name)
        {
            return View(nameof(All), await _elementsService.SearchByNameAsync(name));
        }

		[HttpPost("[action]")]
		public async Task<IActionResult> Delete(Guid? id)
		{
			await _elementsService.DeleteElementAsync(new ElementRemoveRequest() { Id = id });

			return RedirectToAction(nameof(All));
		}

		[HttpGet("[action]")]
		public IActionResult AddNew()
		{
			return View();
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AddNew(ElementAddRequest? request)
		{
			await _elementsService.AddElementAsync(request);

			return RedirectToAction(nameof(All));
		}

		[HttpGet("[action]/{id}")]
		public async Task<IActionResult> Update(Guid? id)
		{
			return View(await _elementsService.GetByIdAsync(id));
		}

        [HttpPost("[action]/{id}")]
		public async Task<IActionResult> Update(Guid? id, ElementUpdateRequest? request)
		{
			await _elementsService.UpdateElementAsync(id, request);

			return RedirectToAction(nameof(All));
		}
	}
}
