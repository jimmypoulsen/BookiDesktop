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
        public TableGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;

        }

        public async void Edit() {
            TablesController tCtrl = new TablesController();
            VenuesController vCtrl = new VenuesController();
            tablesGUI = TablesGUI.Instance;
            editedTable = await tCtrl.Get(tablesGUI.idFromTable);

            Venue venue = await vCtrl.Get(editedTable.VenueId);
            lblTitle.Text = "Edit Table";
            create = false;
            BtnSaveChanges.Text = "Save changes";
            tbSeats.Text = "" + editedTable.NoOfSeats;
            tbName.Text = editedTable.Name;
            // Creating list because combobox demands it.
            // Finding venue from venueID on table and adding it to combobox.
            var venuesList = new List<Venue>();
            venuesList.Add(venue);
            cbVenueID.DataSource = venuesList;
        }

        public async Task Create() {
            TablesController vCtrl = new TablesController();
            EmployeesController eCtrl = new EmployeesController();
            tablesGUI = TablesGUI.Instance;
            lblTitle.Text = "Create Table";
            BtnSaveChanges.Text = "Create";
            var venuesList = new List<Venue>();
            List<Venue> venues = await eCtrl.GetVenues(1);
            foreach (Venue v in venues) {
                
                venuesList.Add(v);
            }
            cbVenueID.DataSource = venuesList;
            create = true;
            tbSeats.Text = "";
            tbName.Text = "";
        }


        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            TablesController tCtrl = new TablesController();
            if (TextBoxesHasValues()) {
                if (create) {
                    Venue currVenue = (Venue)cbVenueID.SelectedItem;
                    Debug.WriteLine("VenueId from tableGUI: " + currVenue.Id);
                    Table newTable = new Table { NoOfSeats = Int32.Parse(tbSeats.Text), Name = tbName.Text, VenueId = currVenue.Id };
                    await tCtrl.Create(newTable);
                    this.Visible = false;

                }/* else if (!create) {
                    int id = editedTable.Id;
                    Table updatedTable = await tCtrl.Get(editedTable.Id);
                    await tCtrl.Update(updatedTable.Id, updatedTable);
                    this.Visible = false;
                }*/                
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
