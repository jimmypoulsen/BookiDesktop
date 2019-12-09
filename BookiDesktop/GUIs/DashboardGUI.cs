using BookiDesktop.Controllers;
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
        
        public DashboardGUI() {
            InitializeComponent();
            /*SessionsController sCtrl = SessionsController.Instance;
            EmployeeId = sCtrl.currentlyLoggedIn.Id;*/
        }

        public static DashboardGUI Instance {
            get {
                if (instance == null) {
                    instance = new DashboardGUI();
                }
                return instance;
            }
        }

        private void DashboardGUI_Load(object sender, EventArgs e) {

        }

        private void BtnFindVenues_Click(object sender, EventArgs e) {
            EmployeeId = (Int32.Parse(tbEmployeeNo.Text));
            lblDataFetched.Text = "Data found for employee: " + tbEmployeeNo.Text;
        }

    }
}
