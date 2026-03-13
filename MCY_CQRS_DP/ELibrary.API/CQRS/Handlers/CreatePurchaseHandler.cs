using ELibrary.API.CQRS.Commands;
using ELibrary.API.DAL;
using MediatR;

namespace ELibrary.API.CQRS.Handlers
{
	public class CreatePurchaseHandler : IRequestHandler<CreatePurchaseCommand, bool>
	{
		private readonly Context _context;

		public CreatePurchaseHandler(Context context)
		{
			_context = context;
		}

		public async Task<bool> Handle(CreatePurchaseCommand request, CancellationToken cancellationToken)
		{
			var purchase = new Purchase
			{
				UserId = request.UserId,
				BookId = request.BookId,
				PurchaseTime = DateTime.UtcNow
			};
			await _context.Purchases.AddAsync(purchase, cancellationToken);
			await _context.SaveChangesAsync(cancellationToken);
			return true;
		
		}
	}
}
