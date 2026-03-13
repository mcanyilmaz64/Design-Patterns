using ELibrary.API.CQRS.Results;
using MediatR;

namespace ELibrary.API.CQRS.Commands
{
	public class UpdateBookCommand : IRequest<BookResult>
	{
        public int ID { get; set; }
		public string BookName { get; set; }
		public string Url { get; set; }
		public decimal Price { get; set; }
		public int CategoryId { get; set; }
	}
}
