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

        private VenuesGUI venuesGUI;
        public VenueGUI() {
            InitializeComponent();
            //Edit();
        }

        public async void Edit() {
            VenuesController vCtrl = new VenuesController();
            venuesGUI = VenuesGUI.Instance;
            Venue venue = await vCtrl.Get(venuesGUI.idFromTable);
            lblTitle.Text = "Edit Venue";
            BtnSaveChanges.Text = "Save changes";
            tbVenueID.ReadOnly = true;
            tbVenueID.Text = "" + venuesGUI.idFromTable;
            tbName.Text = venue.Name;
            tbAddress.Text = venue.Address;
            tbZip.Text = "" + venue.Zip;
            tbCity.Text = venue.City;
        }

        public void Create() {
            //bool res = false;
            VenuesController vCtrl = new VenuesController();
            venuesGUI = VenuesGUI.Instance;
            lblTitle.Text = "Create Venue";
            BtnSaveChanges.Text = "Create";

            tbVenueID.ReadOnly = true;
            tbVenueID.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbZip.Text = "";
            tbCity.Text = "";
            //res = true;
           // return res;
        }

    }
}
    

