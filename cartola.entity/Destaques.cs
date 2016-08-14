using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class Destaques
    {
        [JsonProperty(PropertyName = "media_pontos")]
        public string MediaPontos { get; set; }

        [JsonProperty(PropertyName = "media_cartoletas")]
        public string MediaCartoleta { get; set; }
    }
}