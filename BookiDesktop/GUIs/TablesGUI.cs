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
            // Disable editing of cells
            tablesGridView.ReadOnly = true;
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
            EmployeesController eCtrl = new EmployeesController();
            SessionsController sCtrl = SessionsController.Instance;
            tablesGridView.UseWaitCursor = true;
            try {
                tablesGridView.DataSource = await eCtrl.GetTables(sCtrl.EmployeeId);
            } catch(Exception) {
                MessageBox.Show("No connection to service");
            }
            tablesGridView.UseWaitCursor = false;
            tablesGridView.ClearSelection();
            tablesGridView.CurrentCell = null;
        }

        public void DeleteDataFromTable() {
            tablesGridView.DataSource = null;
        }

        private void tablesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (tablesGridView.SelectedCells.Count > 0) {
                    // If header is clicked - do nothing - prevents crash
                    if (e.RowIndex == -1) return;
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = tablesGridView.Rows[index];
                    idFromTable = (int)selectedRow.Cells[0].Value;
                }
            }
        }
    }
}
    

    
