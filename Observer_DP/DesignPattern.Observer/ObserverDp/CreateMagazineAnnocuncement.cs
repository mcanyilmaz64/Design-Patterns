using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverDp
{
    public class CreateMagazineAnnocuncement : IObserver
    {

        Context context = new Context();
        private readonly IServiceProvider _serviceProvider;

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
