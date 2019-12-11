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

        public int IdFromTable { get; set; }

        private static EmployeesGUI instance = null;

        public EmployeesGUI() {
            InitializeComponent();
            AddDataToTable();
            IdFromTable = -1;
            employeesGridView.ReadOnly = true;
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
            SessionsController sCtrl = SessionsController.Instance;
            employeesGridView.UseWaitCursor = true;
            try {
                employeesGridView.DataSource = await eCtrl.GetEmployees(sCtrl.EmployeeId);
            }
            catch (Exception) {
                MessageBox.Show("No connection to service");
            }
            employeesGridView.Columns["Password"].Visible = false;
            employeesGridView.Columns["Salt"].Visible = false;
            employeesGridView.Columns["Venues"].Visible = false;
            employeesGridView.UseWaitCursor = false;
            employeesGridView.ClearSelection();
            employeesGridView.CurrentCell = null;
        }

        public void DeleteDataFromTable() {
            employeesGridView.DataSource = null;
        }

        private void employeesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (employeesGridView.SelectedCells.Count > 0) {
                    // If header is clicked - do nothing - prevents crash
                    if (e.RowIndex == -1) return;
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = employeesGridView.Rows[index];
                    IdFromTable = (int)selectedRow.Cells[0].Value;
                }
            }
        }
    }
}
