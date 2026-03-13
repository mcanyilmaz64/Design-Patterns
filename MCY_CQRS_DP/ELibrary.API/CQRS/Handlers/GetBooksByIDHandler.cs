using ELibrary.API.CQRS.Quaries;
using ELibrary.API.CQRS.Results;
using ELibrary.API.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ELibrary.API.CQRS.Handlers
{
	public class GetBooksByIDHandler : IRequestHandler <GetBooksByID, BookResult>
	{
		private readonly Context _context;

		public GetBooksByIDHandler(Context context)
		{
			_context = context;
		}
		public async Task<BookResult> Handle(GetBooksByID request, CancellationToken cancellationToken)
		{
			 var result = await _context.Books.Where(b => b.BookId == request.ID).Select(b => new BookResult
			{
				BookName = b.BookName,
				CategoryId = b.CategoryId,
				Price = b.Price,
				Url = b.Url

			}).FirstOrDefaultAsync();
			return result;
		}
	}
}
