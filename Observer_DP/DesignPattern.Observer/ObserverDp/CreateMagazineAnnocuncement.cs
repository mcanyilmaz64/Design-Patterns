using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverDp
{
    public class CreateMagazineAnnocuncement : IObserver
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly Context context;

		public CreateMagazineAnnocuncement(IServiceProvider serviceProvider, Context context)
		{
			_serviceProvider = serviceProvider;
			this.context = context;
		}
		public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Bilim dergimizin 3. sayısı 14 Nisanda sizlere ulaşacaktır.",
                Magazine = "Bilim Dergisi"
            });
            context.SaveChanges();
        }
    }
}
