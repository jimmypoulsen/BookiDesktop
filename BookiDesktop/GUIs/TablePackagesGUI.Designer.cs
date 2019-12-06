namespace BookiDesktop {
    partial class TablePackagesGUI {
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
            this.tablePackagesGridView = new System.Windows.Forms.DataGridView();
            this.lblSelectedRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePackagesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePackagesGridView
            // 
            this.tablePackagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePackagesGridView.Location = new System.Drawing.Point(0, 33);
            this.tablePackagesGridView.Name = "tablePackagesGridView";
            this.tablePackagesGridView.RowHeadersWidth = 51;
            this.tablePackagesGridView.RowTemplate.Height = 24;
            this.tablePackagesGridView.Size = new System.Drawing.Size(801, 419);
            this.tablePackagesGridView.TabIndex = 1;
            this.tablePackagesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePackagesGridView_CellClick);
            // 
            // lblSelectedRow
            // 
            this.lblSelectedRow.AutoSize = true;
            this.lblSelectedRow.Location = new System.Drawing.Point(626, 9);
            this.lblSelectedRow.Name = "lblSelectedRow";
            this.lblSelectedRow.Size = new System.Drawing.Size(97, 17);
            this.lblSelectedRow.TabIndex = 2;
            this.lblSelectedRow.Text = "Selected row: ";
            // 
            // TablePackagesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedRow);
            this.Controls.Add(this.tablePackagesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablePackagesGUI";
            this.Text = "TablePackagesGUI";
            ((System.ComponentModel.ISupportInitialize)(this.tablePackagesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablePackagesGridView;
        private System.Windows.Forms.Label lblSelectedRow;
    }
}