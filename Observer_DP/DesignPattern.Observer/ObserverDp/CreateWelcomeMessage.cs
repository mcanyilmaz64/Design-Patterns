using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverDp
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly Context context;
        private readonly IServiceProvider _serviceProvider;

		public CreateWelcomeMessage(IServiceProvider serviceProvider, Context context)
		{
			_serviceProvider = serviceProvider;
			this.context = context;
		}

		public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content= "Welcome to our system"
            });
            context.SaveChanges();
        }
    }
}
