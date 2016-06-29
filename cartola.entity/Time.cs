using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class Time
    {
        public string slug { get; set; }

        [JsonProperty(PropertyName = "Atletas")]
        public List<Atleta> ListaAtletas { get; set; }
    }
}
