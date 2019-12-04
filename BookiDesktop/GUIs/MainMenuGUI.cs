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
            nav(dashboardGUI, content, "");
            recolorButtons();
            BtnDashboard.BackColor = Color.DarkGray;
        }


        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void BtnDashboard_Click(object sender, EventArgs e) {
            DashboardGUI dashboardGUI = new DashboardGUI();
            nav(dashboardGUI, content, "");
            recolorButtons();
            BtnDashboard.BackColor = Color.DarkGray;
        }

        private void BtnVenues_Click(object sender, EventArgs e) {
            VenuesGUI venueGUI = new VenuesGUI();
            nav(venueGUI, content, "Venue");
            recolorButtons();
            BtnVenues.BackColor = Color.DarkGray;
        }

        private void BtnTables_Click(object sender, EventArgs e) {
            TablesGUI tableGUI = new TablesGUI();
            nav(tableGUI, content, "Table");
            recolorButtons();
            BtnTables.BackColor = Color.DarkGray;
        }

        private void BtnTablePackages_Click(object sender, EventArgs e) {
            TablePackagesGUI tablePackagesGUI = new TablePackagesGUI();
            nav(tablePackagesGUI, content, "Table package");
            recolorButtons();
            BtnTablePackages.BackColor = Color.DarkGray;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        public void hideButtons() {
            BtnCreateNew.Hide();
            BtnEdit.Hide();
            BtnDelete.Hide();
        }

        public void showButtons() {
            BtnCreateNew.Show();
            BtnEdit.Show();
            BtnDelete.Show();
        }

        public void changeButtons(String title) {

            string newTitle = null;

            if (title.Contains("s")) {
                string oldChar = "s";
                string newChar = "";
                newTitle = title.Replace(oldChar, newChar);
            }

            BtnCreateNew.Text = "Create new " + newTitle;
            BtnEdit.Text = "Edit " + newTitle;
            BtnDelete.Text = "Delete " + newTitle;
        }

        public void recolorButtons() {
            BtnDashboard.BackColor = Color.White;
            BtnVenues.BackColor = Color.White;
            BtnTables.BackColor = Color.White;
            BtnTablePackages.BackColor = Color.White;
        }

        public void nav(Form form, Panel panel, String title) {
            // changing view for content panel
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();

            // getting name of form that is being viewed, and assigning header title and button text from from that value
            nameOfFormOpen = form.Name;
            string currTitle = "";
            string newTitle = "";
            // removing value "GUI" from name to be more user friendly
            if (nameOfFormOpen.Contains("GUI")) {
                currTitle = nameOfFormOpen.Replace("GUI", "");
                newTitle = InsertSpaceBeforeUpperCase(currTitle);
            }
            lblNameOfFormOpen.Text =  newTitle;
            
            changeButtons(newTitle.ToLower());
            if (nameOfFormOpen.Equals("DashboardGUI")) {
                hideButtons();
            }
            else {
                showButtons();
            }

        }

        public static string InsertSpaceBeforeUpperCase(string str) {
            var sb = new StringBuilder();
            char previousChar = char.MinValue; // Unicode '\0'

            foreach (char c in str) {
                if (char.IsUpper(c)) {
                    // If not the first character and previous character is not a space, insert a space before uppercase
                    if (sb.Length != 0 && previousChar != ' ') {
                        sb.Append(' ');
                    }
                }
                sb.Append(c);
                previousChar = c;
            }
            return sb.ToString();
        }

        private void Edit_Click(object sender, EventArgs e) {
            if (nameOfFormOpen.Equals("VenuesGUI")) {
                EditVenuesGUI evGUI = new EditVenuesGUI();
                evGUI.Show();
                /*MyObject obj = (MyObject)dataGridView.CurrentRow.DataBoundItem;
                obj.MyProperty = newValue;*/
            }
            else if (nameOfFormOpen.Equals("TablesGUI")) {
                EditTablesGUI etGUI = new EditTablesGUI();
                etGUI.Show();

            }
            else if (nameOfFormOpen.Equals("TablePackagesGUI")) {
                EditTablePackagesGUI etpGUI = new EditTablePackagesGUI();
                etpGUI.Show();            }
        }

        private void BtnCreateNew_Click(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
