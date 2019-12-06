namespace BookiDesktop.GUIs {
    partial class TablePackageGUI {
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
            this.lblBool = new System.Windows.Forms.Label();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.tbVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBool
            // 
            this.lblBool.AutoSize = true;
            this.lblBool.Location = new System.Drawing.Point(385, 19);
            this.lblBool.Name = "lblBool";
            this.lblBool.Size = new System.Drawing.Size(46, 17);
            this.lblBool.TabIndex = 25;
            this.lblBool.Text = "label1";
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(115, 277);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(275, 38);
            this.BtnSaveChanges.TabIndex = 24;
            this.BtnSaveChanges.Text = "Save changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // tbVenueID
            // 
            this.tbVenueID.Location = new System.Drawing.Point(118, 214);
            this.tbVenueID.Name = "tbVenueID";
            this.tbVenueID.Size = new System.Drawing.Size(270, 22);
            this.tbVenueID.TabIndex = 23;
            // 
            // lblVenueId
            // 
            this.lblVenueId.AutoSize = true;
            this.lblVenueId.Location = new System.Drawing.Point(115, 194);
            this.lblVenueId.Name = "lblVenueId";
            this.lblVenueId.Size = new System.Drawing.Size(62, 17);
            this.lblVenueId.TabIndex = 22;
            this.lblVenueId.Text = "VenueID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(115, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(116, 152);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(271, 22);
            this.tbPrice.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 22);
            this.tbName.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(154, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 32);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Edit Table Package";
            // 
            // TablePackageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 362);
            this.Controls.Add(this.lblBool);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.tbVenueID);
            this.Controls.Add(this.lblVenueId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTitle);
            this.Name = "TablePackageGUI";
            this.Text = "TablePackageGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBool;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.TextBox tbVenueID;
        private System.Windows.Forms.Label lblVenueId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblTitle;
    }
}