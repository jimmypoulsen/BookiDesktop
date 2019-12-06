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
            this.tbEmployeeNo = new System.Windows.Forms.TextBox();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.BtnFindVenues = new System.Windows.Forms.Button();
            this.venuesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.venuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeNo
            // 
            this.tbEmployeeNo.Location = new System.Drawing.Point(289, 29);
            this.tbEmployeeNo.Name = "tbEmployeeNo";
            this.tbEmployeeNo.Size = new System.Drawing.Size(156, 22);
            this.tbEmployeeNo.TabIndex = 2;
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Location = new System.Drawing.Point(286, 9);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(159, 17);
            this.lblEmployeeNo.TabIndex = 3;
            this.lblEmployeeNo.Text = "Insert employeeNo here";
            // 
            // BtnFindVenues
            // 
            this.BtnFindVenues.Location = new System.Drawing.Point(451, 12);
            this.BtnFindVenues.Name = "BtnFindVenues";
            this.BtnFindVenues.Size = new System.Drawing.Size(156, 39);
            this.BtnFindVenues.TabIndex = 4;
            this.BtnFindVenues.Text = "Find venues";
            this.BtnFindVenues.UseVisualStyleBackColor = true;
            this.BtnFindVenues.Click += new System.EventHandler(this.BtnFindVenues_Click);
            // 
            // venuesGridView
            // 
            this.venuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venuesGridView.Location = new System.Drawing.Point(12, 57);
            this.venuesGridView.Name = "venuesGridView";
            this.venuesGridView.RowHeadersWidth = 51;
            this.venuesGridView.Size = new System.Drawing.Size(779, 385);
            this.venuesGridView.TabIndex = 6;
            // 
            // DashboardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.venuesGridView);
            this.Controls.Add(this.BtnFindVenues);
            this.Controls.Add(this.lblEmployeeNo);
            this.Controls.Add(this.tbEmployeeNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardGUI";
            this.Text = "DashboardGUI";
            this.Load += new System.EventHandler(this.DashboardGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venuesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeNo;
        private System.Windows.Forms.Button BtnFindVenues;
        private System.Windows.Forms.DataGridView venuesGridView;
    }
}