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

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetById(Guid? id)
		{
			return View(await _elementsService.GetByIdAsync(id));
		}

		[HttpGet("[action]/{symbol}")]
		public async Task<IActionResult> SearchBySymbol(string? symbol)
		{
			return View(await _elementsService.SearchBySymbolAsync(symbol));
		}

		[HttpGet("[action]/{name}")]
		public async Task<IActionResult> SearchByName(string? name)
		{
			return View(await _elementsService.SearchByNameAsync(name));
		}

		[HttpGet("[action]/{id:guid}")]
		public async Task<IActionResult> Delete(Guid? id)
		{
			await _elementsService.DeleteElementAsync(new ElementRemoveRequest() { Id = id });

			return RedirectToAction(nameof(All));
		}

		[HttpPost]
		public async Task<IActionResult> AddNew(ElementAddRequest? request)
		{
			await _elementsService.AddElementAsync(request);

			return RedirectToAction(nameof(All));
		}

		[HttpPut]
		public async Task<IActionResult> Update(Guid? id, ElementUpdateRequest? request)
		{
			await _elementsService.UpdateElementAsync(id, request);

			return RedirectToAction(nameof(All));
		}
	}
}
