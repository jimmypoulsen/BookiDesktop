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
    public class VenuesController {
        //string BaseUrl = "https://localhost:44314/api/";
        private BaseController bCtrl;
        public async Task<List<Venue>> Get() {
            List<Venue> VenueInfo = new List<Venue>();
            bCtrl = new BaseController();
            using (var client = new HttpClient()) {
                // client.BaseAddress = new Uri(BaseUrl);
                client.BaseAddress = new Uri(bCtrl.BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

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
            using (var client = new HttpClient()) {
                // client.BaseAddress = new Uri(BaseUrl);
                client.BaseAddress = new Uri(bCtrl.BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("venues/" + id);

                if (Res.IsSuccessStatusCode) {
                    var VenueResponse = Res.Content.ReadAsStringAsync().Result;

                    VenueInfo = JsonConvert.DeserializeObject<List<Venue>>(VenueResponse);
                    venue = VenueInfo[0];
                }
            }
            
            return venue;
        }

        /*public async Task<Venue> Get(int id) {
            Venue venue = null;
            bCtrl = new BaseController();
            using (var client = new HttpClient()) {
                // client.BaseAddress = new Uri(BaseUrl);
                client.BaseAddress = new Uri(bCtrl.BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("venues/" + id);

                if (Res.IsSuccessStatusCode) {
                    var VenueResponse = Res.Content.ReadAsStringAsync().Result;

                    venue = JsonConvert.DeserializeObject<Venue> (VenueResponse);
                }
            }
            return venue;
        }*/

    }
}
