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

        private static DashboardGUI instance = null;

        public DashboardGUI() {
            InitializeComponent();
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

        private async void BtnFindVenues_Click(object sender, EventArgs e) {
            EmployeesController eCtrl = new EmployeesController();
            venuesGridView.UseWaitCursor = true;
            venuesGridView.DataSource = await eCtrl.GetVenues(Int32.Parse(tbEmployeeNo.Text));
            venuesGridView.UseWaitCursor = false;
        }

    }
}
