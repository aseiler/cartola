using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using cartola.entity;namespace cartola.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View(ListarAtletas());
        }


        public ActionResult Listar()
        {
            return View();
        }

        public List<Atleta> ListarAtletas()
        {
            List<Atleta> lstAtleta = new List<Atleta>();
            Atleta oAtleta = new Atleta();
            return  oAtleta.Get();
        }
    }
}