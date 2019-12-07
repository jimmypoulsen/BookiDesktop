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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.lblDataFetched = new System.Windows.Forms.Label();
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
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(451, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(156, 39);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnFindVenues_Click);
            // 
            // lblDataFetched
            // 
            this.lblDataFetched.AutoSize = true;
            this.lblDataFetched.Location = new System.Drawing.Point(289, 72);
            this.lblDataFetched.Name = "lblDataFetched";
            this.lblDataFetched.Size = new System.Drawing.Size(0, 17);
            this.lblDataFetched.TabIndex = 5;
            // 
            // DashboardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDataFetched);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.lblEmployeeNo);
            this.Controls.Add(this.tbEmployeeNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardGUI";
            this.Text = "DashboardGUI";
            this.Load += new System.EventHandler(this.DashboardGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeNo;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label lblDataFetched;
    }
}