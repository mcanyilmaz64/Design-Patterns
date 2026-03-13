using ELibrary.API.CQRS.Commands;
using ELibrary.API.DAL;
using MediatR;

namespace ELibrary.API.CQRS.Handlers
{
	public class CreateBookHandler : IRequestHandler<CreateBookCommand, bool>
	{
		private readonly Context _context;

		public CreateBookHandler(Context context)
		{
			_context = context;
		}

		public async Task<bool> Handle(CreateBookCommand request, CancellationToken cancellationToken)
		{
			_context.Books.Add(new Book
			{
				BookName = request.BookName,
				Url = request.Url,
				Price = request.Price,
				Status = request.Status,
				CategoryId = request.CategoryId
			});
			await _context.SaveChangesAsync(cancellationToken);
			return true;
			
		}
	}
}
