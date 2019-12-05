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
            VenuesController vCtrl = new VenuesController();
            venuesGridView.UseWaitCursor = true;
            venuesGridView.DataSource = await vCtrl.Get();
            venuesGridView.UseWaitCursor = false;
        }

        public void RefreshDataGrid() {
            venuesGridView.Update();
            venuesGridView.Refresh();
        }

        private void venuesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (venuesGridView.SelectedCells.Count > 0) {

                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = venuesGridView.Rows[index];
                    idFromTable = (int) selectedRow.Cells[0].Value;
                    lblSelectedRow.Text = "" + idFromTable;

                }
            }
        }
    }
}
