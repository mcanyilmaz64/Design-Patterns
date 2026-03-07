namespace DesignPatterns.CQRS.CQRSDesignPattern.Quaries
{
    public class GetProductUpdateByIDQuery
    {
        public int id { get; set; }

        public GetProductUpdateByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
