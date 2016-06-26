using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;



namespace cartola.entity
{
    public class Atleta
    {

        #region Properties
        
        [JsonProperty(PropertyName="nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "apelido")]
        public string Apelido { get; set; }

        [JsonProperty(PropertyName = "foto")]
        public string Foto { get; set; }

        [JsonProperty(PropertyName = "atleta_id")]
        public string IdAtleta { get; set; }

        [JsonProperty(PropertyName = "rodada_id")]
        public string IdRodada { get; set; }

        [JsonProperty(PropertyName = "clube_id")]
        public string IdClube { get; set; }

        [JsonProperty(PropertyName = "posicao_id")]
        public string IdPosição { get; set; }

        [JsonProperty(PropertyName = "status_id")]
        public string IdStatus { get; set; }

        [JsonProperty(PropertyName = "pontos_num")]
        public string NumeroPontos { get; set; }

        [JsonProperty(PropertyName = "preco_num")]
        public string Preco { get; set; }

        [JsonProperty(PropertyName = "variacao_num")]
        public string Variação { get; set; }

        [JsonProperty(PropertyName = "media_num")]
        public string Media { get; set; }

        [JsonProperty(PropertyName = "jogos_num")]
        public string NumeroJogos { get; set; }

        [JsonProperty(PropertyName = "scout")]
        public Scout ListaScout { get; set; }


        #endregion

        public List<Atleta> Get()
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("time/loser1-fc").Result;
                if (response.IsSuccessStatusCode)
                {
                    Task<string> steste = response.Content.ReadAsStringAsync();
                    
                    Time oTime = JsonConvert.DeserializeObject<Time>(steste.Result.ToString());
                    return oTime.ListaAtletas ;
                }
            }
            return new List<Atleta>();
        }
    }
}

