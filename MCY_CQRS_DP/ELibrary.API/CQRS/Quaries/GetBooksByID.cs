using ELibrary.API.CQRS.Results;
using MediatR;

namespace ELibrary.API.CQRS.Quaries
{
	public class GetBooksByID : IRequest<BookResult>
	{
        public int ID { get; set; }
    }
}
