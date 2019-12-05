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
    public partial class VenueGUI : Form {

        private bool create;
        private Venue editedVenue;
        private VenuesGUI venuesGUI;
        public VenueGUI() {
            InitializeComponent();
            this.ActiveControl = BtnSaveChanges;
        }

        public async void Edit() {
            VenuesController vCtrl = new VenuesController();
            venuesGUI = VenuesGUI.Instance;
            editedVenue = await vCtrl.Get(venuesGUI.idFromTable);
            lblBool.Text = "editedVenueID: " + editedVenue.Id;
            create = false;
            lblTitle.Text = "Edit Venue";
            BtnSaveChanges.Text = "Save changes";
            tbVenueID.ReadOnly = true;
            tbVenueID.Text = "" + venuesGUI.idFromTable;
            tbName.Text = editedVenue.Name;
            tbAddress.Text = editedVenue.Address;
            tbZip.Text = "" + editedVenue.Zip;
            tbCity.Text = editedVenue.City;
        }

        public void Create() {
            //bool res = false;
            VenuesController vCtrl = new VenuesController();
            lblBool.Text = "Creating venue";
            venuesGUI = VenuesGUI.Instance;
            lblTitle.Text = "Create Venue";
            BtnSaveChanges.Text = "Create";

            create = true;
            tbVenueID.ReadOnly = true;
            tbVenueID.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbZip.Text = "";
            tbCity.Text = "";
            //res = true;
            // return res;
        }

        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            VenuesController vCtrl = new VenuesController();
            
            if (create && TextBoxesHasValues()) {
                try {
                    Venue newVenue = new Venue { Name = tbName.Text, Address = tbAddress.Text, Zip = Int32.Parse(tbZip.Text), City = tbCity.Text };
                    await vCtrl.Create(newVenue);
                    this.Visible = false;
                }
                catch {
                    MessageBox.Show("Error...One or more fields are empty!");
                }
                
            }
            else if (!create && TextBoxesHasValues()) {
                try {
                    int id = editedVenue.Id;
                    Venue changedVenue = new Venue {Id = Int32.Parse(tbVenueID.Text), Name = tbName.Text, Address = tbAddress.Text, Zip = Int32.Parse(tbZip.Text), City = tbCity.Text };
                    await vCtrl.Update(changedVenue.Id, changedVenue);
                    this.Visible = false;
                }
                catch {
                    MessageBox.Show("Error...One or more fields are empty!");
                }
            }

        }
        // Implement this in tables and tablePackages
        public bool TextBoxesHasValues() {
            bool res = false;           
            if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbAddress.Text) && !string.IsNullOrWhiteSpace(tbZip.Text) && !string.IsNullOrWhiteSpace(tbCity.Text)) {
                res = true;
            } 
            return res;
        }
    }
}

    

