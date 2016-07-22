using Newtonsoft.Json;
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
    public class Time
    {
        #region Properties

        public string slug { get; set; }

        [JsonProperty(PropertyName = "Atletas")]
        public List<Atleta> ListaAtletas { get; set; }

        [JsonProperty(PropertyName = "patrimonio")]
        public decimal Patrimonio { get; set; }

        [JsonProperty(PropertyName = "esquema_id")]
        public int IdEsquema { get; set; }

        [JsonProperty(PropertyName = "pontos")]
        public decimal Pontos { get; set; }

        [JsonProperty(PropertyName = "valor_time")]
        public decimal ValorTime { get; set; }

        [JsonProperty(PropertyName = "rodada_atual")]
        public int RodadaAtual { get; set; }

        [JsonProperty(PropertyName = "time")]
        public TimeInfo oTimeInfo { get; set; }

        #endregion

        public Time Get(string slug)
        {
            try
            {
                using (var client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = false }))
                {
                    client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync("time/" + slug.Replace(" ", "-")).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Task<string> steste = response.Content.ReadAsStringAsync();

                        Time oTime = JsonConvert.DeserializeObject<Time>(steste.Result.ToString());
                        return oTime;
                    }
                }
                return new Time();
            }
            catch (HttpListenerException ex)
            {

                return new Time();
            }

        }

    }
}
