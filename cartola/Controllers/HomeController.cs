using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cartola.entity;

namespace cartola.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View("Home",Partidas.New.Get());
        }
    }
}