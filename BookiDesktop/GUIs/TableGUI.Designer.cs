namespace BookiDesktop.GUIs {
    partial class TableGUI {
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSeats = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(109, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(107, 80);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(112, 17);
            this.lblSeats.TabIndex = 16;
            this.lblSeats.Text = "Number of seats";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(110, 155);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 22);
            this.tbName.TabIndex = 13;
            // 
            // tbSeats
            // 
            this.tbSeats.Location = new System.Drawing.Point(109, 100);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(271, 22);
            this.tbSeats.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(174, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 32);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Edit Table";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(109, 193);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(49, 17);
            this.lblVenue.TabIndex = 21;
            this.lblVenue.Text = "Venue";
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(110, 273);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(271, 38);
            this.BtnSaveChanges.TabIndex = 22;
            this.BtnSaveChanges.Text = "Save changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // cbVenue
            // 
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Location = new System.Drawing.Point(109, 213);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(271, 24);
            this.cbVenue.TabIndex = 24;
            // 
            // TableGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 358);
            this.Controls.Add(this.cbVenue);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSeats);
            this.Controls.Add(this.lblTitle);
            this.Name = "TableGUI";
            this.Text = "TableGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSeats;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.ComboBox cbVenue;
    }
}