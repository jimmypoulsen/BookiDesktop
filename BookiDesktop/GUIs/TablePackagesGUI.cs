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
    public partial class TablePackagesGUI : Form {

        private static TablePackagesGUI instance = null;

        public TablePackagesGUI() {
            InitializeComponent();
            AddDataToTable();
        }

        public static TablePackagesGUI Instance {
            get {
                if (instance == null) {
                    instance = new TablePackagesGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            TablePackagesController tpCtrl = new TablePackagesController();
            tablePackagesGridView.UseWaitCursor = true;
            tablePackagesGridView.DataSource = await tpCtrl.Get();
            tablePackagesGridView.UseWaitCursor = false;
        }

    }
}
