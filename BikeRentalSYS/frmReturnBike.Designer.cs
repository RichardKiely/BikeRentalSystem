namespace BikeRentalSYS
{
    partial class frmReturnBike
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpActualDate = new System.Windows.Forms.DateTimePicker();
            this.lblActualReturnDate = new System.Windows.Forms.Label();
            this.grpReturn = new System.Windows.Forms.GroupBox();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRentalID = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRentalID.Location = new System.Drawing.Point(176, 77);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(52, 13);
            this.lblRentalID.TabIndex = 6;
            this.lblRentalID.Text = "Rental ID";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "dd-MMM-yy";
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Location = new System.Drawing.Point(152, 29);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnDate.TabIndex = 12;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(67, 35);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(65, 13);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date";
            // 
            // dtpActualDate
            // 
            this.dtpActualDate.CustomFormat = "dd-MMM-yy";
            this.dtpActualDate.Enabled = false;
            this.dtpActualDate.Location = new System.Drawing.Point(152, 55);
            this.dtpActualDate.Name = "dtpActualDate";
            this.dtpActualDate.Size = new System.Drawing.Size(200, 20);
            this.dtpActualDate.TabIndex = 15;
            // 
            // lblActualReturnDate
            // 
            this.lblActualReturnDate.AutoSize = true;
            this.lblActualReturnDate.Location = new System.Drawing.Point(34, 62);
            this.lblActualReturnDate.Name = "lblActualReturnDate";
            this.lblActualReturnDate.Size = new System.Drawing.Size(98, 13);
            this.lblActualReturnDate.TabIndex = 14;
            this.lblActualReturnDate.Text = "Actual Return Date";
            // 
            // grpReturn
            // 
            this.grpReturn.Controls.Add(this.txtRentalID);
            this.grpReturn.Controls.Add(this.label3);
            this.grpReturn.Controls.Add(this.dtpDOB);
            this.grpReturn.Controls.Add(this.btnReturn);
            this.grpReturn.Controls.Add(this.txtName);
            this.grpReturn.Controls.Add(this.lblName);
            this.grpReturn.Controls.Add(this.lblActualReturnDate);
            this.grpReturn.Controls.Add(this.lblReturnDate);
            this.grpReturn.Controls.Add(this.txtNumber);
            this.grpReturn.Controls.Add(this.lblDateOfBirth);
            this.grpReturn.Controls.Add(this.dtpActualDate);
            this.grpReturn.Controls.Add(this.dtpReturnDate);
            this.grpReturn.Controls.Add(this.txtEmail);
            this.grpReturn.Controls.Add(this.label1);
            this.grpReturn.Controls.Add(this.label2);
            this.grpReturn.Location = new System.Drawing.Point(179, 133);
            this.grpReturn.Margin = new System.Windows.Forms.Padding(2);
            this.grpReturn.Name = "grpReturn";
            this.grpReturn.Padding = new System.Windows.Forms.Padding(2);
            this.grpReturn.Size = new System.Drawing.Size(368, 283);
            this.grpReturn.TabIndex = 26;
            this.grpReturn.TabStop = false;
            this.grpReturn.Text = "Return Rental";
            this.grpReturn.Visible = false;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Enabled = false;
            this.txtRentalID.Location = new System.Drawing.Point(207, 81);
            this.txtRentalID.MaxLength = 3;
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(100, 20);
            this.txtRentalID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(84, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rental ID";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yy";
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(208, 136);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(101, 20);
            this.dtpDOB.TabIndex = 19;
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(162, 218);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 26);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return Rental";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(208, 110);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(209, 187);
            this.txtNumber.MaxLength = 15;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 15;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(84, 137);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(152, 162);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PhoneNo";
            // 
            // cboRentalID
            // 
            this.cboRentalID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentalID.FormattingEnabled = true;
            this.cboRentalID.Location = new System.Drawing.Point(316, 69);
            this.cboRentalID.Name = "cboRentalID";
            this.cboRentalID.Size = new System.Drawing.Size(102, 21);
            this.cboRentalID.TabIndex = 29;
            this.cboRentalID.SelectedIndexChanged += new System.EventHandler(this.cboRentalID_SelectedIndexChanged);
            // 
            // frmReturnBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 463);
            this.Controls.Add(this.cboRentalID);
            this.Controls.Add(this.grpReturn);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReturnBike";
            this.Text = "frmReturnBike";
            this.Load += new System.EventHandler(this.frmReturnBike_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpReturn.ResumeLayout(false);
            this.grpReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpActualDate;
        private System.Windows.Forms.Label lblActualReturnDate;
        private System.Windows.Forms.GroupBox grpReturn;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRentalID;
    }
}