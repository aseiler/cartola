using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cartola.entity;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace cartola.Controllers
{
    public class PontuacaoController : Controller
    {
        #region public method
        // GET: Pontuacao
        public ActionResult Index()
        {
            ;
            return View("Pontuacao", ListarPontuados());
        }
        #endregion

        #region private method
        private List<AtletaPontuado> ListarPontuados()
        {
            Pontuados oPontuados = new Pontuados();
            try
            {
                JObject oPont = oPontuados.Get();
                List<AtletaPontuado> lstAp = new List<AtletaPontuado>();
                JToken[] lstJogadores = oPont["atletas"].ToArray();

                foreach (JToken o in lstJogadores) { 
                lstAp.Add(JsonConvert.DeserializeObject<AtletaPontuado>(o.First.ToString()));
                }
                return lstAp;
            }
            catch (Exception ex)
            {
                
                throw;
                return null;
            }
        }
        #endregion
    }
}