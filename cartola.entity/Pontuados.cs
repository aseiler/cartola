using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class Pontuados
    {
        #region Properties
        [JsonProperty(PropertyName = "rodada")]
        public int Rodada { get; set; }

        [JsonProperty(PropertyName = "atletas")]
        public List<AtletaPontuado> ListaAtletas { get; set; }

        //[JsonProperty(PropertyName = "clubes")]
        //public List<Clubes> Clubes { get; set; }

        //[JsonProperty(PropertyName = "posicoes")]
        //public List<Posicoes> Posicoes { get; set; }

        [JsonProperty(PropertyName = "total_atletas")]
        public int TotalAtletas { get; set; }
        #endregion

        #region Methods

        public JObject Get()
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("/atletas/pontuados").Result;
                if (response.IsSuccessStatusCode)
                {
                    Task<string> steste = response.Content.ReadAsStringAsync();

                    Pontuados oPontuados = new Pontuados();
                    oPontuados.ListaAtletas = new List<AtletaPontuado>();
                    return JObject.Parse(steste.Result.ToString());
                }
            }
            return null;
        }
    }
        #endregion
}
