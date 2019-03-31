using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpersY.Models;

namespace HTMLHelpersY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult usuarios()
        {
            return View();
        }

        public ActionResult DetalleUsuario(usuario usuario)
        {
            return View(usuario);
        }
    }
}
    
