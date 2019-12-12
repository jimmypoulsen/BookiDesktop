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

namespace BookiDesktop.GUIs {
    public partial class ReservationsGUI : Form {

        private static ReservationsGUI instance = null;
        public int IdFromTable { get; set; }

        public ReservationsGUI() {
            InitializeComponent();
            AddDataToTable();
            IdFromTable = -1;
            reservationsGridView.ReadOnly = true;
        }

        public static ReservationsGUI Instance {
            get {
                if (instance == null) {
                    instance = new ReservationsGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            //ReservationsController rCtrl = new ReservationsController();
            EmployeesController eCtrl = new EmployeesController();
            SessionsController sCtrl = SessionsController.Instance;
            reservationsGridView.UseWaitCursor = true;
            try {
                reservationsGridView.DataSource = await eCtrl.GetReservations(sCtrl.EmployeeId);
            }
            catch (Exception) {
                MessageBox.Show("No connection to service");
            }
            reservationsGridView.UseWaitCursor = false;
            reservationsGridView.ClearSelection();
            reservationsGridView.CurrentCell = null;
        }

        public void DeleteDataFromTable() {
            reservationsGridView.DataSource = null;
        }


        private void reservationsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (reservationsGridView.SelectedCells.Count > 0) {
                    Debug.WriteLine("Selected row: " + IdFromTable);
                    // If header is clicked - do nothing - prevents crash
                    if (e.RowIndex == -1) return;
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = reservationsGridView.Rows[index];
                    IdFromTable = (int)selectedRow.Cells[0].Value;
                }
            }
        }
    }
}
