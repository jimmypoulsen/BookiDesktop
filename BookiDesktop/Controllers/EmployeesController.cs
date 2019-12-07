using BookiDesktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            List<Table> tables = new List<Table>();
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

        public async Task<List<Table>> GetTables(int id) {
            TablesController tCtrl = new TablesController();
            List<Table> currTables = await tCtrl.Get();
            List<Table> tables = new List<Table>();
            List<Venue> venueInfo = await GetVenues(id);

            List<int> venueIDs = new List<int>();
            foreach (Venue venue in venueInfo) {
                venueIDs.Add(venue.Id);
                foreach (Table table in currTables) {
                    if (table.VenueId.Equals(venue.Id)) {
                        tables.Add(table);
                    }
                }
            }
            return tables;
        }

    }
}
