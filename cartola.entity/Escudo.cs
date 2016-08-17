using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    #region Properties
    public class Escudo
    {
        [JsonProperty(PropertyName = "60x60")]
        public string Foto60x60 { get; set; }

        [JsonProperty(PropertyName = "45x45")]
        public string Foto45x45 { get; set; }

        [JsonProperty(PropertyName = "30x30")]
        public string Foto30x30 { get; set; }

    }
    #endregion
}
