namespace BookiDesktop {
    partial class MainMenuGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sidePanelNav = new System.Windows.Forms.Panel();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.BtnTablePackages = new System.Windows.Forms.Button();
            this.BtnTables = new System.Windows.Forms.Button();
            this.BtnVenues = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.HeaderNavBar = new System.Windows.Forms.Panel();
            this.lblCurrentlyLoggedInValues = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lblCurrentlyLoggedIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.HeaderForContent = new System.Windows.Forms.Panel();
            this.lblNameOfFormOpen = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCreateNew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnReservations = new System.Windows.Forms.Button();
            this.sidePanelNav.SuspendLayout();
            this.HeaderNavBar.SuspendLayout();
            this.HeaderForContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanelNav
            // 
            this.sidePanelNav.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanelNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanelNav.Controls.Add(this.BtnReservations);
            this.sidePanelNav.Controls.Add(this.BtnEmployees);
            this.sidePanelNav.Controls.Add(this.BtnTablePackages);
            this.sidePanelNav.Controls.Add(this.BtnTables);
            this.sidePanelNav.Controls.Add(this.BtnVenues);
            this.sidePanelNav.Controls.Add(this.BtnDashboard);
            this.sidePanelNav.Location = new System.Drawing.Point(0, 68);
            this.sidePanelNav.Name = "sidePanelNav";
            this.sidePanelNav.Size = new System.Drawing.Size(141, 562);
            this.sidePanelNav.TabIndex = 0;
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.Location = new System.Drawing.Point(3, 156);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Size = new System.Drawing.Size(132, 69);
            this.BtnEmployees.TabIndex = 4;
            this.BtnEmployees.Text = "Employees";
            this.BtnEmployees.UseVisualStyleBackColor = true;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // BtnTablePackages
            // 
            this.BtnTablePackages.Location = new System.Drawing.Point(3, 306);
            this.BtnTablePackages.Name = "BtnTablePackages";
            this.BtnTablePackages.Size = new System.Drawing.Size(133, 69);
            this.BtnTablePackages.TabIndex = 3;
            this.BtnTablePackages.Text = "Table Packages";
            this.BtnTablePackages.UseVisualStyleBackColor = true;
            this.BtnTablePackages.Click += new System.EventHandler(this.BtnTablePackages_Click);
            // 
            // BtnTables
            // 
            this.BtnTables.Location = new System.Drawing.Point(3, 231);
            this.BtnTables.Name = "BtnTables";
            this.BtnTables.Size = new System.Drawing.Size(132, 69);
            this.BtnTables.TabIndex = 2;
            this.BtnTables.Text = "Tables";
            this.BtnTables.UseVisualStyleBackColor = true;
            this.BtnTables.Click += new System.EventHandler(this.BtnTables_Click);
            // 
            // BtnVenues
            // 
            this.BtnVenues.Location = new System.Drawing.Point(4, 82);
            this.BtnVenues.Name = "BtnVenues";
            this.BtnVenues.Size = new System.Drawing.Size(132, 69);
            this.BtnVenues.TabIndex = 1;
            this.BtnVenues.Text = "Venues";
            this.BtnVenues.UseVisualStyleBackColor = true;
            this.BtnVenues.Click += new System.EventHandler(this.BtnVenues_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Location = new System.Drawing.Point(3, 7);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(133, 69);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(1210, -1);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(137, 69);
            this.BtnLogOut.TabIndex = 4;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // HeaderNavBar
            // 
            this.HeaderNavBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderNavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderNavBar.Controls.Add(this.lblCurrentlyLoggedInValues);
            this.HeaderNavBar.Controls.Add(this.BtnLogOut);
            this.HeaderNavBar.Controls.Add(this.button6);
            this.HeaderNavBar.Controls.Add(this.lblCurrentlyLoggedIn);
            this.HeaderNavBar.Controls.Add(this.label2);
            this.HeaderNavBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderNavBar.Name = "HeaderNavBar";
            this.HeaderNavBar.Size = new System.Drawing.Size(1348, 69);
            this.HeaderNavBar.TabIndex = 5;
            // 
            // lblCurrentlyLoggedInValues
            // 
            this.lblCurrentlyLoggedInValues.AutoSize = true;
            this.lblCurrentlyLoggedInValues.Location = new System.Drawing.Point(553, 31);
            this.lblCurrentlyLoggedInValues.Name = "lblCurrentlyLoggedInValues";
            this.lblCurrentlyLoggedInValues.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentlyLoggedInValues.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1067, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 69);
            this.button6.TabIndex = 7;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblCurrentlyLoggedIn
            // 
            this.lblCurrentlyLoggedIn.AutoSize = true;
            this.lblCurrentlyLoggedIn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentlyLoggedIn.ForeColor = System.Drawing.Color.White;
            this.lblCurrentlyLoggedIn.Location = new System.Drawing.Point(505, 12);
            this.lblCurrentlyLoggedIn.Name = "lblCurrentlyLoggedIn";
            this.lblCurrentlyLoggedIn.Size = new System.Drawing.Size(147, 19);
            this.lblCurrentlyLoggedIn.TabIndex = 6;
            this.lblCurrentlyLoggedIn.Text = "Currently logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Booki - Administration";
            // 
            // content
            // 
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Location = new System.Drawing.Point(143, 114);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1205, 516);
            this.content.TabIndex = 6;
            // 
            // HeaderForContent
            // 
            this.HeaderForContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderForContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderForContent.Controls.Add(this.lblNameOfFormOpen);
            this.HeaderForContent.Controls.Add(this.BtnDelete);
            this.HeaderForContent.Controls.Add(this.BtnEdit);
            this.HeaderForContent.Controls.Add(this.BtnCreateNew);
            this.HeaderForContent.Location = new System.Drawing.Point(143, 68);
            this.HeaderForContent.Name = "HeaderForContent";
            this.HeaderForContent.Size = new System.Drawing.Size(1205, 45);
            this.HeaderForContent.TabIndex = 7;
            // 
            // lblNameOfFormOpen
            // 
            this.lblNameOfFormOpen.AutoSize = true;
            this.lblNameOfFormOpen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfFormOpen.Location = new System.Drawing.Point(3, 3);
            this.lblNameOfFormOpen.Name = "lblNameOfFormOpen";
            this.lblNameOfFormOpen.Size = new System.Drawing.Size(245, 32);
            this.lblNameOfFormOpen.TabIndex = 8;
            this.lblNameOfFormOpen.Text = "lblNameOfFormOpen";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(1006, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(194, 36);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(806, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(194, 36);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // BtnCreateNew
            // 
            this.BtnCreateNew.Location = new System.Drawing.Point(606, 4);
            this.BtnCreateNew.Name = "BtnCreateNew";
            this.BtnCreateNew.Size = new System.Drawing.Size(194, 36);
            this.BtnCreateNew.TabIndex = 0;
            this.BtnCreateNew.Text = "Create new";
            this.BtnCreateNew.UseVisualStyleBackColor = true;
            this.BtnCreateNew.Click += new System.EventHandler(this.BtnCreateNew_ClickAsync);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(0, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 36);
            this.panel3.TabIndex = 8;
            // 
            // BtnReservations
            // 
            this.BtnReservations.Location = new System.Drawing.Point(3, 381);
            this.BtnReservations.Name = "BtnReservations";
            this.BtnReservations.Size = new System.Drawing.Size(133, 69);
            this.BtnReservations.TabIndex = 5;
            this.BtnReservations.Text = "Reservations";
            this.BtnReservations.UseVisualStyleBackColor = true;
            this.BtnReservations.Click += new System.EventHandler(this.BtnReservations_Click);
            // 
            // MainMenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 658);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HeaderForContent);
            this.Controls.Add(this.content);
            this.Controls.Add(this.HeaderNavBar);
            this.Controls.Add(this.sidePanelNav);
            this.Name = "MainMenuGUI";
            this.Text = "Form1";
            this.sidePanelNav.ResumeLayout(false);
            this.HeaderNavBar.ResumeLayout(false);
            this.HeaderNavBar.PerformLayout();
            this.HeaderForContent.ResumeLayout(false);
            this.HeaderForContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanelNav;
        private System.Windows.Forms.Button BtnTables;
        private System.Windows.Forms.Button BtnVenues;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnTablePackages;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Panel HeaderNavBar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel HeaderForContent;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnCreateNew;
        private System.Windows.Forms.Label lblNameOfFormOpen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnEmployees;
        public System.Windows.Forms.Label lblCurrentlyLoggedIn;
        private System.Windows.Forms.Label lblCurrentlyLoggedInValues;
        private System.Windows.Forms.Button BtnReservations;
    }
}

