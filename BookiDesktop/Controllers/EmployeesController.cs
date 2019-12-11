using BookiDesktop.GUIs;
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
        private EmployeesGUI employeesGUI;

        public async Task<List<Employee>> Get() {
            List<Employee> EmployeeInfo = new List<Employee>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("employees");

                if (Res.IsSuccessStatusCode) {
                    var EmployeeResponse = Res.Content.ReadAsStringAsync().Result;

                    EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(EmployeeResponse);
                }
            }
            return EmployeeInfo;
        }

        // Changed this to return an employee an not a list...
        public async Task<Employee> Get(int id) {
            List<Employee> EmployeeInfo = new List<Employee>();
            Employee employee = null;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("employees/" + id);

                if (Res.IsSuccessStatusCode) {
                    var EmployeeResponse = Res.Content.ReadAsStringAsync().Result;

                    EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(EmployeeResponse);
                    employee = EmployeeInfo[0];
                    IEnumerable<Venue> venues = employee.Venues;
                }
            }
            return employee;
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

        public async Task<List<TablePackage>> GetTablePackages(int id) {
            TablePackagesController tpCtrl = new TablePackagesController();
            List<TablePackage> currTablePackages = await tpCtrl.Get();
            List<TablePackage> tablePackages = new List<TablePackage>();
            List<Venue> venueInfo = await GetVenues(id);

            List<int> venueIDs = new List<int>();
            foreach (Venue venue in venueInfo) {
                venueIDs.Add(venue.Id);
                foreach (TablePackage tablePackage in currTablePackages) {
                    if (tablePackage.VenueId.Equals(venue.Id)) {
                        tablePackages.Add(tablePackage);
                    }
                }
            }
            return tablePackages;
        }

        public async Task<List<Employee>> GetEmployees(int id) {
            List<Employee> currEmployees = await Get();
            List<Venue> venueInfo = await GetVenues(id);
            List<Employee> employees = new List<Employee>();

            List<int> venueIDs = new List<int>();
            foreach (Venue venue in venueInfo) {
                venueIDs.Add(venue.Id);
            }


            foreach (Employee employee in currEmployees) {
                foreach (Venue venue1 in employee.Venues) {
                    foreach (int i in venueIDs) {
                        if (venue1.Id.Equals(i)) {
                            employee.Venue = venue1;
                            employees.Add(employee);
                        }
                    }
                   
                }
            }
            return employees;
        }

        public async Task<int> GetNewEmployeeNo() {
            int i = 0;
            List<int> employeeNumbers = new List<int>();
            List<Employee> employees = await Get();
            if (employees.Count > 0) {
                foreach (Employee e in employees) {
                    employeeNumbers.Add(e.EmployeeNo);
                }
            }
            i = employeeNumbers.Max() + 1;
            return i;
        }

        public async Task<bool> Create(Employee employee, Venue venue) {
            employeesGUI = EmployeesGUI.Instance;
            bool res = false;

            bCtrl = new BaseController();
            var root = new {
                Employee = employee,
                Venue = venue
            };
            var json = JsonConvert.SerializeObject(root);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = bCtrl.GetClient()) {
                var response = await client.PostAsync(bCtrl.BaseUrl + "employees/", data);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
            }
            employeesGUI.AddDataToTable();

            return res;
        }

        public async Task<bool> Delete(int id) {
            employeesGUI = EmployeesGUI.Instance;
            bool res = false;
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {
                var response = await client.DeleteAsync(bCtrl.BaseUrl + "employees/" + id);
                string result = response.Content.ReadAsStringAsync().Result;
                res = true;
                employeesGUI.AddDataToTable();
                return res;
            }

        }


    }
}
