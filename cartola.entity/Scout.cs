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
        public string CA { get; set; }

        [JsonProperty(PropertyName = "FC")]
        public string FC { get; set; }
        
        [JsonProperty(PropertyName = "FD")]
        public string FD { get; set; }
        
        [JsonProperty(PropertyName = "FF")]
        public string FF { get; set; }
        
        [JsonProperty(PropertyName = "FS")]
        public string FS { get; set; }
        
        [JsonProperty(PropertyName = "FT")]
        public string FT { get; set; }
        
        [JsonProperty(PropertyName = "G")]
        public string G { get; set; }
        
        [JsonProperty(PropertyName = "I")]
        public string I { get; set; }
        
        [JsonProperty(PropertyName = "PE")]
        public string PE { get; set; }
       
        [JsonProperty(PropertyName = "RB")]
        public string RB { get; set; }


    }
}
