using ELibrary.API.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class PurchaseController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PurchaseController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> CreatePurchase([FromBody] CreateBookCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}
	}
}
