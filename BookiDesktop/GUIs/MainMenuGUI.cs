using BookiDesktop.GUIs;
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

        private string nameOfFormOpen;
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
            nameOfFormOpen = form.Name;
        }

        private void Edit_Click(object sender, EventArgs e) {
            if (nameOfFormOpen.Equals("VenuesGUI")) {
                lblNameOfFormOpen.Text = nameOfFormOpen;
                EditVenuesGUI evGUI = new EditVenuesGUI();
                evGUI.Show();
            }
            else if (nameOfFormOpen.Equals("TablesGUI")) {
                lblNameOfFormOpen.Text = nameOfFormOpen;
                EditTablesGUI etGUI = new EditTablesGUI();
                etGUI.Show();
            }
            else if (nameOfFormOpen.Equals("TablePackagesGUI")) {
                lblNameOfFormOpen.Text = nameOfFormOpen;
                EditTablePackagesGUI etpGUI = new EditTablePackagesGUI();
                etpGUI.Show();
            }
        }
    }
}
