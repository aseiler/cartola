using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class Scout
    {

        [JsonProperty(PropertyName = "CA")]
        public int CartaoAmarelo { get; set; }

        [JsonProperty(PropertyName = "FC")]
        public int FaltaCometida { get; set; }
        
        [JsonProperty(PropertyName = "FD")]
        public int FinalizacaoDefendida { get; set; }
        
        [JsonProperty(PropertyName = "FF")]
        public int FinalizacaoFora { get; set; }
        
        [JsonProperty(PropertyName = "FS")]
        public int FaltaSofrida { get; set; }
        
        [JsonProperty(PropertyName = "FT")]
        public int FinalizacaoTrave { get; set; }
        
        [JsonProperty(PropertyName = "G")]
        public int Gol { get; set; }
        
        [JsonProperty(PropertyName = "I")]
        public int Impedimento { get; set; }
        
        [JsonProperty(PropertyName = "PE")]
        public int PasseErrado { get; set; }
       
        [JsonProperty(PropertyName = "RB")]
        public int RoubadaBola { get; set; }


    }
}
