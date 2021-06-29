namespace BikeRentalSYS
{
    partial class frmCollectBike
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
            this.grpCollect = new System.Windows.Forms.GroupBox();
            this.lblActualCollectDate = new System.Windows.Forms.Label();
            this.lblCollectDate = new System.Windows.Forms.Label();
            this.dtpActualCollectDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCollectDate = new System.Windows.Forms.DateTimePicker();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnCollect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRentalID = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpCollect.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
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
            this.lblRentalID.Location = new System.Drawing.Point(148, 77);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(52, 13);
            this.lblRentalID.TabIndex = 11;
            this.lblRentalID.Text = "Rental ID";
            // 
            // grpCollect
            // 
            this.grpCollect.Controls.Add(this.lblActualCollectDate);
            this.grpCollect.Controls.Add(this.lblCollectDate);
            this.grpCollect.Controls.Add(this.dtpActualCollectDate);
            this.grpCollect.Controls.Add(this.dtpCollectDate);
            this.grpCollect.Controls.Add(this.txtRentalID);
            this.grpCollect.Controls.Add(this.label3);
            this.grpCollect.Controls.Add(this.dtpDOB);
            this.grpCollect.Controls.Add(this.btnCollect);
            this.grpCollect.Controls.Add(this.txtName);
            this.grpCollect.Controls.Add(this.lblName);
            this.grpCollect.Controls.Add(this.txtNumber);
            this.grpCollect.Controls.Add(this.lblDateOfBirth);
            this.grpCollect.Controls.Add(this.txtEmail);
            this.grpCollect.Controls.Add(this.label1);
            this.grpCollect.Controls.Add(this.label2);
            this.grpCollect.Location = new System.Drawing.Point(151, 95);
            this.grpCollect.Margin = new System.Windows.Forms.Padding(2);
            this.grpCollect.Name = "grpCollect";
            this.grpCollect.Padding = new System.Windows.Forms.Padding(2);
            this.grpCollect.Size = new System.Drawing.Size(477, 317);
            this.grpCollect.TabIndex = 25;
            this.grpCollect.TabStop = false;
            this.grpCollect.Text = "Collect Rental";
            this.grpCollect.Visible = false;
            // 
            // lblActualCollectDate
            // 
            this.lblActualCollectDate.AutoSize = true;
            this.lblActualCollectDate.Location = new System.Drawing.Point(38, 59);
            this.lblActualCollectDate.Name = "lblActualCollectDate";
            this.lblActualCollectDate.Size = new System.Drawing.Size(98, 13);
            this.lblActualCollectDate.TabIndex = 25;
            this.lblActualCollectDate.Text = "Actual Collect Date";
            // 
            // lblCollectDate
            // 
            this.lblCollectDate.AutoSize = true;
            this.lblCollectDate.Location = new System.Drawing.Point(71, 32);
            this.lblCollectDate.Name = "lblCollectDate";
            this.lblCollectDate.Size = new System.Drawing.Size(65, 13);
            this.lblCollectDate.TabIndex = 23;
            this.lblCollectDate.Text = "Collect Date";
            // 
            // dtpActualCollectDate
            // 
            this.dtpActualCollectDate.CustomFormat = "dd-MMM-yy";
            this.dtpActualCollectDate.Enabled = false;
            this.dtpActualCollectDate.Location = new System.Drawing.Point(156, 52);
            this.dtpActualCollectDate.Name = "dtpActualCollectDate";
            this.dtpActualCollectDate.Size = new System.Drawing.Size(200, 20);
            this.dtpActualCollectDate.TabIndex = 26;
            // 
            // dtpCollectDate
            // 
            this.dtpCollectDate.CustomFormat = "dd-MMM-yy";
            this.dtpCollectDate.Enabled = false;
            this.dtpCollectDate.Location = new System.Drawing.Point(156, 26);
            this.dtpCollectDate.Name = "dtpCollectDate";
            this.dtpCollectDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCollectDate.TabIndex = 24;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Enabled = false;
            this.txtRentalID.Location = new System.Drawing.Point(199, 95);
            this.txtRentalID.MaxLength = 10;
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(100, 20);
            this.txtRentalID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(76, 102);
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
            this.dtpDOB.Location = new System.Drawing.Point(200, 150);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(101, 20);
            this.dtpDOB.TabIndex = 19;
            // 
            // btnCollect
            // 
            this.btnCollect.ForeColor = System.Drawing.Color.Black;
            this.btnCollect.Location = new System.Drawing.Point(154, 249);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(147, 26);
            this.btnCollect.TabIndex = 18;
            this.btnCollect.Text = "Collect Rental";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(200, 124);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(76, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(201, 201);
            this.txtNumber.MaxLength = 12;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 15;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(76, 151);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(144, 176);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PhoneNo";
            // 
            // cboRentalID
            // 
            this.cboRentalID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentalID.FormattingEnabled = true;
            this.cboRentalID.Location = new System.Drawing.Point(238, 69);
            this.cboRentalID.Name = "cboRentalID";
            this.cboRentalID.Size = new System.Drawing.Size(102, 21);
            this.cboRentalID.TabIndex = 29;
            this.cboRentalID.SelectedIndexChanged += new System.EventHandler(this.cboRentalID_SelectedIndexChanged);
            // 
            // frmCollectBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 423);
            this.Controls.Add(this.cboRentalID);
            this.Controls.Add(this.grpCollect);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCollectBike";
            this.Text = "frmCollect";
            this.Load += new System.EventHandler(this.frmCollectBike_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCollect.ResumeLayout(false);
            this.grpCollect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.GroupBox grpCollect;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRentalID;
        private System.Windows.Forms.Label lblActualCollectDate;
        private System.Windows.Forms.Label lblCollectDate;
        private System.Windows.Forms.DateTimePicker dtpActualCollectDate;
        private System.Windows.Forms.DateTimePicker dtpCollectDate;
    }
}