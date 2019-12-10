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
    public partial class VenuesGUI : Form {
        public int idFromTable { get; set; }

        private static VenuesGUI instance = null;

        public VenuesGUI() {
            InitializeComponent();
            AddDataToTable();
            idFromTable = -1;
            // Disable editing of cells
            venuesGridView.ReadOnly = true;
        }
        public static VenuesGUI Instance {
            get {
                if (instance == null) {
                    instance = new VenuesGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            EmployeesController eCtrl = new EmployeesController();
            SessionsController sCtrl = SessionsController.Instance;
            venuesGridView.UseWaitCursor = true;
            try {
                venuesGridView.DataSource = await eCtrl.GetVenues(sCtrl.EmployeeId);
            }
            catch (Exception) {
                MessageBox.Show("No connection to service");
            }
            venuesGridView.UseWaitCursor = false;
            venuesGridView.ClearSelection();
            venuesGridView.CurrentCell = null;
        }

        public void DeleteDataFromTable() {
            venuesGridView.DataSource = null;
        }

        public void RefreshDataGrid() {
            venuesGridView.Update();
            venuesGridView.Refresh();
        }

        private void venuesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (venuesGridView.SelectedCells.Count > 0) {
                    // If header is clicked - do nothing - prevents crash
                    if (e.RowIndex == -1) return;
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = venuesGridView.Rows[index];
                    idFromTable = (int) selectedRow.Cells[0].Value;
                }
            }
        }
    }
}
