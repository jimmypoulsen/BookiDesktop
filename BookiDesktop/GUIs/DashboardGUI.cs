using BookiDesktop.Controllers;
using BookiDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookiDesktop {
    public partial class DashboardGUI : Form {

        public int EmployeeId { get; set; }
        private static DashboardGUI instance = null;
        private EmployeesController eCtrl;
        private SessionsController sCtrl;
        
        public DashboardGUI() {
            InitializeComponent();
            AddAllStats();
        }

        public static DashboardGUI Instance {
            get {
                if (instance == null) {
                    instance = new DashboardGUI();
                }
                return instance;
            }
        }

        public void AddAllStats() {
            sCtrl = SessionsController.Instance;
            EmployeeId = sCtrl.EmployeeId;
            AddVenueStats();
            AddEmployeeStats();
            AddTableStats();
            AddTablePackageStats();
        }

        public async void AddVenueStats() {
            eCtrl = new EmployeesController();
            List<Venue> venues = await eCtrl.GetVenues(EmployeeId);
            int a = 0;
            foreach (Venue v in venues) {
                if (venues.Count > 0) {
                    a++;
                }
            }
            lblNoOfVenues.Text = "Number of Venues: " + a;
        }

        public async void AddEmployeeStats() {
            eCtrl = new EmployeesController();
            List<Employee> employees = await eCtrl.GetEmployees(EmployeeId);
            int b = 0;
            foreach (Employee e in employees) {
                if (employees.Count > 0) {
                    b++;
                }
            }
            lblNoOfEmployees.Text = "Number of Employees: " + b;
        }

        public async void AddTableStats() {
            eCtrl = new EmployeesController();
            List<Table> tables = await eCtrl.GetTables(EmployeeId);
            int c = 0;
            foreach (Table t in tables) {
                if (tables.Count > 0) {
                    c++;
                }
            }
            lblNoOfTables.Text = "Number of Tables: " + c;
        }

        public async void AddTablePackageStats() {
            eCtrl = new EmployeesController();
            List<TablePackage> tablePackages = await eCtrl.GetTablePackages(EmployeeId);
            int d = 0;
            foreach (TablePackage tp in tablePackages) {
                if (tablePackages.Count > 0) {
                    d++;
                }
            }
            lblNoOfTablePackages.Text = "Number of Table Packages: " + d;
        }      
    }
}

