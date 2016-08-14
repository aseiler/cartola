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
    public class MercadoStatus
    {
        #region Properties

        public enum StatusRodada
        {
            Aberto = 1,
            Fechado = 2
        }

        [JsonProperty(PropertyName = "status_mercado")]
        public StatusRodada StatusMercado { get; set; }

        [JsonProperty(PropertyName = "aviso")]
        public string Aviso { get; set; }

        [JsonProperty(PropertyName = "mercado_pos_rodada")]
        public bool PosRodada { get; set; }
        #endregion

        #region Methods

        public MercadoStatus Get()
        {
            try
            {
                using (var client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = false }))
                {
                    client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync("/mercado/status").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Task<string> steste = response.Content.ReadAsStringAsync();

                        MercadoStatus oMercadoStatus = JsonConvert.DeserializeObject<MercadoStatus>(steste.Result.ToString());
                        return oMercadoStatus;
                    }
                }
                return new MercadoStatus();
            }
            catch (HttpListenerException ex)
            {

                return new MercadoStatus();
            }

        }

        #endregion
    }
}
