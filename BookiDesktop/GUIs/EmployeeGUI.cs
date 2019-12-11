using BookiDesktop.Controllers;
using BookiDesktop.Helpers;
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
    public partial class EmployeeGUI : Form {

        private bool create;
        private Employee editedEmployee;
        private EmployeesGUI employeesGUI;
        private SessionsController sCtrl;

        public EmployeeGUI() {
            InitializeComponent();
            sCtrl = SessionsController.Instance;
        }

        public async void Edit() {
            EmployeesController eCtrl = new EmployeesController();
            VenuesController vCtrl = new VenuesController();

            employeesGUI = EmployeesGUI.Instance;

            try {
                editedEmployee = await eCtrl.Get(employeesGUI.IdFromTable);

                create = false;
                lblTitle.Text = "Edit Employee";
                BtnSaveChanges.Text = "Save changes";
                tbName.Text = editedEmployee.Name;
                tbPhone.Text = editedEmployee.Phone;
                tbEmail.Text = editedEmployee.Email;
                tbPassword.Text = editedEmployee.Password;
                lblEmployeeNo.Show();
                tbEmployeeNo.Show();
                tbEmployeeNo.Enabled = false;
                tbEmployeeNo.Text = "" + editedEmployee.EmployeeNo;
                tbEmployeeTitle.Text = editedEmployee.Title;
                var venuesList = new List<Venue>();
                foreach (Venue v in editedEmployee.Venues) {
                    venuesList.Add(v);
                }
                // Finding venue from venueID on table and adding it to combobox.

                cbVenueID.DataSource = venuesList;
            }
            catch(Exception) {
                MessageBox.Show("No connection to service");
                this.Visible = false;   
            }
            // Resetting idFromTable to remove possibility to show other employees tables
            employeesGUI.IdFromTable = -1;
        }

        public async Task Create() {
            EmployeesController eCtrl = new EmployeesController();
            employeesGUI = EmployeesGUI.Instance;
            lblTitle.Text = "Create Employee";
            BtnSaveChanges.Text = "Create";
            var venuesList = new List<Venue>();
            try {
                List<Venue> venues = await eCtrl.GetVenues(sCtrl.EmployeeId);
                foreach (Venue v in venues) {
                    venuesList.Add(v);
                }
                cbVenueID.DataSource = venuesList;
            }
            catch(Exception) {
                MessageBox.Show("No connection to service");
            }
            create = true;
            tbName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            lblEmployeeNo.Hide();
            tbEmployeeNo.Hide();
            tbEmployeeTitle.Text = "";   
        }

        public bool TextBoxesHasValues() {
            bool res = false;
            if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPhone.Text) && !string.IsNullOrWhiteSpace(tbEmail.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text) && !string.IsNullOrWhiteSpace(tbEmployeeTitle.Text)) {
                res = true;
            }
            return res;
        }

        private async void BtnSaveChanges_Click(object sender, EventArgs e) {
            EmployeesController eCtrl = new EmployeesController();
            DashboardGUI dGUI = DashboardGUI.Instance;
            VenuesController vCtrl = new VenuesController();

            if (TextBoxesHasValues()) {
                if (create) {
                    //Venue currVenue = (Venue)cbVenueID.SelectedItem;
                    //Debug.WriteLine("VenueId from tableGUI: " + currVenue.Id);
                    string Password = HashingHelper.GenerateHash(tbPassword.Text);
                    string Salt = HashingHelper.RandomString(20);
                    try {
                        Employee newEmployee = new Employee { Name = tbName.Text, Phone = tbPhone.Text, Email = tbEmail.Text, Password = Password, Salt = Salt, EmployeeNo = await eCtrl.GetNewEmployeeNo(), Title = tbEmployeeTitle.Text};
                        Venue newVenue = (Venue)cbVenueID.SelectedItem;
                        Debug.WriteLine("newEmployee: " + newEmployee.Id + " " + newEmployee.Name);
                        Debug.WriteLine("newVenue: " + newVenue.Id + " " + newVenue.Name);
                    
                        await eCtrl.Create(newEmployee, newVenue);
                        this.Visible = false;
                        dGUI.AddEmployeeStats();
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
    }
}
