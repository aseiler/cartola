using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class TimeCartola
    {
        [JsonProperty(PropertyName = "time_id")]
        public int IdTime { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "nome_cartola")]
        public string NomeCartola { get; set; }

        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "facebook_id")]
        public string IdFacebook { get; set; }

        [JsonProperty(PropertyName = "url_escudo_png")]
        public string UrlEscudoPng { get; set; }

        [JsonProperty(PropertyName = "url_escudo_svg")]
        public string UrlEscudoSvg { get; set; }

        [JsonProperty(PropertyName = "foto_perfil")]
        public string FotoPerfil { get; set; }

        [JsonProperty(PropertyName = "assinante")]
        public bool Assinante { get; set; }
    }
}
