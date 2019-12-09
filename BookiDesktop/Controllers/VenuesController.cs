using BookiDesktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace BookiDesktop.Controllers {
    public class VenuesController {

        private BaseController bCtrl;
        private VenuesGUI venuesGUI;
        public async Task<List<Venue>> Get() {
            List<Venue> VenueInfo = new List<Venue>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("venues");

                if (Res.IsSuccessStatusCode) {
                    var VenueResponse = Res.Content.ReadAsStringAsync().Result;

                    VenueInfo = JsonConvert.DeserializeObject<List<Venue>>(VenueResponse);
                }
            }
            return VenueInfo;
        }

        public async Task<Venue> Get(int id) {
            List<Venue> VenueInfo = new List<Venue>();
            Venue venue = null;
            bCtrl = new BaseController();
                using (var client = bCtrl.GetClient()) {
             
                HttpResponseMessage Res = await client.GetAsync("venues/" + id);

                if (Res.IsSuccessStatusCode) {
                    var VenueResponse = Res.Content.ReadAsStringAsync().Result;

                    VenueInfo = JsonConvert.DeserializeObject<List<Venue>>(VenueResponse);
                    venue = VenueInfo[0];
                }
            }
            
            return venue;
        }

        public async Task<bool> Create(Venue venue) {
            venuesGUI = VenuesGUI.Instance;
            bool res = false;

            bCtrl = new BaseController();
            var root = new {
                Venue = venue
            };
            var json = JsonConvert.SerializeObject(root);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = bCtrl.GetClient()) {
                var response = await client.PostAsync(bCtrl.BaseUrl + "venues/", data);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
            }
            venuesGUI.AddDataToTable();
            return res;
        }

        public async Task<bool> Update(int id, Venue venue) {
            venuesGUI = VenuesGUI.Instance;
            bool res = false;
            bCtrl = new BaseController();
            var root = new {
                Venue = venue
            };
            Debug.WriteLine("id from vctrl: " + id);
            Debug.WriteLine("venueid from vCtrl: " +  venue.Id);
            var json = JsonConvert.SerializeObject(root);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = bCtrl.GetClient()) {
                var response = await client.PutAsync(bCtrl.BaseUrl + "venues/" + id, data);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
            }
            venuesGUI.AddDataToTable();
            return res;
        }

        public async Task<bool> Delete(int id) {
            venuesGUI = VenuesGUI.Instance;
            bool res = false;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {
                var response = await client.DeleteAsync(bCtrl.BaseUrl + "venues/" + id);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
                venuesGUI.AddDataToTable();
                return res;
            }
        }

    }
}
