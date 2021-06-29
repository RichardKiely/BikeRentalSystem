namespace BikeRentalSYS
{
    partial class BikeRentalSYS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BikeRentalSYS));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBike = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBikeType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBike = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentBike = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBike = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectBike = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelRental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseRev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMain.BackgroundImage")));
            this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMain.ErrorImage = null;
            this.picMain.Location = new System.Drawing.Point(0, 27);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(555, 342);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.Click += new System.EventHandler(this.picMain_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBike,
            this.mnuRental,
            this.mnuAdmin,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBike
            // 
            this.mnuBike.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBikeType,
            this.mnuAddBike,
            this.mnuUpdate,
            this.mnuRemove});
            this.mnuBike.Name = "mnuBike";
            this.mnuBike.Size = new System.Drawing.Size(46, 20);
            this.mnuBike.Text = "Bikes";
            // 
            // mnuAddBikeType
            // 
            this.mnuAddBikeType.Name = "mnuAddBikeType";
            this.mnuAddBikeType.Size = new System.Drawing.Size(148, 22);
            this.mnuAddBikeType.Text = "Add Bike Type";
            this.mnuAddBikeType.Click += new System.EventHandler(this.mnuAddBike_Click);
            // 
            // mnuAddBike
            // 
            this.mnuAddBike.Name = "mnuAddBike";
            this.mnuAddBike.Size = new System.Drawing.Size(148, 22);
            this.mnuAddBike.Text = "Add Bike";
            this.mnuAddBike.Click += new System.EventHandler(this.mnuAddDate_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(148, 22);
            this.mnuUpdate.Text = "Update Bike";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuChangeBike_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(148, 22);
            this.mnuRemove.Text = "Remove Bike";
            this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click);
            // 
            // mnuRental
            // 
            this.mnuRental.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentBike,
            this.mnuReturnBike,
            this.mnuCollectBike,
            this.mnuCancelRental});
            this.mnuRental.Name = "mnuRental";
            this.mnuRental.Size = new System.Drawing.Size(52, 20);
            this.mnuRental.Text = "Rental";
            this.mnuRental.Click += new System.EventHandler(this.mnuRental_Click);
            // 
            // mnuRentBike
            // 
            this.mnuRentBike.Name = "mnuRentBike";
            this.mnuRentBike.Size = new System.Drawing.Size(146, 22);
            this.mnuRentBike.Text = "Rent Bike";
            this.mnuRentBike.Click += new System.EventHandler(this.mnuRentBike_Click);
            // 
            // mnuReturnBike
            // 
            this.mnuReturnBike.Name = "mnuReturnBike";
            this.mnuReturnBike.Size = new System.Drawing.Size(146, 22);
            this.mnuReturnBike.Text = "Return Bike";
            this.mnuReturnBike.Click += new System.EventHandler(this.mnuReturnBike_Click);
            // 
            // mnuCollectBike
            // 
            this.mnuCollectBike.Name = "mnuCollectBike";
            this.mnuCollectBike.Size = new System.Drawing.Size(146, 22);
            this.mnuCollectBike.Text = "Collect Bike";
            this.mnuCollectBike.Click += new System.EventHandler(this.mnuCollectBike_Click);
            // 
            // mnuCancelRental
            // 
            this.mnuCancelRental.Name = "mnuCancelRental";
            this.mnuCancelRental.Size = new System.Drawing.Size(146, 22);
            this.mnuCancelRental.Text = "Cancel Rental";
            this.mnuCancelRental.Click += new System.EventHandler(this.mnuCancelRental_Click_1);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearly,
            this.mnuAnalyseRev});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdmin_Click);
            // 
            // mnuYearly
            // 
            this.mnuYearly.Name = "mnuYearly";
            this.mnuYearly.Size = new System.Drawing.Size(164, 22);
            this.mnuYearly.Text = "List yearly rentals";
            this.mnuYearly.Click += new System.EventHandler(this.mnuYearly_Click);
            // 
            // mnuAnalyseRev
            // 
            this.mnuAnalyseRev.Name = "mnuAnalyseRev";
            this.mnuAnalyseRev.Size = new System.Drawing.Size(164, 22);
            this.mnuAnalyseRev.Text = "Analyse Revenue";
            this.mnuAnalyseRev.Click += new System.EventHandler(this.mnuAnalyseRev_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // BikeRentalSYS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 370);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BikeRentalSYS";
            this.Text = "BikeRentalSYS";
            this.Load += new System.EventHandler(this.BikeRentalSYS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBike;
        private System.Windows.Forms.ToolStripMenuItem mnuRental;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBikeType;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBike;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuRentBike;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBike;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectBike;
        private System.Windows.Forms.ToolStripMenuItem mnuYearly;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseRev;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelRental;
    }
}

