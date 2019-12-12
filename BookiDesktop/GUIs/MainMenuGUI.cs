using BookiDesktop.Controllers;
using BookiDesktop.GUIs;
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
using System.Web.Http;
using System.Windows.Forms;

namespace BookiDesktop {
    public partial class MainMenuGUI : Form {

        private string nameOfFormOpen;
        private static MainMenuGUI instance = null;
        private string newTitle;

        public MainMenuGUI() {
            InitializeComponent();
            DashboardGUI dashboardGUI = DashboardGUI.Instance;
            Nav(dashboardGUI, content);
            RecolorButtons();
            BtnDashboard.BackColor = Color.DarkGray;
        }

        public static MainMenuGUI Instance {
            get {
                if (instance == null) {
                    instance = new MainMenuGUI();
                }
                return instance;
            }
        }

        public void SetStartupView() {
            DashboardGUI dashboardGUI = DashboardGUI.Instance;
            Nav(dashboardGUI, content);
            RecolorButtons();
            BtnDashboard.BackColor = Color.DarkGray;
            dashboardGUI.AddAllStats();
        }


        private void BtnDashboard_Click(object sender, EventArgs e) {
            DashboardGUI dashboardGUI = DashboardGUI.Instance;
            Nav(dashboardGUI, content);
            RecolorButtons();
            BtnDashboard.BackColor = Color.DarkGray;
        }

        private void BtnVenues_Click(object sender, EventArgs e) {
            //VenuesGUI venueGUI = new VenuesGUI();
            VenuesGUI venuesGUI = VenuesGUI.Instance;
            Nav(venuesGUI, content);
            RecolorButtons();
            BtnVenues.BackColor = Color.DarkGray;
            venuesGUI.AddDataToTable();
        }

        private void BtnEmployees_Click(object sender, EventArgs e) {
            EmployeesGUI employeesGUI = EmployeesGUI.Instance;
            Nav(employeesGUI, content);
            RecolorButtons();
            BtnEmployees.BackColor = Color.DarkGray;
            employeesGUI.AddDataToTable();
        }

        private void BtnTables_Click(object sender, EventArgs e) {
            TablesGUI tablesGUI = TablesGUI.Instance;
            Nav(tablesGUI, content);
            RecolorButtons();
            BtnTables.BackColor = Color.DarkGray;
            tablesGUI.AddDataToTable();
        }

        private void BtnTablePackages_Click(object sender, EventArgs e) {
            TablePackagesGUI tablePackagesGUI = TablePackagesGUI.Instance;
            Nav(tablePackagesGUI, content);
            RecolorButtons();
            BtnTablePackages.BackColor = Color.DarkGray;
            tablePackagesGUI.AddDataToTable();
        }

        private void BtnReservations_Click(object sender, EventArgs e) {
            ReservationsGUI reservationsGUI = ReservationsGUI.Instance;
            Nav(reservationsGUI, content);
            RecolorButtons();
            BtnReservations.BackColor = Color.DarkGray;
            reservationsGUI.AddDataToTable();
        }


        public void HideButtons() {
            BtnCreateNew.Hide();
            BtnEdit.Hide();
            BtnDelete.Hide();
        }

        public void ShowButtons() {
            BtnCreateNew.Show();
            BtnEdit.Show();
            BtnDelete.Show();
        }

        public void ChangeButtons(String title) {

            newTitle = null;
            // Checking if title is plural and ends with "s"
            string suffix = "s";
            if (title.EndsWith(suffix)) {
                //Removes the "s" at the end and creates a new title
                newTitle = title.Remove(title.Length - suffix.Length);
            }
            else {
                newTitle = title;
            }
            BtnCreateNew.Text = "Create new " + newTitle;
            BtnEdit.Text = "Edit " + newTitle;
            BtnDelete.Text = "Delete " + newTitle;
        }

        public void RecolorButtons() {
            BtnDashboard.BackColor = Color.White;
            BtnVenues.BackColor = Color.White;
            BtnTables.BackColor = Color.White;
            BtnTablePackages.BackColor = Color.White;
            BtnEmployees.BackColor = Color.White;
            BtnReservations.BackColor = Color.White;
        }

        public void Nav(Form form, Panel panel) {
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
            lblNameOfFormOpen.Text = newTitle;

            ChangeButtons(newTitle.ToLower());
            if (nameOfFormOpen.Equals("DashboardGUI") || nameOfFormOpen.Equals("VenuesGUI")) {

                //if (nameOfFormOpen.Equals("DashboardGUI")) {
                HideButtons();
            }
            else if (nameOfFormOpen.Equals("ReservationsGUI")) {
                BtnCreateNew.Hide();
                BtnEdit.Hide();
                BtnDelete.Show();
            }
            else {
                ShowButtons();
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
            if (nameOfFormOpen.Equals("VenuesGUI") && VenuesGUI.Instance.idFromTable != -1) {
                VenueGUI venueGUI = new VenueGUI();
                venueGUI.Edit();
                venueGUI.Show();

            }

            else if (nameOfFormOpen.Equals("TablesGUI") && TablesGUI.Instance.idFromTable != -1) {
                TableGUI tableGUI = new TableGUI();
                tableGUI.Edit();
                tableGUI.Show();

            }

            else if (nameOfFormOpen.Equals("TablePackagesGUI") && TablePackagesGUI.Instance.idFromTable != -1) {
                TablePackageGUI tablePackageGUI = new TablePackageGUI();
                tablePackageGUI.Edit();
                tablePackageGUI.Show();
            }

            else if (nameOfFormOpen.Equals("EmployeesGUI") && EmployeesGUI.Instance.IdFromTable != -1) {
                EmployeeGUI employeeGUI = new EmployeeGUI();
                employeeGUI.Edit();
                employeeGUI.Show();
            }

            else {
                MessageBox.Show("Please select a " + newTitle + " from the list");
            }
        }
                                                                                
        private async void BtnCreateNew_ClickAsync(object sender, EventArgs e) {
            if (nameOfFormOpen.Equals("VenuesGUI")) {
                VenueGUI venueGUI = new VenueGUI();
                venueGUI.Create();
                venueGUI.Show();
            }
            else if (nameOfFormOpen.Equals("TablesGUI")) {
                TableGUI tableGUI = new TableGUI();
                await tableGUI.Create();
                tableGUI.Show();
            }

            else if (nameOfFormOpen.Equals("TablePackagesGUI")) {
                TablePackageGUI tablePackageGUI = new TablePackageGUI();
                tablePackageGUI.Create();
                tablePackageGUI.Show();
            }

            else if (nameOfFormOpen.Equals("EmployeesGUI")) {
                EmployeeGUI employeeGUI = new EmployeeGUI();
                await employeeGUI.Create();
                employeeGUI.Show();
            }

        }

        private async void BtnDelete_Click(object sender, EventArgs e) {
            if (nameOfFormOpen.Equals("VenuesGUI") && VenuesGUI.Instance.idFromTable != -1) {
                try {
                    VenuesController vCtrl = new VenuesController();
                    VenuesGUI.Instance.UseWaitCursor = true;
                    await vCtrl.Delete(VenuesGUI.Instance.idFromTable);
                    VenuesGUI.Instance.UseWaitCursor = false;
                }
                catch (Exception) {
                    MessageBox.Show("Error...occured");
                    VenuesGUI.Instance.UseWaitCursor = false;
                }
            }
            else if (nameOfFormOpen.Equals("TablesGUI") && TablesGUI.Instance.idFromTable != -1) {
                try {
                    TablesController tCtrl = new TablesController();
                    TablesGUI.Instance.UseWaitCursor = true;
                    await tCtrl.Delete(TablesGUI.Instance.idFromTable);
                    TablesGUI.Instance.UseWaitCursor = false;
                }
                catch (Exception) {
                    MessageBox.Show("Error...occured");
                    TablesGUI.Instance.UseWaitCursor = false;
                }
            }
            else if (nameOfFormOpen.Equals("TablePackagesGUI") && TablePackagesGUI.Instance.idFromTable != -1) {
                try {
                    TablePackagesController tpCtrl = new TablePackagesController();
                    TablePackagesGUI.Instance.UseWaitCursor = true;
                    await tpCtrl.Delete(TablePackagesGUI.Instance.idFromTable);
                    TablePackagesGUI.Instance.UseWaitCursor = false;
                }
                catch (Exception) {
                    MessageBox.Show("Error...occured");
                    TablePackagesGUI.Instance.UseWaitCursor = false;
                }
            }

            else if (nameOfFormOpen.Equals("EmployeesGUI") && EmployeesGUI.Instance.IdFromTable != -1) {
                try {
                    EmployeesController eCtrl = new EmployeesController();
                    EmployeesGUI.Instance.UseWaitCursor = true;
                    await eCtrl.Delete(EmployeesGUI.Instance.IdFromTable);
                    EmployeesGUI.Instance.UseWaitCursor = false;
                }
                catch (Exception) {
                    MessageBox.Show("Error...occured");
                    EmployeesGUI.Instance.UseWaitCursor = false;
                }
            }

            else if (nameOfFormOpen.Equals("ReservationsGUI") && ReservationsGUI.Instance.IdFromTable != -1) {
                try {
                    ReservationsController rCtrl = new ReservationsController();
                    ReservationsGUI.Instance.UseWaitCursor = true;
                    await rCtrl.Delete(ReservationsGUI.Instance.IdFromTable);
                    ReservationsGUI.Instance.UseWaitCursor = false;
                }
                catch (Exception) {
                    MessageBox.Show("Error...occured");
                    EmployeesGUI.Instance.UseWaitCursor = false;
                }
            }

            else {
                MessageBox.Show("Please select a " + newTitle + " from the list");
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e) {
            SessionsController sCtrl = new SessionsController();
            sCtrl.LogOut();
        }

        public void setCurrentlyLoggedIn(Employee employee) {
            lblCurrentlyLoggedInValues.Text = employee.Name + " - " + employee.Title;
            BtnLogOut.Text = "Log out" + "\n" + "(" + employee.Name + ")";
        }

    } 
    
}
