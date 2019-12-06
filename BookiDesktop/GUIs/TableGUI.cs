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

namespace BookiDesktop.GUIs {
    public partial class TableGUI : Form {

        private bool create;
        private Table editedTable;
        private TablesGUI tablesGUI;
        public TableGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;

        }

        public async void Edit() {
            TablesController tCtrl = new TablesController();
            tablesGUI = TablesGUI.Instance;
            editedTable = await tCtrl.Get(tablesGUI.idFromTable);
            lblBool.Text = "editedTableID: " + editedTable.Id;
            create = false;
            lblTitle.Text = "Edit Table";
            BtnSaveChanges.Text = "Save changes";
            tbSeats.Text = "" + editedTable.NoOfSeats;
            tbName.Text = editedTable.Name;
            tbVenueID.Text = "" + editedTable.VenueId;
        }

        public void Create() {
            //bool res = false;
            TablesController vCtrl = new TablesController();
            lblBool.Text = "Creating Table";
            tablesGUI = TablesGUI.Instance;
            lblTitle.Text = "Create Table";
            BtnSaveChanges.Text = "Create";

            create = true;
            tbSeats.Text = "";
            tbName.Text = "";
            tbVenueID.Text = "";
            //res = true;
            // return res;
        }

        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            TablesController tCtrl = new TablesController();
            if (TextBoxesHasValues()) {
                if (create) {
                    Table newTable = new Table { NoOfSeats = Int32.Parse(tbSeats.Text), Name = tbName.Text, VenueId = Int32.Parse(tbVenueID.Text) };
                    await tCtrl.Create(newTable);
                    this.Visible = false;
                }/* else if (!create) {
                    int id = editedTable.Id;
                    Table updatedTable = await tCtrl.Get(editedTable.Id);
                    await tCtrl.Update(updatedTable.Id, updatedTable);
                    this.Visible = false;
                }*/

                else {
                    MessageBox.Show("Error...One or more fields are empty!"); ;
                }
            }
        }

        public bool TextBoxesHasValues() {
            bool res = false;
            if (!string.IsNullOrWhiteSpace(tbSeats.Text) && !string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbVenueID.Text)) {
                res = true;
            }
            return res;
        }

    }
}
