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
        //private readonly string BaseUrl;
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

    }
}
