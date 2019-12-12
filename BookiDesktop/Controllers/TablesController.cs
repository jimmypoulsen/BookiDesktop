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

        private TablesGUI tablesGUI;
        private BaseController bCtrl;

        public async Task<List<Table>> Get() {
            List<Table> TableInfo = new List<Table>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {
             
                HttpResponseMessage Res = await client.GetAsync("tables");

                if (Res.IsSuccessStatusCode) {
                    var TableResponse = Res.Content.ReadAsStringAsync().Result;

                    TableInfo = JsonConvert.DeserializeObject<List<Table>>(TableResponse);
                }
            }
            return TableInfo;
        }

        public async Task<Table> Get(int id) {
            List<Table> TableInfo = new List<Table>();
            Table table = null;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("tables/" + id);

                if (Res.IsSuccessStatusCode) {
                    var TableResponse = Res.Content.ReadAsStringAsync().Result;

                    TableInfo = JsonConvert.DeserializeObject<List<Table>>(TableResponse);
                    table = TableInfo[0];
                }
            }

            return table;
        }

        public async Task<bool> Create(Table table) {
            tablesGUI = TablesGUI.Instance;
            bool res = false;

            bCtrl = new BaseController();
            var root = new {
                Table = table
            };
            var json = JsonConvert.SerializeObject(root);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = bCtrl.GetClient()) {
                var response = await client.PostAsync(bCtrl.BaseUrl + "tables/", data);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
            }
           tablesGUI.AddDataToTable();

            return res;
        }

        public async Task<bool> Delete(int id) {
            tablesGUI = TablesGUI.Instance;
            bool res = false;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {
                var response = await client.DeleteAsync(bCtrl.BaseUrl + "tables/" + id);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
                tablesGUI.AddDataToTable();
                return res;
            }
        }

    }

}

