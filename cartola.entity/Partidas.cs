using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class Partidas
    {
        #region Instance
        public static Partidas New { get { return new Partidas(); } }
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "partidas")]
        public List<Partida> lstPartida { get; set; }

        //[JsonProperty(PropertyName = "clubes")]
        public List<Clube> lstClube { get; set; }

        [JsonProperty(PropertyName = "rodada")]
        public int Rodada { get; set; }
        #endregion

        #region Methods

        public Partidas Get()
        {
            try
            {
                using (var client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = false }))
                {
                    client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync("partidas").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Task<string> steste = response.Content.ReadAsStringAsync();

                        Partidas oPartidas = JsonConvert.DeserializeObject<Partidas>(steste.Result.ToString());

                        JObject oClub = JObject.Parse(steste.Result.ToString());
                        JToken[] lstClubes = oClub["clubes"].ToArray();
                        oPartidas.lstClube = new List<Clube>();
                        
                        foreach (JToken o in lstClubes)
                        {
                            oPartidas.lstClube.Add(Clube.New.Get(o.First.ToString()));
                        }
                        return oPartidas;
                    }
                }
                return new Partidas();
            }
            catch (HttpListenerException ex)
            {

                return new Partidas();
            }

        }

        #endregion
    }
}
