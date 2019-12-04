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
            addDataToTable();
        }

        public async void addDataToTable() {
            VenuesController vCtrl = new VenuesController();
            venuesGridView.DataSource = await vCtrl.Get();
        }

    }
}
