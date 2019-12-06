using BookiDesktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Controllers {
    public class EmployeesController {

        private BaseController bCtrl;

        public async Task<List<Employee>> Get(int id) {
            List<Employee> EmployeeInfo = new List<Employee>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("employees/" + id);

                if (Res.IsSuccessStatusCode) {
                    var EmployeeResponse = Res.Content.ReadAsStringAsync().Result;

                    EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(EmployeeResponse);
                    Employee employee = EmployeeInfo[0];
                    IEnumerable<Venue> venues = employee.Venues;
                }
            }
            return EmployeeInfo;
        }

        public async Task<List<Venue>> GetVenues(int id) {
            List<Employee> EmployeeInfo = new List<Employee>();
            List<Venue> venues = new List<Venue>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("employees/" + id);

                if (Res.IsSuccessStatusCode) {
                    var EmployeeResponse = Res.Content.ReadAsStringAsync().Result;

                    EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(EmployeeResponse);
                    Employee employee = EmployeeInfo[0];
                    foreach (Venue venue in employee.Venues) {
                        venues.Add(venue);
                    }
                    
                }
            }
            return venues;
        }

    }
}
