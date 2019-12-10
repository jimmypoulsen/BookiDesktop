namespace BookiDesktop {
    partial class DashboardGUI {
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
            this.lblNoOfVenues = new System.Windows.Forms.Label();
            this.lblNoOfEmployees = new System.Windows.Forms.Label();
            this.lblNoOfTables = new System.Windows.Forms.Label();
            this.lblNoOfTablePackages = new System.Windows.Forms.Label();
            this.lblNoOfReservations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoOfVenues
            // 
            this.lblNoOfVenues.AutoSize = true;
            this.lblNoOfVenues.Location = new System.Drawing.Point(84, 106);
            this.lblNoOfVenues.Name = "lblNoOfVenues";
            this.lblNoOfVenues.Size = new System.Drawing.Size(130, 17);
            this.lblNoOfVenues.TabIndex = 0;
            this.lblNoOfVenues.Text = "Number of Venues:";
            // 
            // lblNoOfEmployees
            // 
            this.lblNoOfEmployees.AutoSize = true;
            this.lblNoOfEmployees.Location = new System.Drawing.Point(84, 137);
            this.lblNoOfEmployees.Name = "lblNoOfEmployees";
            this.lblNoOfEmployees.Size = new System.Drawing.Size(147, 17);
            this.lblNoOfEmployees.TabIndex = 1;
            this.lblNoOfEmployees.Text = "Number of Employees";
            // 
            // lblNoOfTables
            // 
            this.lblNoOfTables.AutoSize = true;
            this.lblNoOfTables.Location = new System.Drawing.Point(84, 171);
            this.lblNoOfTables.Name = "lblNoOfTables";
            this.lblNoOfTables.Size = new System.Drawing.Size(121, 17);
            this.lblNoOfTables.TabIndex = 2;
            this.lblNoOfTables.Text = "Number of Tables";
            // 
            // lblNoOfTablePackages
            // 
            this.lblNoOfTablePackages.AutoSize = true;
            this.lblNoOfTablePackages.Location = new System.Drawing.Point(84, 205);
            this.lblNoOfTablePackages.Name = "lblNoOfTablePackages";
            this.lblNoOfTablePackages.Size = new System.Drawing.Size(180, 17);
            this.lblNoOfTablePackages.TabIndex = 3;
            this.lblNoOfTablePackages.Text = "Number of Table Packages";
            // 
            // lblNoOfReservations
            // 
            this.lblNoOfReservations.AutoSize = true;
            this.lblNoOfReservations.Location = new System.Drawing.Point(84, 240);
            this.lblNoOfReservations.Name = "lblNoOfReservations";
            this.lblNoOfReservations.Size = new System.Drawing.Size(161, 17);
            this.lblNoOfReservations.TabIndex = 4;
            this.lblNoOfReservations.Text = "Number of Reservations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statistics";
            // 
            // DashboardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoOfReservations);
            this.Controls.Add(this.lblNoOfTablePackages);
            this.Controls.Add(this.lblNoOfTables);
            this.Controls.Add(this.lblNoOfEmployees);
            this.Controls.Add(this.lblNoOfVenues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardGUI";
            this.Text = "DashboardGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoOfVenues;
        private System.Windows.Forms.Label lblNoOfEmployees;
        private System.Windows.Forms.Label lblNoOfTables;
        private System.Windows.Forms.Label lblNoOfTablePackages;
        private System.Windows.Forms.Label lblNoOfReservations;
        private System.Windows.Forms.Label label1;
    }
}