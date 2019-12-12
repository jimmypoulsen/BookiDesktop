using BookiDesktop.GUIs;
using BookiDesktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Controllers {

    public class ReservationsController {

        private ReservationsGUI reservationsGUI;
        private BaseController bCtrl;

        public async Task<List<Reservation>> Get() {
            List<Reservation> ReservationInfo = new List<Reservation>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("reservations");

                if (Res.IsSuccessStatusCode) {
                    var ReservationResponse = Res.Content.ReadAsStringAsync().Result;

                    ReservationInfo = JsonConvert.DeserializeObject<List<Reservation>>(ReservationResponse);
                }
            }
            return ReservationInfo;
        }

        public async Task<bool> Delete(int id) {
            reservationsGUI = ReservationsGUI.Instance;
            bool res = false;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {
                var response = await client.DeleteAsync(bCtrl.BaseUrl + "reservations/" + id);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
                reservationsGUI.AddDataToTable();
                return res;
            }
        }

    }
}
