using DesignPatterns.CQRS.CQRSDesignPattern.Quaries;
using DesignPatterns.CQRS.CQRSDesignPattern.Results;
using DesignPatterns.CQRS.DAL;

namespace DesignPatterns.CQRS.CQRSDesignPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
           
                return  new GetProductByIDQueryResult
                {
                    ProductId = values.ProductId,
                    Name = values.Name,
                    Stock = values.Stock,
                    Price = values.Price
                };
                
          
        }
    }
}
