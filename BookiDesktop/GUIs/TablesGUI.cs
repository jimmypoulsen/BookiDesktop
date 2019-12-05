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

        private static TablesGUI instance = null;

        public TablesGUI() {
            InitializeComponent();
            AddDataToTable();
        }

        public static TablesGUI Instance {
            get {
                if (instance == null) {
                    instance = new TablesGUI();
                }
                return instance;
            }
        }

        public async void AddDataToTable() {
            TablesController tCtrl = new TablesController();
            tablesGridView.UseWaitCursor = true;
            tablesGridView.DataSource = await tCtrl.Get();
            tablesGridView.UseWaitCursor = false;
        }
    }

    }
