using DesignPatterns.TemplateMethod.TemplateDesignPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            FilmPlan filmPlan = new BasicPlan();
            ViewBag.v1 = filmPlan.PlanType("Basic Plan");
            ViewBag.v2 = filmPlan.CountPerson(1);
            ViewBag.v3 = filmPlan.Price(100);
            ViewBag.v4 = filmPlan.Resoltion("720p");


            return View();
        }
        public IActionResult ClassicPlanIndex()
        {
            FilmPlan filmPlan = new ClassicPlan();

            filmPlan = new UltraPlan();
            ViewBag.v5 = filmPlan.PlanType("Classic Plan");
            ViewBag.v6 = filmPlan.CountPerson(2);
            ViewBag.v7 = filmPlan.Price(200);
            ViewBag.v8 = filmPlan.Resoltion("2K");

            return View();
        }
        public IActionResult UltraPlanIndex()
        {
            FilmPlan filmPlan = new UltraPlan();

            ViewBag.v9 = filmPlan.PlanType("Ultra Plan");
            ViewBag.v10 = filmPlan.CountPerson(4);
            ViewBag.v11 = filmPlan.Price(300);
            ViewBag.v12 = filmPlan.Resoltion("4K");

            return View();
        }

    }
}
