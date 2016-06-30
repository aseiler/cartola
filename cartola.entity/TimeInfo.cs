using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class TimeInfo
    {
        [JsonProperty(PropertyName = "time_id")]
        public int IdTime { get; set; }

        [JsonProperty(PropertyName = "clube_id")]
        public int IdClube { get; set; }

        [JsonProperty(PropertyName = "esquema_id")]
        public int IdEsquema { get; set; }

        [JsonProperty(PropertyName = "cadun_id")]
        public int IdCadun { get; set; }

        [JsonProperty(PropertyName = "facebook_id")]
        public string IdFacebook { get; set; }

        [JsonProperty(PropertyName = "foto_perfil")]
        public string FotoPerfil { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "nome_cartola")]
        public string NomeCartola { get; set; }

        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "tipo_escudo")]
        public int TipoEscudo { get; set; }

        [JsonProperty(PropertyName = "cor_fundo_escudo")]
        public string CorFundoEscudo { get; set; }

        [JsonProperty(PropertyName = "cor_borda_escudo")]
        public string CorBordaEscudo { get; set; }

        [JsonProperty(PropertyName = "cor_primaria_estampa_escudo")]
        public string CorPrimariaEstampaEscudo { get; set; }

        [JsonProperty(PropertyName = "cor_secundaria_estampa_escudo")]
        public string CorSecundariaEstampaEscudo { get; set; }

        [JsonProperty(PropertyName = "url_escudo_svg")]
        public string URLEscudoSVG { get; set; }

        [JsonProperty(PropertyName = "url_escudo_png")]
        public string URLEscudoPNG { get; set; }

        [JsonProperty(PropertyName = "url_camisa_svg")]
        public string UrlCamisaSVG { get; set; }

        [JsonProperty(PropertyName = "url_camisa_png")]
        public string UrlCamisaPNG { get; set; }

        [JsonProperty(PropertyName = "url_escudo_placeholder_png")]
        public string UrlEscudoPlaceholderPNG { get; set; }

        [JsonProperty(PropertyName = "url_camisa_placeholder_png")]
        public string UrlCamisaPlaceholderPNG { get; set; }

        [JsonProperty(PropertyName = "tipo_estampa_escudo")]
        public int TipoEstampaEscudo { get; set; }

        [JsonProperty(PropertyName = "tipo_adorno")]
        public int TipoAdorno { get; set; }

        [JsonProperty(PropertyName = "tipo_camisa")]
        public int TipoCamisa { get; set; }

        [JsonProperty(PropertyName = "tipo_estampa_camisa")]
        public int TipoEstampaCamisa { get; set; }

        [JsonProperty(PropertyName = "cor_camisa")]
        public string CorCamisa { get; set; }

        [JsonProperty(PropertyName = "cor_primaria_estampa_camisa")]
        public string CorPrimariaEstampaCamisa { get; set; }

        [JsonProperty(PropertyName = "cor_secundaria_estampa_camisa")]
        public string CorSecundariaEstampaCamisa { get; set; }

        [JsonProperty(PropertyName = "assinante")]
        public bool Assinante { get; set; }

        [JsonProperty(PropertyName = "cadastro_completo")]
        public bool CadastroCompleto { get; set; }

        [JsonProperty(PropertyName = "patrocinador1_id")]
        public int IdPatrocinador1 { get; set; }

        [JsonProperty(PropertyName = "patrocinador2_id")]
        public int IdPatrocinador2 { get; set; }

    }
}
