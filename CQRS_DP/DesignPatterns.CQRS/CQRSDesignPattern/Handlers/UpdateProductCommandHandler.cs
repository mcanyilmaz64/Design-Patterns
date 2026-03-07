using DesignPatterns.CQRS.CQRSDesignPattern.Commands;
using DesignPatterns.CQRS.DAL;

namespace DesignPatterns.CQRS.CQRSDesignPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductId);
            values.Name = command.Name;
            values.Stock = command.Stock;
            values.Price = command.Price;
            values.Description = command.Description;
            _context.SaveChanges();
        }
    }
}
