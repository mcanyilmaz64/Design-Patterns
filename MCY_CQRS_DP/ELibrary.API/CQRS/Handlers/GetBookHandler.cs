using ELibrary.API.CQRS.Quaries;
using ELibrary.API.CQRS.Results;
using ELibrary.API.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ELibrary.API.CQRS.Handlers
{
	public class GetBookHandler : IRequestHandler<GetBooksQuery, List<BookResult>>
	{
		private readonly Context _context;

		public GetBookHandler(Context context)
		{
			_context = context;
		}

		public async Task<List<BookResult>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
		{
			var result = await _context.Books.Select(b => new BookResult
			{
				BookId = b.BookId,
				BookName = b.BookName,
				CategoryId = b.CategoryId,
				Price = b.Price,
				Url = b.Url

			}).ToListAsync();

			return result;
			
			
		}
	}
}
