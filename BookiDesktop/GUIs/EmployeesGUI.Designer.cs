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
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesGridView
            // 
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGridView.Location = new System.Drawing.Point(12, 12);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.RowHeadersWidth = 51;
            this.employeesGridView.RowTemplate.Height = 24;
            this.employeesGridView.Size = new System.Drawing.Size(1176, 476);
            this.employeesGridView.TabIndex = 0;
            this.employeesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesGridView_CellClick);
            // 
            // EmployeesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.employeesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesGUI";
            this.Text = "EmployeesGUI";
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesGridView;
    }
}