namespace BookiDesktop.GUIs {
    partial class VenueGUI {
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVenueID = new System.Windows.Forms.TextBox();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(180, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Venue";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 99);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(116, 154);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(271, 22);
            this.tbAddress.TabIndex = 2;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(115, 209);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(271, 22);
            this.tbCity.TabIndex = 3;
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(115, 268);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(271, 22);
            this.tbZip.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(115, 134);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(113, 189);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(113, 248);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(28, 17);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "Zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "VenueID";
            // 
            // tbVenueID
            // 
            this.tbVenueID.Location = new System.Drawing.Point(116, 325);
            this.tbVenueID.Name = "tbVenueID";
            this.tbVenueID.Size = new System.Drawing.Size(270, 22);
            this.tbVenueID.TabIndex = 10;
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(156, 372);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(197, 38);
            this.BtnSaveChanges.TabIndex = 11;
            this.BtnSaveChanges.Text = "Save changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // VenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.tbVenueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTitle);
            this.Name = "VenueGUI";
            this.Text = "EditVenuesGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVenueID;
        private System.Windows.Forms.Button BtnSaveChanges;
    }
}