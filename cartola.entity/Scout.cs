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
        public string CartaoAmarelo { get; set; }

        [JsonProperty(PropertyName = "FC")]
        public string FaltaCometida { get; set; }
        
        [JsonProperty(PropertyName = "FD")]
        public string FinalizacaoDefendida { get; set; }
        
        [JsonProperty(PropertyName = "FF")]
        public string FinalizacaoFora { get; set; }
        
        [JsonProperty(PropertyName = "FS")]
        public string FaltaSofrida { get; set; }
        
        [JsonProperty(PropertyName = "FT")]
        public string FinalizacaoTrave { get; set; }
        
        [JsonProperty(PropertyName = "G")]
        public string Gol { get; set; }
        
        [JsonProperty(PropertyName = "I")]
        public string Impedimento { get; set; }
        
        [JsonProperty(PropertyName = "PE")]
        public string PasseErrado { get; set; }
       
        [JsonProperty(PropertyName = "RB")]
        public string RoubadaBola { get; set; }


    }
}
