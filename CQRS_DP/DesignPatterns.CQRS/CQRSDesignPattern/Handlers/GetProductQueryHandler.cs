using DesignPatterns.CQRS.CQRSDesignPattern.Results;
using DesignPatterns.CQRS.DAL;

namespace DesignPatterns.CQRS.CQRSDesignPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context) {
            _context = context;
        }

        public List<GetProductQueryResult> Handle(){

           var values = _context.Products.Select(x=>new GetProductQueryResult
           {
               Id = x.ProductId,
               ProductName = x.Name,
               Stock = x.Stock,
               Price = x.Price,
             
           }).ToList();
            return values;
        }
    }
}
