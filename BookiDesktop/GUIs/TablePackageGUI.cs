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
    public partial class TablePackageGUI : Form {

        private bool create;
        private TablePackage editedTablePackage;
        private TablePackagesGUI tablePackagesGUI;

        public TablePackageGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;
        }

        public async void Edit() {
            TablePackagesController tpCtrl = new TablePackagesController();
            tablePackagesGUI = TablePackagesGUI.Instance;
            editedTablePackage = await tpCtrl.Get(tablePackagesGUI.idFromTable);
            lblBool.Text = "editedTablePackageID: " + editedTablePackage.Id;
            create = false;
            lblTitle.Text = "Edit Table Package";
            BtnSaveChanges.Text = "Save changes";
            tbName.Text = editedTablePackage.Name;
            tbPrice.Text = "" + editedTablePackage.Price;
            tbVenueID.ReadOnly = true;
            tbVenueID.Text = "" + tablePackagesGUI.idFromTable;
        }

        public void Create() {
            //bool res = false;
            TablePackagesController vCtrl = new TablePackagesController();
            lblBool.Text = "Creating Table Package";
            tablePackagesGUI = TablePackagesGUI.Instance;
            lblTitle.Text = "Create Table Package";
            BtnSaveChanges.Text = "Create";

            create = true;
            tbName.Text = "";
            tbPrice.Text = "";
            tbVenueID.Text = "";
            //res = true;
            // return res;
        }


        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            TablePackagesController tpCtrl = new TablePackagesController();
            if (TextBoxesHasValues()) {
                if (create) {
                    TablePackage newTablePackage = new TablePackage { Name = tbName.Text, Price = Int32.Parse(tbPrice.Text), VenueId = Int32.Parse(tbVenueID.Text) };
                    await tpCtrl.Create(newTablePackage);
                    this.Visible = false;
                }/* else if (!create) {
                    int id = editedTablePackage.Id;
                    TablePackage updatedTablePackage = await tpCtrl.Get(editedTablePackage.Id);
                    await tpCtrl.Update(updatedTablePackage.Id, updatedTablePackage);
                    this.Visible = false;
                }*/

                else {
                    MessageBox.Show("Error...One or more fields are empty!"); ;
                }
            }
        }

            public bool TextBoxesHasValues() {
                bool res = false;
                if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPrice.Text) && !string.IsNullOrWhiteSpace(tbVenueID.Text)) {
                    res = true;
                }
                return res;
            }
        }
    }


