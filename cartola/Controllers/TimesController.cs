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
                Listar(null);

            return View("Times");
        }


        public ActionResult Listar(string slug)
        {
            List<Time> oReturn = new List<Time>();
            List<string> lstSlug = new List<string>();
            Response.Cookies["Cartola"].Expires = DateTime.Now.AddDays(10);
            if (slug != null)
                lstSlug.Add(slug);
            if (Request.Cookies["Cartola"]["Times"] != null)
            {
                foreach (string o in Request.Cookies["Cartola"]["Times"].Split(','))
                {
                    if(!o.Equals(""))
                    lstSlug.Add(o);
                    Response.Cookies["Cartola"]["Times"] = null;
                }
            }
            foreach (string x in lstSlug.Distinct().ToList())
            { 
                oReturn.Add(ListarTimes(x));
                Response.Cookies["Cartola"]["Times"] += x + ",";
            }

            oReturn = (List<Time>)oReturn.OrderByDescending(x => x.Pontos).ToList();

            return View("Times", oReturn);

        }

        public Time ListarTimes(string slug)
        {
            Time oTime = new Time();

            Pontuados oPontuados = new Pontuados();
            JObject oPont = oPontuados.Get();
            Time oT = oTime.Get(slug);
            oT.slug = slug;

            if (oT.ListaAtletas != null)
            {
                foreach (Atleta o in oT.ListaAtletas)
                {
                    if (oPont != null && oPont["atletas"][o.IdAtleta.ToString()] != null)
                        o.oAtletaPontuado = JsonConvert.DeserializeObject<AtletaPontuado>(oPont["atletas"][o.IdAtleta.ToString()].ToString());
                    else
                        o.oAtletaPontuado = new AtletaPontuado();
                }
            }
            else
                oT.ListaAtletas = new List<Atleta>();

            oT.Pontos = oT.ListaAtletas.Sum(x => x.oAtletaPontuado.Pontuacao);

            return oT;
        }
    }
}