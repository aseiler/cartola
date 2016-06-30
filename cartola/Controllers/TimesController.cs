using cartola.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace cartola.Controllers
{
    public class TimesController : Controller
    {
        // GET: Times
        public ActionResult Index()
        {
            return View("Times");
        }


        public ActionResult Listar(List<Time> lstTime)
        {
            List<Time> oReturn = new List<Time>();
            foreach (Time oTime in lstTime) {
                if (oTime.slug != null)
                oReturn.Add(ListarTimes(oTime.slug));
            }

            return View("Times", oReturn);
        }

        public Time ListarTimes(string slug)
        {
            Time oTime = new Time();

            Pontuados oPontuados = new Pontuados();
            JObject oPont = oPontuados.Get();
            Time oT = oTime.Get(slug);

            foreach (Atleta o in oT.ListaAtletas)
            {
                if (oPont["atletas"][o.IdAtleta.ToString()] != null)
                    o.oAtletaPontuado = JsonConvert.DeserializeObject<AtletaPontuado>(oPont["atletas"][o.IdAtleta.ToString()].ToString());
                else
                    o.oAtletaPontuado = new AtletaPontuado();
            }

            return oT;
        }
    }
}