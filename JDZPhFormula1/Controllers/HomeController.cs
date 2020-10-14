using JDZPhFormula1.Repository;
using JDZPhFormula1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JDZPhFormula1.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService _homeService;

        public HomeController()
        {
            _homeService = new HomeRepository();
        }

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public ActionResult Index()
        {
            return Redirect("~/Bronze");
        }

        public ActionResult About()
        {
            ViewBag.Message = "JDZ F1 PH";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult HomeDetails(string classification)
        {
            var homedetails = _homeService.HomeDetails(classification);
            return PartialView("_NavHeader", homedetails);
        }
    }
}