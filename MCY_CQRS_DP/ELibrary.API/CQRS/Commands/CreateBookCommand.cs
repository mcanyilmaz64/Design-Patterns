using ELibrary.API.DAL;
using MediatR;

namespace ELibrary.API.CQRS.Commands
{
	public class CreateBookCommand : IRequest<bool>
	{
		public string BookName { get; set; }
		public string Url { get; set; }
		public decimal Price { get; set; }
		public bool Status { get; set; }
		public int CategoryId { get; set; }

	}
}
