using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverDp
{

    public class CreateDiscountCode : IObserver
    {

        private readonly Context context ;
        private readonly IServiceProvider _serviceProvider;

		public CreateDiscountCode(IServiceProvider serviceProvider, Context context)
		{
			_serviceProvider = serviceProvider;
			this.context = context;
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
