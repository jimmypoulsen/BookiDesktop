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
    public partial class TablePackagesGUI : Form {
        public int idFromTable { get; set; }
        private static TablePackagesGUI instance = null;

        public TablePackagesGUI() {
            InitializeComponent();
            AddDataToTable();
            idFromTable = -1;
            // Disable editing of cells
            tablePackagesGridView.ReadOnly = true;
        }

        public static TablePackagesGUI Instance {
            get {
                if (instance == null) {
                    instance = new TablePackagesGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            EmployeesController eCtrl = new EmployeesController();
            SessionsController sCtrl = SessionsController.Instance;
            tablePackagesGridView.UseWaitCursor = true;
            try {
                tablePackagesGridView.DataSource = await eCtrl.GetTablePackages(sCtrl.EmployeeId);
            }
            catch (Exception) {
                MessageBox.Show("No connection to service");
            }
            tablePackagesGridView.UseWaitCursor = false;
            tablePackagesGridView.ClearSelection();
            tablePackagesGridView.CurrentCell = null;
        }

        public void DeleteDataFromTable() {
            tablePackagesGridView.DataSource = null;
        }

        private void tablePackagesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (tablePackagesGridView.SelectedCells.Count > 0) {
                    // If header is clicked - do nothing - prevents crash
                    if (e.RowIndex == -1) return;
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = tablePackagesGridView.Rows[index];
                    idFromTable = (int)selectedRow.Cells[0].Value;
                }
            }
        }


    }
}

