using ELibrary.API.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BooksController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BooksController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> CreateBook([FromBody] CreateBookCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}
		[HttpGet]
		public async Task<IActionResult> GetBooks()
		{
			var result = await _mediator.Send(new CQRS.Quaries.GetBooksQuery());
			return Ok(result);
		}
			[HttpGet("{id}")]
			public async Task<IActionResult> GetBooksByID(int id)
			{
				var result = await _mediator.Send(new CQRS.Quaries.GetBooksByID { ID = id });
				return Ok(result);
			}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBook(int id)
		{
			var result = await _mediator.Send(new DeleteBookCommand { ID = id });
			return Ok(result);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateBook(int id, [FromBody] UpdateBookCommand command)
		{
			command.ID = id;
			var result = await _mediator.Send(command);
			return Ok(result);
		}
	}
}
