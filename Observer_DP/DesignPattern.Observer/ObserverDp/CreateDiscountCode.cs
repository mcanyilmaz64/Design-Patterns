using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverDp
{

    public class CreateDiscountCode : IObserver
    {

        Context context = new Context();
        private readonly IServiceProvider _serviceProvider;

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "APRIL14",
                DiscountAmount = 30,
                DiscountStatus = true
            });
            context.SaveChanges();
        }
    }
}
