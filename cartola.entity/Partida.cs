using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartola.entity
{
    public class Partida
    {
        #region Properties
        [JsonProperty(PropertyName = "clube_casa_id")]
        public int IdClubeCasa { get; set; }

        [JsonProperty(PropertyName = "clube_casa_posicao")]
        public int PosicaoClubeCasa { get; set; }

        [JsonProperty(PropertyName = "aproveitamento_mandante")]
        public string[] AproveitamentoMandate { get; set; }

        [JsonProperty(PropertyName = "clube_visitante_id")]
        public int IdClubeVisitante { get; set; }

        [JsonProperty(PropertyName = "clube_visitante_posicao")]
        public int PosicaoClubeVisitante { get; set; }

        [JsonProperty(PropertyName = "aproveitamento_visitante")]
        public string[] AproveitamentoVisitante { get; set; }

        [JsonProperty(PropertyName = "partida_data")]
        public DateTime DataPartida { get; set; }

        [JsonProperty(PropertyName = "valida")]
        public bool Valida { get; set; }

        [JsonProperty(PropertyName = "placar_oficial_mandante")]
        public string PlacarMandante { get; set; }

        [JsonProperty(PropertyName = "placar_oficial_visitante")]
        public string PlacarVisitante { get; set; }

        [JsonProperty(PropertyName = "url_confronto")]
        public string UrlConfronto { get; set; }

        [JsonProperty(PropertyName = "url_transmissao")]
        public string urlTransmissao { get; set; }
        #endregion
    }
}
