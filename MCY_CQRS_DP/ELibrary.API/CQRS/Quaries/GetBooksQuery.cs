
using ELibrary.API.CQRS.Results;
using MediatR;

namespace ELibrary.API.CQRS.Quaries
{
	public class GetBooksQuery : IRequest<List<BookResult>>
	{

	}
}
