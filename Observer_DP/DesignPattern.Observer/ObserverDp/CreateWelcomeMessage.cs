using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverDp
{
    public class CreateWelcomeMessage : IObserver
    {
        Context context = new Context();
        private readonly IServiceProvider _serviceProvider;

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
