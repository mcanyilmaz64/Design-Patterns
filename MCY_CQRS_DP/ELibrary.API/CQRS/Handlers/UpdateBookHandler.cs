using ELibrary.API.CQRS.Commands;
using ELibrary.API.CQRS.Results;
using ELibrary.API.DAL;
using MediatR;

namespace ELibrary.API.CQRS.Handlers
{
	public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, BookResult>
	{
		private readonly Context _context;

		public UpdateBookHandler(Context context)
		{
			_context = context;
		}

		public async Task<BookResult> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
		{
			var result = await _context.Books.FindAsync(request.ID);
			if (result == null)
			{
				return null; 
			}
			result.BookName = request.BookName;
			result.Url = request.Url;
			result.Price = request.Price;
			result.CategoryId = request.CategoryId;	
			await _context.SaveChangesAsync();
		
			return new BookResult
			{
				BookName = result.BookName,
				Url = result.Url,
				Price = result.Price,
				CategoryId = result.CategoryId
			};

			
		}
	}
}
