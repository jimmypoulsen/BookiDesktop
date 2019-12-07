namespace BookiDesktop.GUIs {
    partial class EmployeesGUI {
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
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesGridView
            // 
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGridView.Location = new System.Drawing.Point(7, 52);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.RowHeadersWidth = 51;
            this.employeesGridView.RowTemplate.Height = 24;
            this.employeesGridView.Size = new System.Drawing.Size(784, 391);
            this.employeesGridView.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(237, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "EmployeesGUI";
            // 
            // EmployeesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.employeesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesGUI";
            this.Text = "EmployeesGUI";
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesGridView;
        private System.Windows.Forms.Label lblTitle;
    }
}