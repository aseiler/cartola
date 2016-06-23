using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Cartola
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string steste;
        class ListaAtletas
        {
            public List<Atleta> Atletas { get; set; }

        }
        class Atleta
        {
            public string Nome { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.cartolafc.globo.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("time/loser1-fc").Result;
                if (response.IsSuccessStatusCode)
                {
                    Task<string> steste = response.Content.ReadAsStringAsync();
                    JavaScriptSerializer jserial = new JavaScriptSerializer();
                    ListaAtletas oAtleta = jserial.Deserialize<ListaAtletas>(steste.Result.ToString());

                    GridView1.DataSource = oAtleta.Atletas;
                    GridView1.DataBind();

                }
            }

        }
    }
}