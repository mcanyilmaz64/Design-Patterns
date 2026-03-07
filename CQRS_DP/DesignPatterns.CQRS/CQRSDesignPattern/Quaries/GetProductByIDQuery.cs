namespace DesignPatterns.CQRS.CQRSDesignPattern.Quaries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }  
    }
}
