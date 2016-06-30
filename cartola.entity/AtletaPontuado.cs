using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class AtletaPontuado
    {
        [JsonProperty(PropertyName = "apelido")]
        public string Apelido { get; set; }

        [JsonProperty(PropertyName = "pontuacao")]
        public decimal Pontuacao { get; set; }

        [JsonProperty(PropertyName = "foto")]
        public string Foto { get; set; }

        [JsonProperty(PropertyName = "posicao_id")]
        public int IdPosicao { get; set; }

        [JsonProperty(PropertyName = "clube_id")]
        public int IdClube { get; set; }

    }
}
