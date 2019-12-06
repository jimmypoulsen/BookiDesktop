namespace BookiDesktop {
    partial class VenuesGUI {
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
            this.venuesGridView = new System.Windows.Forms.DataGridView();
            this.lblSelectedRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.venuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // venuesGridView
            // 
            this.venuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venuesGridView.Location = new System.Drawing.Point(0, 43);
            this.venuesGridView.Name = "venuesGridView";
            this.venuesGridView.RowHeadersWidth = 51;
            this.venuesGridView.RowTemplate.Height = 24;
            this.venuesGridView.Size = new System.Drawing.Size(800, 408);
            this.venuesGridView.TabIndex = 4;
            this.venuesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.venuesGridView_CellContentClick);
            // 
            // lblSelectedRow
            // 
            this.lblSelectedRow.AutoSize = true;
            this.lblSelectedRow.Location = new System.Drawing.Point(350, 9);
            this.lblSelectedRow.Name = "lblSelectedRow";
            this.lblSelectedRow.Size = new System.Drawing.Size(97, 17);
            this.lblSelectedRow.TabIndex = 5;
            this.lblSelectedRow.Text = "Selected row: ";
            // 
            // VenuesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedRow);
            this.Controls.Add(this.venuesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenuesGUI";
            this.Text = "Venues";
            ((System.ComponentModel.ISupportInitialize)(this.venuesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView venuesGridView;
        private System.Windows.Forms.Label lblSelectedRow;
    }
}