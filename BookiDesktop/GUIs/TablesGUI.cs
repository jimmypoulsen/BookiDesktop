using BookiDesktop.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookiDesktop {
    public partial class TablesGUI : Form {

        public int idFromTable { get; set; }

        private static TablesGUI instance = null;

        public TablesGUI() {
            InitializeComponent();
            AddDataToTable();
            idFromTable = -1;
        }

        public static TablesGUI Instance {
            get {
                if (instance == null) {
                    instance = new TablesGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            //TablesController tCtrl = new TablesController();
            EmployeesController eCtrl = new EmployeesController();
            DashboardGUI dashboardGUI = DashboardGUI.Instance;
            tablesGridView.UseWaitCursor = true;
            //tablesGridView.DataSource = await tCtrl.Get();
            Debug.WriteLine("employeeNo: " + dashboardGUI.EmployeeNo);
            tablesGridView.DataSource = await eCtrl.GetTables(dashboardGUI.EmployeeNo);
            tablesGridView.UseWaitCursor = false;
            lblSelectedRow.Text = "";
            tablesGridView.ClearSelection();
            tablesGridView.CurrentCell = null;
        }

        private void tablesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (tablesGridView.SelectedCells.Count > 0) {

                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = tablesGridView.Rows[index];
                    idFromTable = (int)selectedRow.Cells[0].Value;
                    lblSelectedRow.Text = "Selected row: " + idFromTable;

                }
            }
        }
    }
}
    

    
