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
            if (Request.Cookies["Cartola"] != null && Request.Cookies["Cartola"]["Times"] != null)
                Listar(string.Empty);

            return View("Times");
        }

        public ActionResult Listar(string slug)
        {
            List<Time> oReturn = new List<Time>();
            List<string> lstSlug = new List<string>();
            Response.Cookies["Cartola"].Expires = DateTime.Now.AddDays(10);

            slug = slug.Trim().Replace(' ', '-');

            if (!slug.Equals(string.Empty))
                lstSlug.Add(slug);

            if (Request.Cookies["Cartola"]["Times"] != null)
            {
                foreach (string o in Request.Cookies["Cartola"]["Times"].Split(','))
                {
                    if(!o.Equals(string.Empty))
                        lstSlug.Add(o);
                }
                Response.Cookies["Cartola"]["Times"] = null;
            }

            foreach (string x in lstSlug.Distinct().ToList())
            {
                Time oTime = ListarTimes(x);

                if (oTime.ListaAtletas.Count() > 0)
                    oReturn.Add(oTime);
            }

            Response.Cookies["Cartola"]["Times"] = String.Join(",", lstSlug.Distinct().ToArray());
            oReturn = (List<Time>)oReturn.OrderByDescending(x => x.Pontos).ToList();

            return View("Times", oReturn);

        }

        public ActionResult Excluir(string slug) {

            List<string> lstSlug = Request.Cookies["Cartola"]["Times"].Split(',').ToList();

            lstSlug.Remove(slug);

            Request.Cookies["Cartola"]["Times"] = string.Join(",",lstSlug);
            return Listar(string.Empty);
        }

        private Time ListarTimes(string slug)
        {
            Time oTime = new Time();

            Pontuados oPontuados = new Pontuados();
            JObject lstAtletasPontuado = oPontuados.GetJToken();
            Time oT = oTime.Get(slug);
            oT.slug = slug;

            if (oT.ListaAtletas != null)
            {
                foreach (Atleta o in oT.ListaAtletas)
                {
                    o.oAtletaPontuado = JsonConvert.DeserializeObject <AtletaPontuado>(lstAtletasPontuado["atletas"][o.IdAtleta.ToString()].ToString());
                }
            }
            else
                oT.ListaAtletas = new List<Atleta>();

            oT.Pontos = oT.ListaAtletas.Sum(x => x.oAtletaPontuado.Pontuacao);

            return oT;
        }
    }
}