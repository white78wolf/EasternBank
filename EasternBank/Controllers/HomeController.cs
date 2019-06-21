using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasternBank.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ForBusiness()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Eastern Bank - ваш надёжный выбор!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Позвоните нам сегодня - и Ваши мечты станут явью завтра!";

            return View();
        }
    }
}