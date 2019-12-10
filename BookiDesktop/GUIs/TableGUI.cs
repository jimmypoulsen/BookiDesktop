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
    public partial class TableGUI : Form {

        private bool create;
        private Table editedTable;
        private TablesGUI tablesGUI;
        private SessionsController sCtrl;

        public TableGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;
            sCtrl = SessionsController.Instance;
        }

        public async void Edit() {
            TablesController tCtrl = new TablesController();
            VenuesController vCtrl = new VenuesController();
            tablesGUI = TablesGUI.Instance;
            Venue venue = null;
            try {
                // Finding venue from venueID on table and adding it to combobox.
                editedTable = await tCtrl.Get(tablesGUI.idFromTable);
                venue = await vCtrl.Get(editedTable.VenueId);
                // Creating a list because combobox demands it.
                var venuesList = new List<Venue>();
                venuesList.Add(venue);

                lblTitle.Text = "Edit Table";
                create = false;
                BtnSaveChanges.Text = "Save changes";
                tbSeats.Text = "" + editedTable.NoOfSeats;
                tbName.Text = editedTable.Name;

                cbVenue.DataSource = venuesList;
            }
            catch (Exception) {
                MessageBox.Show("No connection to service");
                this.Visible = false;
            }

            // Resetting idFromTable to remove possibility to show other employees tables
            tablesGUI.idFromTable = -1;
        }

        public async Task Create() {
            TablesController vCtrl = new TablesController();
            EmployeesController eCtrl = new EmployeesController();
            tablesGUI = TablesGUI.Instance;

            lblTitle.Text = "Create Table";
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
            tbSeats.Text = "";
            tbName.Text = "";
        }


        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            TablesController tCtrl = new TablesController();
            DashboardGUI dGUI = DashboardGUI.Instance;

            if (TextBoxesHasValues()) {
                if (create) {
                    try {
                        Venue currVenue = (Venue)cbVenue.SelectedItem;
                        Debug.WriteLine("VenueId from tableGUI: " + currVenue.Id);
                        Table newTable = new Table { NoOfSeats = Int32.Parse(tbSeats.Text), Name = tbName.Text, VenueId = currVenue.Id };
                        await tCtrl.Create(newTable);
                        this.Visible = false;
                        dGUI.AddTableStats();
                    }
                    catch (Exception) {
                        MessageBox.Show("No connection to service");
                    }
                }
                else if (!create) {
                    MessageBox.Show("Method not implemented");
                    this.Visible = false;
                    /*int id = editedTable.Id;
                    Table updatedTable = await tCtrl.Get(editedTable.Id);
                    await tCtrl.Update(updatedTable.Id, updatedTable);
                    this.Visible = false;*/

                    }
                }
                else {
                    MessageBox.Show("Error...One or more fields are empty!"); ;
                }
            
        }

        public bool TextBoxesHasValues() {
            bool res = false;
            if (!string.IsNullOrWhiteSpace(tbSeats.Text) && !string.IsNullOrWhiteSpace(tbName.Text)) {
                res = true;
            }
            return res;
        }

    }
}
