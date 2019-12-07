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

        public TablePackageGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;
        }

        public async void Edit() {
            TablePackagesController tpCtrl = new TablePackagesController();
            VenuesController vCtrl = new VenuesController();
            tablePackagesGUI = TablePackagesGUI.Instance;
            editedTablePackage = await tpCtrl.Get(tablePackagesGUI.idFromTable);

            Venue venue = await vCtrl.Get(editedTablePackage.VenueId);
            lblTitle.Text = "Edit Table Package";

            create = false;
            BtnSaveChanges.Text = "Save changes";
            tbName.Text = editedTablePackage.Name;
            tbPrice.Text = "" + editedTablePackage.Price;
            var venuesList = new List<Venue>();
            venuesList.Add(venue);
            cbVenue.DataSource = venuesList;            
        }

        public async void CreateAsync() {
            TablesController vCtrl = new TablesController();
            EmployeesController eCtrl = new EmployeesController();
            tablePackagesGUI = TablePackagesGUI.Instance;
            lblTitle.Text = "Create Table Package";
            BtnSaveChanges.Text = "Create";
            var venuesList = new List<Venue>();
            List<Venue> venues = await eCtrl.GetVenues(1);
            foreach (Venue v in venues) {

                venuesList.Add(v);
            }
            cbVenue.DataSource = venuesList;
            create = true;
            tbName.Text = "";
            tbPrice.Text = "";
        }


        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            TablePackagesController tpCtrl = new TablePackagesController();
            if (TextBoxesHasValues()) {
                if (create) {
                    Venue currVenue = (Venue)cbVenue.SelectedItem;
                    Debug.WriteLine("VenueId from tablePackageGUI: " + currVenue.Id);
                    TablePackage newTablePackage = new TablePackage { Name = tbName.Text, Price = Int32.Parse(tbPrice.Text), VenueId = currVenue.Id };
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
                if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPrice.Text)) {
                    res = true;
                }
                return res;
            }
        
    }
}

    


