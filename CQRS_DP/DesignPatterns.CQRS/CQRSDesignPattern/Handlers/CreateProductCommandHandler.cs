using DesignPatterns.CQRS.CQRSDesignPattern.Commands;
using DesignPatterns.CQRS.DAL;

namespace DesignPatterns.CQRS.CQRSDesignPattern.Handlers
{
	public class CreateProductCommandHandler
	{
		private readonly Context _context;

		public CreateProductCommandHandler(Context context)
		{
			_context = context;
		}

		public void Handle(CreateProductCommand command) 
		{
			_context.Products.Add(new Product
			{
				Name = command.Name,
				Stock = command.Stock,
				Price = command.Price,
				Description = command.Description,
				Status = true
			});
			_context.SaveChanges();
		
		}
	}
}
