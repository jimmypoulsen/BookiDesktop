namespace BookiDesktop {
    partial class TablesGUI {
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
            this.tablesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesGridView
            // 
            this.tablesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesGridView.Location = new System.Drawing.Point(12, 12);
            this.tablesGridView.Name = "tablesGridView";
            this.tablesGridView.RowHeadersWidth = 51;
            this.tablesGridView.RowTemplate.Height = 24;
            this.tablesGridView.Size = new System.Drawing.Size(1176, 476);
            this.tablesGridView.TabIndex = 1;
            this.tablesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablesGridView_CellClick);
            // 
            // TablesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.tablesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablesGUI";
            this.Text = "Table";
            ((System.ComponentModel.ISupportInitialize)(this.tablesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablesGridView;
    }
}