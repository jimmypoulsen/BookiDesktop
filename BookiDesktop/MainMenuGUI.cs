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
    public partial class MainMenuGUI : Form {
        public MainMenuGUI() {
            InitializeComponent();
            DashboardGUI dashboardGUI = new DashboardGUI();
            nav(dashboardGUI, content);
        }


        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            DashboardGUI dashboardGUI = new DashboardGUI();
            nav(dashboardGUI, content);
        }

        private void button2_Click(object sender, EventArgs e) {
            VenuesGUI venueGUI = new VenuesGUI();
            nav(venueGUI, content);
        }

        private void button3_Click(object sender, EventArgs e) {
            TablesGUI tableGUI = new TablesGUI();
            nav(tableGUI, content);
        }

        private void button4_Click(object sender, EventArgs e) {
            TablePackagesGUI tablePackagesGUI = new TablePackagesGUI();
            nav(tablePackagesGUI, content);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        public void nav(Form form, Panel panel) {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

       
    }
}
