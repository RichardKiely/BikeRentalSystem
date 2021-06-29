namespace BikeRentalSYS
{
    partial class frmBikeAdd
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
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.txtWheelSize = new System.Windows.Forms.TextBox();
            this.txtGears = new System.Windows.Forms.TextBox();
            this.txtManufactuer = new System.Windows.Forms.TextBox();
            this.lblWheels = new System.Windows.Forms.Label();
            this.lblGears = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuback = new System.Windows.Forms.ToolStripMenuItem();
            this.txtid = new System.Windows.Forms.TextBox();
            this.grpBike.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBike
            // 
            this.grpBike.Controls.Add(this.cboTypes);
            this.grpBike.Controls.Add(this.txtWheelSize);
            this.grpBike.Controls.Add(this.txtGears);
            this.grpBike.Controls.Add(this.txtManufactuer);
            this.grpBike.Controls.Add(this.lblWheels);
            this.grpBike.Controls.Add(this.lblGears);
            this.grpBike.Controls.Add(this.btnAdd);
            this.grpBike.Controls.Add(this.label4);
            this.grpBike.Controls.Add(this.label2);
            this.grpBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBike.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBike.Location = new System.Drawing.Point(58, 95);
            this.grpBike.Name = "grpBike";
            this.grpBike.Size = new System.Drawing.Size(473, 270);
            this.grpBike.TabIndex = 0;
            this.grpBike.TabStop = false;
            this.grpBike.Text = "Enter Bike Details";
            // 
            // cboTypes
            // 
            this.cboTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(143, 27);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(100, 21);
            this.cboTypes.TabIndex = 27;
            // 
            // txtWheelSize
            // 
            this.txtWheelSize.Location = new System.Drawing.Point(143, 142);
            this.txtWheelSize.MaxLength = 2;
            this.txtWheelSize.Name = "txtWheelSize";
            this.txtWheelSize.Size = new System.Drawing.Size(100, 20);
            this.txtWheelSize.TabIndex = 26;
            // 
            // txtGears
            // 
            this.txtGears.Location = new System.Drawing.Point(143, 103);
            this.txtGears.MaxLength = 2;
            this.txtGears.Name = "txtGears";
            this.txtGears.Size = new System.Drawing.Size(100, 20);
            this.txtGears.TabIndex = 25;
            // 
            // txtManufactuer
            // 
            this.txtManufactuer.Location = new System.Drawing.Point(143, 64);
            this.txtManufactuer.MaxLength = 20;
            this.txtManufactuer.Name = "txtManufactuer";
            this.txtManufactuer.Size = new System.Drawing.Size(100, 20);
            this.txtManufactuer.TabIndex = 24;
            // 
            // lblWheels
            // 
            this.lblWheels.AutoSize = true;
            this.lblWheels.Location = new System.Drawing.Point(43, 145);
            this.lblWheels.Name = "lblWheels";
            this.lblWheels.Size = new System.Drawing.Size(61, 13);
            this.lblWheels.TabIndex = 17;
            this.lblWheels.Text = "Wheel Size";
            // 
            // lblGears
            // 
            this.lblGears.AutoSize = true;
            this.lblGears.Location = new System.Drawing.Point(44, 110);
            this.lblGears.Name = "lblGears";
            this.lblGears.Size = new System.Drawing.Size(35, 13);
            this.lblGears.TabIndex = 15;
            this.lblGears.Text = "Gears";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(191, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manufactuer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bike ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuback});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuback
            // 
            this.mnuback.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuback.Name = "mnuback";
            this.mnuback.Size = new System.Drawing.Size(44, 20);
            this.mnuback.Text = "Back";
            this.mnuback.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.mnuback.Click += new System.EventHandler(this.mnuback_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(118, 55);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(71, 20);
            this.txtid.TabIndex = 20;
            // 
            // frmBikeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 388);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBike);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBikeAdd";
            this.Text = "frmBikeAdd";
            this.Load += new System.EventHandler(this.frmBikeAdd_Load);
            this.grpBike.ResumeLayout(false);
            this.grpBike.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuback;
        private System.Windows.Forms.Label lblWheels;
        private System.Windows.Forms.Label lblGears;
        private System.Windows.Forms.TextBox txtWheelSize;
        private System.Windows.Forms.TextBox txtGears;
        private System.Windows.Forms.TextBox txtManufactuer;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cboTypes;
    }
}