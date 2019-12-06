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
            TablePackagesController tpCtrl = new TablePackagesController();
            tablePackagesGridView.UseWaitCursor = true;
            tablePackagesGridView.DataSource = await tpCtrl.Get();
            tablePackagesGridView.UseWaitCursor = false;
            lblSelectedRow.Text = "";
            tablePackagesGridView.ClearSelection();
            tablePackagesGridView.CurrentCell = null;
        }

        private void tablePackagesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            {
                if (tablePackagesGridView.SelectedCells.Count > 0) {

                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = tablePackagesGridView.Rows[index];
                    idFromTable = (int)selectedRow.Cells[0].Value;
                    lblSelectedRow.Text = "Selected row: " + idFromTable;

                }
            }
        }


    }
}

