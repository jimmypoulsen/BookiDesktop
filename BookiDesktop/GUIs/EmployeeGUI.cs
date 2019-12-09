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

        public EmployeeGUI() {
            InitializeComponent();
        }

        public async void Edit() {
            EmployeesController eCtrl = new EmployeesController();
            VenuesController vCtrl = new VenuesController();

            employeesGUI = EmployeesGUI.Instance;
            editedEmployee = await eCtrl.Get(employeesGUI.IdFromTable);
            //Venue venue = await vCtrl.Get(editedEmployee.VenueId);

            create = false;
            lblTitle.Text = "Edit Employee";
            BtnSaveChanges.Text = "Save changes";
            tbName.Text = editedEmployee.Name;
            tbPhone.Text = editedEmployee.Phone;
            tbEmail.Text = editedEmployee.Email;
            tbPassword.Text = editedEmployee.Password;
            lblEmployeeNo.Show();
            tbEmployeeNo.Show();
            tbEmployeeNo.Text = "" + editedEmployee.EmployeeNo;
            tbEmployeeTitle.Text = editedEmployee.Title;
            

        }

        public async Task Create() {
            EmployeesController eCtrl = new EmployeesController();
            employeesGUI = EmployeesGUI.Instance;
            DashboardGUI dashboardGUI = DashboardGUI.Instance;

            lblTitle.Text = "Create Employee";
            BtnSaveChanges.Text = "Create";
            var venuesList = new List<Venue>();
            List<Venue> venues = await eCtrl.GetVenues(dashboardGUI.EmployeeId);
            foreach (Venue v in venues) {
                venuesList.Add(v);
            }
            cbVenueID.DataSource = venuesList;
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
            Debug.WriteLine("Button pushed");
            if (TextBoxesHasValues()) {
                if (create) {
                    //Venue currVenue = (Venue)cbVenueID.SelectedItem;
                    //Debug.WriteLine("VenueId from tableGUI: " + currVenue.Id);
                    
                    string Password = HashingHelper.GenerateHash(tbPassword.Text);
                    Employee newEmployee = new Employee { Name = tbName.Text, Phone = tbPhone.Text, Email = tbEmail.Text, Password = Password, EmployeeNo = await eCtrl.GetNewEmployeeNo(), Title = tbEmployeeTitle.Text };
                    await eCtrl.Create(newEmployee);
                    this.Visible = false;

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
