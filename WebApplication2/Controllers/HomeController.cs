using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GameCatalog()
        {
          return View();
        }

    }

    public class GameDirectoryController : Controller
    {
        public ActionResult Dota2()
        {
            return View();
        }
    }

    public class NewsDirectoryController : Controller
    {
        public ActionResult BloodborneNews()
        {
            return View();
        }

    }


}