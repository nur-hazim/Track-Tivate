using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Track_Tivate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Account()
        {
            return View();
        }

        [Authorize]
        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Explore()
        {
            return View();
        }

        public ActionResult Emergency()
        {
            return View();
        }

        public ActionResult Promotion()
        {
            return View();
        }
    }
}