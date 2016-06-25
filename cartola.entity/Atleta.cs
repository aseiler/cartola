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
    public class Atleta
    {
        public List<Atleta> Get()
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
                    return jserial.Deserialize<List<Atleta>>(steste.Result.ToString());

                }
            }

            return new List<Atleta>();
        }
    }
}

