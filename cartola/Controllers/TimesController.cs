using cartola.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cartola.Controllers
{
    public class TimesController : Controller
    {
        // GET: Times
        public ActionResult Index()
        {
            return View("Times");
        }


        public ActionResult Listar(Time oTime)
        {
            string slug = oTime.slug;
            if (slug != null)
                return View("Times", ListarAtletas(slug));

            return View("Times");
        }

        public Time ListarAtletas(string slug)
        {
            List<Atleta> lstAtleta = new List<Atleta>();
            Atleta oAtleta = new Atleta();
            return new Time { ListaAtletas = oAtleta.Get(slug) };
        }
    }
}