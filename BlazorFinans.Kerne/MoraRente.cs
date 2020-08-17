using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFinans.Kerne
{
    public class MoraRente
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public DateTime Dato { get; set; }
        public double Rente { get; set; }

        public static async Task<List<MoraRente>> HentRente()
        {
            List<MoraRente> renter = new List<MoraRente>();
            var response = await httpClient.GetAsync("https://api.airtable.com/v0/appydrnCzNs4JlU7w/MoraRenter");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<AirTable>(json);
                foreach (var item in data.Records)
                    renter.Add(new MoraRente { Dato = item.Fields.Dato, Rente = item.Fields.Rente });
            }
            return renter.OrderBy(i=>i.Dato).ToList();
        }

        static MoraRente()
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            // Altså - dette er meget hemmeligt!!
            httpClient.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", "keycTnIZ6JMjVwpll");

        }
    }

    internal class AirTable
    {
        public List<AirTableRecord> Records { get; set; }
    }
    internal class AirTableRecord
    {
        public string Id { get; set; }
        public AirTableFields Fields { get; set; }
        public DateTime CreatedTime { get; set; }
    }
    internal class AirTableFields
    {
        public DateTime Dato { get; set; }
        public double Rente { get; set; }
    }
}
