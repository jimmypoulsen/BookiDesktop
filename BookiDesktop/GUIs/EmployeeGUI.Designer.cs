namespace BookiDesktop.GUIs {
    partial class EmployeeGUI {
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
            this.cbVenueID = new System.Windows.Forms.ComboBox();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmployeeTitle = new System.Windows.Forms.TextBox();
            this.lblEmployeeTitle = new System.Windows.Forms.Label();
            this.tbEmployeeNo = new System.Windows.Forms.TextBox();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVenueID
            // 
            this.cbVenueID.FormattingEnabled = true;
            this.cbVenueID.Location = new System.Drawing.Point(36, 390);
            this.cbVenueID.Name = "cbVenueID";
            this.cbVenueID.Size = new System.Drawing.Size(271, 24);
            this.cbVenueID.TabIndex = 32;
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(36, 499);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(271, 38);
            this.BtnSaveChanges.TabIndex = 31;
            this.BtnSaveChanges.Text = "Save changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(37, 370);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(49, 17);
            this.lblVenue.TabIndex = 30;
            this.lblVenue.Text = "Venue";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(36, 104);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 22);
            this.tbName.TabIndex = 27;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(101, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 32);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Edit Employee";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(36, 157);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(271, 22);
            this.tbPhone.TabIndex = 33;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "Phone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(36, 214);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(271, 22);
            this.tbEmail.TabIndex = 35;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 254);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(36, 274);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(271, 22);
            this.tbPassword.TabIndex = 38;
            // 
            // tbEmployeeTitle
            // 
            this.tbEmployeeTitle.Location = new System.Drawing.Point(36, 328);
            this.tbEmployeeTitle.Name = "tbEmployeeTitle";
            this.tbEmployeeTitle.Size = new System.Drawing.Size(271, 22);
            this.tbEmployeeTitle.TabIndex = 40;
            // 
            // lblEmployeeTitle
            // 
            this.lblEmployeeTitle.AutoSize = true;
            this.lblEmployeeTitle.Location = new System.Drawing.Point(36, 308);
            this.lblEmployeeTitle.Name = "lblEmployeeTitle";
            this.lblEmployeeTitle.Size = new System.Drawing.Size(35, 17);
            this.lblEmployeeTitle.TabIndex = 39;
            this.lblEmployeeTitle.Text = "Title";
            // 
            // tbEmployeeNo
            // 
            this.tbEmployeeNo.Location = new System.Drawing.Point(36, 457);
            this.tbEmployeeNo.Name = "tbEmployeeNo";
            this.tbEmployeeNo.Size = new System.Drawing.Size(270, 22);
            this.tbEmployeeNo.TabIndex = 41;
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Location = new System.Drawing.Point(40, 437);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(122, 17);
            this.lblEmployeeNo.TabIndex = 42;
            this.lblEmployeeNo.Text = "Employee number";
            // 
            // EmployeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 549);
            this.Controls.Add(this.lblEmployeeNo);
            this.Controls.Add(this.tbEmployeeNo);
            this.Controls.Add(this.tbEmployeeTitle);
            this.Controls.Add(this.lblEmployeeTitle);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.cbVenueID);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTitle);
            this.Name = "EmployeeGUI";
            this.Text = "EmployeeGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVenueID;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmployeeTitle;
        private System.Windows.Forms.Label lblEmployeeTitle;
        private System.Windows.Forms.TextBox tbEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeNo;
    }
}