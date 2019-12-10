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
using BookiDesktop.Properties;
using BookiDesktop.Helpers;

namespace BookiDesktop.GUIs {
    public partial class LoginGUI : Form {
        public LoginGUI() {
            InitializeComponent();
            this.AcceptButton = BtnLogin;
        }

        private async void BtnLogin_ClickAsync(object sender, EventArgs e) {
           SessionsController sCtrl = SessionsController.Instance;

            string email = tbEmail.Text;
            string password = tbPassword.Text;
            Employee res = new Employee();
            res.Email = email;
            res.Password = password;
            try {
                if (!tbEmail.Text.Equals("") && !tbPassword.Text.Equals("") && await sCtrl.Login(res)) {
                    MessageBox.Show("Succesfully logged in");
                    MainMenuGUI mmGUI = MainMenuGUI.Instance;
                    this.Visible = false;
                    mmGUI.SetStartupView();
                    mmGUI.Show();
                }
                else {
                    MessageBox.Show("Email or password invalid");
                    tbEmail.Text = "";
                    tbPassword.Text = "";
                }
            }
            catch(Exception) {
                MessageBox.Show("No connection to service");
            }
            
        }
    }
}
