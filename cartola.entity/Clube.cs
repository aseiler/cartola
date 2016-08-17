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

    public class Clube
    {
        #region Instance
        public static Clube New { get { return new Clube(); } }
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "abreviacao")]
        public string Abreviacao { get; set; }

        [JsonProperty(PropertyName = "posicao")]
        public int Posicao { get; set; }

        [JsonProperty(PropertyName = "escudos")]
        public Escudo oEscudo { get; set; }
        #endregion

        #region Method
        public Clube Get(string sJSON) { return JsonConvert.DeserializeObject<Clube>(sJSON); }
        #endregion
    }
}
