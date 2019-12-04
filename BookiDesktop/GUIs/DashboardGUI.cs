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
    public partial class DashboardGUI : Form {

        private static DashboardGUI instance = null;

        public static DashboardGUI Instance {
            get {
                if (instance == null) {
                    instance = new DashboardGUI();
                }
                return instance;
            }      
        }

        public DashboardGUI() {
            InitializeComponent();
        }

        private void DashboardGUI_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
