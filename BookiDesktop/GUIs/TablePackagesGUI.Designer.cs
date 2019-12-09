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
            ((System.ComponentModel.ISupportInitialize)(this.tablePackagesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePackagesGridView
            // 
            this.tablePackagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePackagesGridView.Location = new System.Drawing.Point(12, 12);
            this.tablePackagesGridView.Name = "tablePackagesGridView";
            this.tablePackagesGridView.RowHeadersWidth = 51;
            this.tablePackagesGridView.RowTemplate.Height = 24;
            this.tablePackagesGridView.Size = new System.Drawing.Size(1176, 476);
            this.tablePackagesGridView.TabIndex = 1;
            this.tablePackagesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePackagesGridView_CellClick);
            // 
            // TablePackagesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.tablePackagesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablePackagesGUI";
            this.Text = "TablePackagesGUI";
            ((System.ComponentModel.ISupportInitialize)(this.tablePackagesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablePackagesGridView;
    }
}