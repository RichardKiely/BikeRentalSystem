namespace BikeRentalSYS
{
    partial class frmBikeUpdate
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
            this.grpBike = new System.Windows.Forms.GroupBox();
            this.cboTypeCode = new System.Windows.Forms.ComboBox();
            this.lblBikeID = new System.Windows.Forms.Label();
            this.txtBikeId = new System.Windows.Forms.TextBox();
            this.lblWheels = new System.Windows.Forms.Label();
            this.txtWheels = new System.Windows.Forms.TextBox();
            this.lblGears = new System.Windows.Forms.Label();
            this.txtGears = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMan = new System.Windows.Forms.Label();
            this.txtMan = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboBikeID = new System.Windows.Forms.ComboBox();
            this.grpBike.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBike
            // 
            this.grpBike.Controls.Add(this.cboTypeCode);
            this.grpBike.Controls.Add(this.lblBikeID);
            this.grpBike.Controls.Add(this.txtBikeId);
            this.grpBike.Controls.Add(this.lblWheels);
            this.grpBike.Controls.Add(this.txtWheels);
            this.grpBike.Controls.Add(this.lblGears);
            this.grpBike.Controls.Add(this.txtGears);
            this.grpBike.Controls.Add(this.btnAdd);
            this.grpBike.Controls.Add(this.lblMan);
            this.grpBike.Controls.Add(this.txtMan);
            this.grpBike.Controls.Add(this.lblType);
            this.grpBike.Location = new System.Drawing.Point(44, 81);
            this.grpBike.Name = "grpBike";
            this.grpBike.Size = new System.Drawing.Size(473, 270);
            this.grpBike.TabIndex = 1;
            this.grpBike.TabStop = false;
            this.grpBike.Text = "Enter Bike Details";
            this.grpBike.Visible = false;
            // 
            // cboTypeCode
            // 
            this.cboTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeCode.FormattingEnabled = true;
            this.cboTypeCode.Location = new System.Drawing.Point(138, 56);
            this.cboTypeCode.Name = "cboTypeCode";
            this.cboTypeCode.Size = new System.Drawing.Size(89, 21);
            this.cboTypeCode.TabIndex = 17;
            // 
            // lblBikeID
            // 
            this.lblBikeID.AutoSize = true;
            this.lblBikeID.Location = new System.Drawing.Point(32, 33);
            this.lblBikeID.Name = "lblBikeID";
            this.lblBikeID.Size = new System.Drawing.Size(42, 13);
            this.lblBikeID.TabIndex = 16;
            this.lblBikeID.Text = "Bike ID";
            // 
            // txtBikeId
            // 
            this.txtBikeId.Enabled = false;
            this.txtBikeId.Location = new System.Drawing.Point(138, 26);
            this.txtBikeId.MaxLength = 3;
            this.txtBikeId.Name = "txtBikeId";
            this.txtBikeId.Size = new System.Drawing.Size(58, 20);
            this.txtBikeId.TabIndex = 15;
            // 
            // lblWheels
            // 
            this.lblWheels.AutoSize = true;
            this.lblWheels.Location = new System.Drawing.Point(26, 162);
            this.lblWheels.Name = "lblWheels";
            this.lblWheels.Size = new System.Drawing.Size(61, 13);
            this.lblWheels.TabIndex = 11;
            this.lblWheels.Text = "Wheel Size";
            // 
            // txtWheels
            // 
            this.txtWheels.Location = new System.Drawing.Point(138, 155);
            this.txtWheels.MaxLength = 2;
            this.txtWheels.Name = "txtWheels";
            this.txtWheels.Size = new System.Drawing.Size(252, 20);
            this.txtWheels.TabIndex = 10;
            // 
            // lblGears
            // 
            this.lblGears.AutoSize = true;
            this.lblGears.Location = new System.Drawing.Point(27, 127);
            this.lblGears.Name = "lblGears";
            this.lblGears.Size = new System.Drawing.Size(35, 13);
            this.lblGears.TabIndex = 9;
            this.lblGears.Text = "Gears";
            // 
            // txtGears
            // 
            this.txtGears.Location = new System.Drawing.Point(138, 124);
            this.txtGears.MaxLength = 2;
            this.txtGears.Name = "txtGears";
            this.txtGears.Size = new System.Drawing.Size(63, 20);
            this.txtGears.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Location = new System.Drawing.Point(26, 93);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(67, 13);
            this.lblMan.TabIndex = 6;
            this.lblMan.Text = "Manufactuer";
            // 
            // txtMan
            // 
            this.txtMan.Location = new System.Drawing.Point(138, 86);
            this.txtMan.MaxLength = 20;
            this.txtMan.Name = "txtMan";
            this.txtMan.Size = new System.Drawing.Size(252, 20);
            this.txtMan.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(28, 59);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Bike Type";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(52, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Select Bike ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 8;
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
            // cboBikeID
            // 
            this.cboBikeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBikeID.Location = new System.Drawing.Point(138, 37);
            this.cboBikeID.Name = "cboBikeID";
            this.cboBikeID.Size = new System.Drawing.Size(121, 21);
            this.cboBikeID.TabIndex = 0;
            this.cboBikeID.SelectedIndexChanged += new System.EventHandler(this.cboBikeID_SelectedIndexChanged);
            // 
            // frmBikeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 416);
            this.Controls.Add(this.cboBikeID);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.grpBike);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBikeUpdate";
            this.Text = "frmBikeUpdate";
            this.Load += new System.EventHandler(this.frmBikeUpdate_Load);
            this.grpBike.ResumeLayout(false);
            this.grpBike.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBike;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.TextBox txtMan;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblGears;
        private System.Windows.Forms.TextBox txtGears;
        private System.Windows.Forms.Label lblWheels;
        private System.Windows.Forms.TextBox txtWheels;
        private System.Windows.Forms.ComboBox cboBikeID;
        private System.Windows.Forms.Label lblBikeID;
        private System.Windows.Forms.TextBox txtBikeId;
        private System.Windows.Forms.ComboBox cboTypeCode;
    }
}