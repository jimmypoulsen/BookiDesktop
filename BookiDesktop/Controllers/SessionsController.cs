using BookiDesktop.GUIs;
using BookiDesktop.Helpers;
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

    public class SessionsController {

        private BaseController bCtrl;
        private static SessionsController instance = null;
        public int EmployeeId;

        public static SessionsController Instance {
            get {
                if (instance == null) {
                    instance = new SessionsController();
                }
                return instance;
            }
        }

        public async Task<bool> Login(Employee res) {
            bCtrl = new BaseController();
            bool valid = false;
            if (res.Email != null && res.Password != null) {

                res.Password = HashingHelper.GenerateHash(res.Password);

                var employee = new {
                    Employee = res
                };
                var json = JsonConvert.SerializeObject(employee);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var url = bCtrl.BaseUrl + "/employeesessions";
                using (var client = new HttpClient()) {
                    var response = await client.PostAsync(url, data);
                    EmployeeId = -1;
                    try {
                        EmployeeId = Int32.Parse(response.Content.ReadAsStringAsync().Result);
                    }
                    catch(Exception) {
                        
                    }

                    if (response.IsSuccessStatusCode && EmployeeId != -1) {
                        valid = true;
                        await CurrentlyLoggedInAsync(EmployeeId);
                    }
                }
            }
            return valid;
         }

        public void LogOut() {
            MainMenuGUI mmGUI = MainMenuGUI.Instance;   
            LoginGUI lGUI = new LoginGUI();
            mmGUI.Hide();
            lGUI.Show();
            mmGUI = null;
            CleanSession();

        }

        public void CleanSession() {
            DashboardGUI dGUI = DashboardGUI.Instance;
            VenuesGUI vGUI = VenuesGUI.Instance;
            EmployeesGUI eGUI = EmployeesGUI.Instance;
            TablesGUI tGUI = TablesGUI.Instance;
            TablePackagesGUI tpGUI = TablePackagesGUI.Instance;

            vGUI.DeleteDataFromTable();
            eGUI.DeleteDataFromTable();
            tGUI.DeleteDataFromTable();
            tpGUI.DeleteDataFromTable();
            vGUI.DeleteDataFromTable();

            dGUI = null;

        }

        public async Task CurrentlyLoggedInAsync(int EmployeeId) {
            MainMenuGUI mmGUI = MainMenuGUI.Instance;
            EmployeesController eCtrl = new EmployeesController();
            Employee employee = await eCtrl.Get(EmployeeId);
            mmGUI.setCurrentlyLoggedIn(employee);
        }

    }
}
