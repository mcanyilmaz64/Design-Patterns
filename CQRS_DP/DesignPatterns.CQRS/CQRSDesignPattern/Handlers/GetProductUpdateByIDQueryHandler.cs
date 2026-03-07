using DesignPatterns.CQRS.CQRSDesignPattern.Quaries;
using DesignPatterns.CQRS.CQRSDesignPattern.Results;
using DesignPatterns.CQRS.DAL;

namespace DesignPatterns.CQRS.CQRSDesignPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery
            query)
        {
            var values = _context.Products.Find(query.id);   
            return new GetProductUpdateQueryResult
            {
                ProductId = values.ProductId,
                Name = values.Name,
                Stock = values.Stock,
                Price = values.Price,
                Description = values.Description
            };

        }
    }
}
