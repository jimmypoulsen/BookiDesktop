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

namespace BookiDesktop.GUIs {
    public partial class EmployeesGUI : Form {

        public int idFromTable { get; set; }

        private static EmployeesGUI instance = null;

        public EmployeesGUI() {
            InitializeComponent();
            AddDataToTable();
            idFromTable = -1;
        }

        public static EmployeesGUI Instance {
            get {
                if (instance == null) {
                    instance = new EmployeesGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            EmployeesController eCtrl = new EmployeesController();
            DashboardGUI dashboardGUI = DashboardGUI.Instance;
            employeesGridView.UseWaitCursor = true;
            employeesGridView.DataSource = await eCtrl.GetEmployees(dashboardGUI.EmployeeNo);
            employeesGridView.UseWaitCursor = false;
            //lblSelectedRow.Text = "";
            employeesGridView.ClearSelection();
            employeesGridView.CurrentCell = null;
        }

    }
}
