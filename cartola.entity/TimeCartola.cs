using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class TimeCartola
    {
        #region Properties

        [JsonProperty(PropertyName = "time_id")]
        public int IdTime { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "nome_cartola")]
        public string NomeCartola { get; set; }

        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "facebook_id")]
        public string IdFacebook { get; set; }

        [JsonProperty(PropertyName = "url_escudo_png")]
        public string UrlEscudoPng { get; set; }

        [JsonProperty(PropertyName = "url_escudo_svg")]
        public string UrlEscudoSvg { get; set; }

        [JsonProperty(PropertyName = "foto_perfil")]
        public string FotoPerfil { get; set; }

        [JsonProperty(PropertyName = "assinante")]
        public bool Assinante { get; set; }

        #endregion

        #region Methods
        public List<TimeCartola> Get(string sBusca)
        {
            List<TimeCartola> lstTimeCartola = new List<TimeCartola>();
            using (var client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = false }))
            {
                client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("/times?q=" + sBusca).Result;
                if (response.IsSuccessStatusCode)
                {
                    Task<string> oReturn = response.Content.ReadAsStringAsync();
                    lstTimeCartola = JsonConvert.DeserializeObject<List<TimeCartola>>(oReturn.Result.ToString());
                }

                return lstTimeCartola;
            }
        }
        #endregion
    }
}
