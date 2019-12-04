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

namespace BookiDesktop {
    public partial class VenuesGUI : Form {
        public VenuesGUI() {
            InitializeComponent();
        }

        private void Venues_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private async void button1_Click(object sender, EventArgs e) {
            VenuesController vCtrl = new VenuesController();
            await vCtrl.GetRequest();

            foreach (Venue venue in vCtrl.VenueInfo) {
                textBox1.Text = venue.ToString();
            }

           
        }

        private void VenuesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
