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
    public class TablePackagesController {

        private TablePackagesGUI tablePackagesGUI;
        private BaseController bCtrl;
        public async Task<List<TablePackage>> Get() {
            List<TablePackage> TablePackageInfo = new List<TablePackage>();
            bCtrl = new BaseController();

            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("tablePackages");

                if (Res.IsSuccessStatusCode) {
                    var TablePackageResponse = Res.Content.ReadAsStringAsync().Result;

                    TablePackageInfo = JsonConvert.DeserializeObject<List<TablePackage>>(TablePackageResponse);
                }
            }
            return TablePackageInfo;
        }

        public async Task<TablePackage> Get(int id) {
            List<TablePackage> TablePackageInfo = new List<TablePackage>();
            TablePackage tablePackage = null;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("tablePackages/" + id);

                if (Res.IsSuccessStatusCode) {
                    var TablePackageResponse = Res.Content.ReadAsStringAsync().Result;

                    TablePackageInfo = JsonConvert.DeserializeObject<List<TablePackage>>(TablePackageResponse);
                    tablePackage = TablePackageInfo[0];
                }
            }

            return tablePackage;
        }

        public async Task<bool> Create(TablePackage tablePackage) {
            tablePackagesGUI = TablePackagesGUI.Instance;
            bool res = false;

            bCtrl = new BaseController();
            var root = new {
                TablePackage = tablePackage
            };
            var json = JsonConvert.SerializeObject(root);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = bCtrl.GetClient()) {
                var response = await client.PostAsync(bCtrl.BaseUrl + "tablePackages/", data);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
            }
            tablePackagesGUI.AddDataToTable();

            return res;
        }

        public async Task<bool> Delete(int id) {
            tablePackagesGUI = TablePackagesGUI.Instance;
            bool res = false;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {
                var response = await client.DeleteAsync(bCtrl.BaseUrl + "tablePackages/" + id);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
                tablePackagesGUI.AddDataToTable();
                return res;
            }

        }
    }
}
