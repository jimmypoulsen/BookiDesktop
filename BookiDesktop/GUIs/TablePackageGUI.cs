using BookiDesktop.Controllers;
using BookiDesktop.Models;
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
    public partial class TablePackageGUI : Form {

        private bool create;
        private TablePackage editedTablePackage;
        private TablePackagesGUI tablePackagesGUI;
        private SessionsController sCtrl;

        public TablePackageGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;
            sCtrl = SessionsController.Instance;
        }

        public async void Edit() {
            TablePackagesController tpCtrl = new TablePackagesController();
            VenuesController vCtrl = new VenuesController();
            tablePackagesGUI = TablePackagesGUI.Instance;

            try {
                editedTablePackage = await tpCtrl.Get(tablePackagesGUI.idFromTable);

                // Finding venue from venueID on table and adding it to combobox.
                Venue venue = await vCtrl.Get(editedTablePackage.VenueId);

                // Creating a list because combobox demands it.
                var venuesList = new List<Venue>();
                venuesList.Add(venue);

                lblTitle.Text = "Edit Table Package";
                create = false;
                BtnSaveChanges.Text = "Save changes";
                tbName.Text = editedTablePackage.Name;
                tbPrice.Text = "" + editedTablePackage.Price;

                cbVenue.DataSource = venuesList;
            }
            catch(Exception) {
                MessageBox.Show("No connection to service");
                this.Visible = false;
            }

            // Resetting idFromTable to remove possibility to show other employees tables
            tablePackagesGUI.idFromTable = -1;
        }

        public async void Create() {
            TablesController vCtrl = new TablesController();
            EmployeesController eCtrl = new EmployeesController();
            tablePackagesGUI = TablePackagesGUI.Instance;
            lblTitle.Text = "Create Table Package";
            BtnSaveChanges.Text = "Create";
            var venuesList = new List<Venue>();

            try {
                List<Venue> venues = await eCtrl.GetVenues(sCtrl.EmployeeId);
                foreach (Venue v in venues) {
                    venuesList.Add(v);
                }
                cbVenue.DataSource = venuesList;
            }
            catch (Exception) {
                MessageBox.Show("No connection to service");
            }

            create = true;
            tbName.Text = "";
            tbPrice.Text = "";
        }


        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            TablePackagesController tpCtrl = new TablePackagesController();
            DashboardGUI dGUI = DashboardGUI.Instance;

            if (TextBoxesHasValues()) {
                if (create) {
                    try {
                        Venue currVenue = (Venue)cbVenue.SelectedItem;
                        TablePackage newTablePackage = new TablePackage { Name = tbName.Text, Price = Int32.Parse(tbPrice.Text), VenueId = currVenue.Id };
                        await tpCtrl.Create(newTablePackage);
                        this.Visible = false;
                        dGUI.AddTablePackageStats();
                    }
                    catch(Exception) {
                        MessageBox.Show("No connection to service");
                    }
                } else if (!create) {
                    MessageBox.Show("Method not implemented");
                    this.Visible = false;
                    /*int id = editedTablePackage.Id;
                    TablePackage updatedTablePackage = await tpCtrl.Get(editedTablePackage.Id);
                    await tpCtrl.Update(updatedTablePackage.Id, updatedTablePackage);
                    this.Visible = false;*/
                }

                else {
                    MessageBox.Show("Error...One or more fields are empty!"); ;
                }
            }
        }

        public bool TextBoxesHasValues() {
            bool res = false;
            if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPrice.Text)) {
                res = true;
            }
            return res;
        }
        
    }
}

    


