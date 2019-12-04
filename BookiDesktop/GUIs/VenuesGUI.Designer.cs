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
            ((System.ComponentModel.ISupportInitialize)(this.venuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // venuesGridView
            // 
            this.venuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venuesGridView.Location = new System.Drawing.Point(0, -2);
            this.venuesGridView.Name = "venuesGridView";
            this.venuesGridView.RowHeadersWidth = 51;
            this.venuesGridView.RowTemplate.Height = 24;
            this.venuesGridView.Size = new System.Drawing.Size(800, 453);
            this.venuesGridView.TabIndex = 4;
            // 
            // VenuesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.venuesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenuesGUI";
            this.Text = "Venues";
            ((System.ComponentModel.ISupportInitialize)(this.venuesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView venuesGridView;
    }
}