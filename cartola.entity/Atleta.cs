using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;



namespace cartola.entity
{
    public enum Posicao
    {
        G=1,
        L=2,
        Z=3,
        M=4,
        A=5,
        T=6
    }

    public class Atleta
    {
        #region Properties
        
        [JsonProperty(PropertyName="nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "apelido")]
        public string Apelido { get; set; }

        [JsonProperty(PropertyName = "foto")]
        public string Foto { get; set; }

        [JsonProperty(PropertyName = "atleta_id")]
        public int IdAtleta { get; set; }

        [JsonProperty(PropertyName = "rodada_id")]
        public int IdRodada { get; set; }

        [JsonProperty(PropertyName = "clube_id")]
        public int IdClube { get; set; }

        [JsonProperty(PropertyName = "posicao_id")]
        public Posicao IdPosicao { get; set; }

        [JsonProperty(PropertyName = "status_id")]
        public int IdStatus { get; set; }

        [JsonProperty(PropertyName = "pontos_num")]
        public decimal NumeroPontos { get; set; }

        [JsonProperty(PropertyName = "preco_num")]
        public decimal Preco { get; set; }

        [JsonProperty(PropertyName = "variacao_num")]
        public decimal Variação { get; set; }

        [JsonProperty(PropertyName = "media_num")]
        public decimal Media { get; set; }

        [JsonProperty(PropertyName = "jogos_num")]
        public int NumeroJogos { get; set; }

        [JsonProperty(PropertyName = "scout")]
        public Scout Scout { get; set; }

        public AtletaPontuado oAtletaPontuado { get; set; }

        #endregion
    }
}

