using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverDp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject observerObject;

		public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
		{
			_userManager = userManager;
			this.observerObject = observerObject;
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser
            {
                Name = model.Name,
                Surname = model.Surname,
                UserName = model.Username,
                Email = model.Email,
                
            };  
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
			{
				observerObject.NotifyObservers(appUser);

                return RedirectToAction("Welcome", new { name = appUser.Name });
            }

            return View();
          
        }
        [HttpGet]
        public IActionResult Welcome(string name)
        {
            return View((object)name);
        }
    }
}
