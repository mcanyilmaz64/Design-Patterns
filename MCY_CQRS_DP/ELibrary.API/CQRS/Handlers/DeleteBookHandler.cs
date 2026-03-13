using ELibrary.API.CQRS.Commands;
using ELibrary.API.DAL;
using MediatR;

namespace ELibrary.API.CQRS.Handlers
{
	public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, bool>
	{
		private readonly Context _context;

		public DeleteBookHandler(Context context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
		{
			var result = await _context.Books.FindAsync(request.ID);
			_context.Books.Remove(result);
			await _context.SaveChangesAsync();
			return true;
		}
	}
}
