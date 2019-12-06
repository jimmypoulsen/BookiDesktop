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
    public partial class TablesGUI : Form {

        public int idFromTable { get; set; }

        private static TablesGUI instance = null;

        public TablesGUI() {
            InitializeComponent();
            AddDataToTable();
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
            TablesController tCtrl = new TablesController();
            tablesGridView.UseWaitCursor = true;
            tablesGridView.DataSource = await tCtrl.Get();
            tablesGridView.UseWaitCursor = false;
        }

        private void tablesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
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
    

    
