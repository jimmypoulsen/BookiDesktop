using BookiDesktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Controllers {
    public class TablesController {

        private BaseController bCtrl;

        public async Task<List<Table>> Get() {
            List<Table> TableInfo = new List<Table>();
            bCtrl = new BaseController();
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri(bCtrl.BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("tables");

                if (Res.IsSuccessStatusCode) {
                    var TableResponse = Res.Content.ReadAsStringAsync().Result;

                    TableInfo = JsonConvert.DeserializeObject<List<Table>>(TableResponse);
                }
            }

            return TableInfo;

        }
    }

}

