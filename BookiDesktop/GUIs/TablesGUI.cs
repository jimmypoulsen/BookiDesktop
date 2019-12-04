using BookiDesktop.Controllers;
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
    public partial class TablesGUI : Form {
        public TablesGUI() {
            InitializeComponent();
            addDataToTable();
        }

        private async void addDataToTable() {
            TablesController tCtrl = new TablesController();
            tablesGridView.DataSource = await tCtrl.Get();
        }
    }

    }
