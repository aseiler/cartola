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
            MercadoStatus oMerc = new MercadoStatus();
            ViewBag.MercadoStatus = oMerc.Get();

            if (ViewBag.MercadoStatus.StatusMercado == MercadoStatus.StatusRodada.Fechado)
            {
                Pontuados oPontuados = new Pontuados();
                return View("Pontuacao", oPontuados.Get());
            }


            return View("Pontuacao");
        }
        #endregion

    }
}