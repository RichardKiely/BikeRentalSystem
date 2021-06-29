namespace BikeRentalSYS
{
    partial class frmRentBike
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
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.grpBike = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.lstShowBikes = new System.Windows.Forms.ListBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnBooking = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnAddBike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grpListBoxes = new System.Windows.Forms.GroupBox();
            this.cboTypeCode = new System.Windows.Forms.ComboBox();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBike.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpListBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtRentID
            // 
            this.txtRentID.Enabled = false;
            this.txtRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRentID.Location = new System.Drawing.Point(684, 69);
            this.txtRentID.MaxLength = 10;
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(57, 20);
            this.txtRentID.TabIndex = 5;
            this.txtRentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRentID.Visible = false;
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRentalID.Location = new System.Drawing.Point(605, 76);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(52, 13);
            this.lblRentalID.TabIndex = 4;
            this.lblRentalID.Text = "Rental ID";
            this.lblRentalID.Visible = false;
            // 
            // grpBike
            // 
            this.grpBike.Controls.Add(this.label4);
            this.grpBike.Controls.Add(this.lblDays);
            this.grpBike.Controls.Add(this.dtpDateTo);
            this.grpBike.Controls.Add(this.dtpDateFrom);
            this.grpBike.Controls.Add(this.btnAdd);
            this.grpBike.Controls.Add(this.lblReturnDate);
            this.grpBike.Controls.Add(this.lblRentalDate);
            this.grpBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBike.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBike.Location = new System.Drawing.Point(12, 17);
            this.grpBike.Name = "grpBike";
            this.grpBike.Size = new System.Drawing.Size(444, 141);
            this.grpBike.TabIndex = 3;
            this.grpBike.TabStop = false;
            this.grpBike.Text = "Check available dates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Days";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(270, 75);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(0, 13);
            this.lblDays.TabIndex = 10;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd-MMM-yy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(145, 52);
            this.dtpDateTo.MinDate = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 9;
            this.dtpDateTo.Value = new System.DateTime(2021, 4, 8, 0, 0, 0, 0);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd-MMM-yy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(145, 20);
            this.dtpDateFrom.MinDate = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 8;
            this.dtpDateFrom.Value = new System.DateTime(2021, 4, 8, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(147, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Check Availability";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(26, 54);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(53, 13);
            this.lblReturnDate.TabIndex = 4;
            this.lblReturnDate.Text = "Date To";
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalDate.Location = new System.Drawing.Point(26, 23);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(65, 13);
            this.lblRentalDate.TabIndex = 2;
            this.lblRentalDate.Text = "Date From";
            // 
            // lstShowBikes
            // 
            this.lstShowBikes.FormattingEnabled = true;
            this.lstShowBikes.Location = new System.Drawing.Point(13, 44);
            this.lstShowBikes.Name = "lstShowBikes";
            this.lstShowBikes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstShowBikes.Size = new System.Drawing.Size(200, 95);
            this.lstShowBikes.Sorted = true;
            this.lstShowBikes.TabIndex = 12;
            this.lstShowBikes.Visible = false;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblError);
            this.grpCustomer.Controls.Add(this.dtpDOB);
            this.grpCustomer.Controls.Add(this.btnBooking);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Controls.Add(this.txtPhoneNo);
            this.grpCustomer.Controls.Add(this.lblDateOfBirth);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.lblPhoneNo);
            this.grpCustomer.Location = new System.Drawing.Point(608, 128);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomer.Size = new System.Drawing.Size(368, 283);
            this.grpCustomer.TabIndex = 23;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Add Customer Details";
            this.grpCustomer.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(224, 155);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 20;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(102, 97);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(101, 20);
            this.dtpDOB.TabIndex = 19;
            this.dtpDOB.Value = new System.DateTime(2021, 4, 8, 0, 0, 0, 0);
            // 
            // btnBooking
            // 
            this.btnBooking.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.Location = new System.Drawing.Point(112, 226);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(147, 26);
            this.btnBooking.TabIndex = 18;
            this.btnBooking.Text = "Make Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 67);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(103, 148);
            this.txtPhoneNo.MaxLength = 12;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 15;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(30, 98);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 123);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(35, 151);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(52, 13);
            this.lblPhoneNo.TabIndex = 7;
            this.lblPhoneNo.Text = "PhoneNo";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(329, 44);
            this.lstCart.Name = "lstCart";
            this.lstCart.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCart.Size = new System.Drawing.Size(200, 95);
            this.lstCart.Sorted = true;
            this.lstCart.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(373, 145);
            this.txtTotal.MaxLength = 6;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(110, 20);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.Text = "00.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(312, 152);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total Cost";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(397, 174);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(86, 23);
            this.btnProceed.TabIndex = 31;
            this.btnProceed.Text = "Make Rental";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnAddBike
            // 
            this.btnAddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBike.Location = new System.Drawing.Point(228, 55);
            this.btnAddBike.Name = "btnAddBike";
            this.btnAddBike.Size = new System.Drawing.Size(84, 23);
            this.btnAddBike.TabIndex = 32;
            this.btnAddBike.Text = "Add >>";
            this.btnAddBike.UseVisualStyleBackColor = true;
            this.btnAddBike.Click += new System.EventHandler(this.btnAddBike_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Shopping Basket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Available Bikes";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(228, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "<< Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpListBoxes
            // 
            this.grpListBoxes.Controls.Add(this.button2);
            this.grpListBoxes.Controls.Add(this.label2);
            this.grpListBoxes.Controls.Add(this.btnProceed);
            this.grpListBoxes.Controls.Add(this.lblTotal);
            this.grpListBoxes.Controls.Add(this.label1);
            this.grpListBoxes.Controls.Add(this.txtTotal);
            this.grpListBoxes.Controls.Add(this.lstShowBikes);
            this.grpListBoxes.Controls.Add(this.btnAddBike);
            this.grpListBoxes.Controls.Add(this.lstCart);
            this.grpListBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListBoxes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpListBoxes.Location = new System.Drawing.Point(9, 208);
            this.grpListBoxes.Name = "grpListBoxes";
            this.grpListBoxes.Size = new System.Drawing.Size(581, 203);
            this.grpListBoxes.TabIndex = 36;
            this.grpListBoxes.TabStop = false;
            this.grpListBoxes.Text = "Check available dates";
            this.grpListBoxes.Visible = false;
            // 
            // cboTypeCode
            // 
            this.cboTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeCode.FormattingEnabled = true;
            this.cboTypeCode.Location = new System.Drawing.Point(122, 169);
            this.cboTypeCode.Name = "cboTypeCode";
            this.cboTypeCode.Size = new System.Drawing.Size(100, 21);
            this.cboTypeCode.TabIndex = 38;
            this.cboTypeCode.Visible = false;
            this.cboTypeCode.SelectedIndexChanged += new System.EventHandler(this.cboTypes_SelectedIndexChanged_1);
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.Location = new System.Drawing.Point(12, 169);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(59, 13);
            this.lblTypeCode.TabIndex = 37;
            this.lblTypeCode.Text = "Type Code";
            this.lblTypeCode.Visible = false;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(721, 378);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 39;
            // 
            // frmRentBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 568);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.cboTypeCode);
            this.Controls.Add(this.lblTypeCode);
            this.Controls.Add(this.grpListBoxes);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.txtRentID);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.grpBike);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRentBike";
            this.Text = "frmRentBike";
            this.Load += new System.EventHandler(this.frmRentBike_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBike.ResumeLayout(false);
            this.grpBike.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpListBoxes.ResumeLayout(false);
            this.grpListBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.GroupBox grpBike;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.ListBox lstShowBikes;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnAddBike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpListBoxes;
        private System.Windows.Forms.ComboBox cboTypeCode;
        private System.Windows.Forms.Label lblTypeCode;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblError;
    }
}