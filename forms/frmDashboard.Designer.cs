namespace LMSBFP.forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDRRE = new System.Windows.Forms.Label();
            this.lblOfficeEquipment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblICTequipment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOtherMachineries = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMotorVehicles = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMedicalDental = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSAGF = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblForeignGrants = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCommunication = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMotorpool = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFirearms = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newEntryToolStripMenuItem.Text = "&New Entry...";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblFirearms);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.lblMotorpool);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lblCommunication);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lblForeignGrants);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblSAGF);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblMedicalDental);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblMotorVehicles);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblOtherMachineries);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblICTequipment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblOfficeEquipment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDRRE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1257, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary of Inventory";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "DRRE Equipment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDRRE
            // 
            this.lblDRRE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDRRE.BackColor = System.Drawing.Color.Teal;
            this.lblDRRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRRE.ForeColor = System.Drawing.Color.White;
            this.lblDRRE.Location = new System.Drawing.Point(23, 41);
            this.lblDRRE.Name = "lblDRRE";
            this.lblDRRE.Size = new System.Drawing.Size(87, 79);
            this.lblDRRE.TabIndex = 2;
            this.lblDRRE.Text = "00";
            this.lblDRRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOfficeEquipment
            // 
            this.lblOfficeEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOfficeEquipment.BackColor = System.Drawing.Color.Teal;
            this.lblOfficeEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeEquipment.ForeColor = System.Drawing.Color.White;
            this.lblOfficeEquipment.Location = new System.Drawing.Point(135, 41);
            this.lblOfficeEquipment.Name = "lblOfficeEquipment";
            this.lblOfficeEquipment.Size = new System.Drawing.Size(87, 79);
            this.lblOfficeEquipment.TabIndex = 4;
            this.lblOfficeEquipment.Text = "00";
            this.lblOfficeEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(135, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "Office Equipment";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblICTequipment
            // 
            this.lblICTequipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblICTequipment.BackColor = System.Drawing.Color.Teal;
            this.lblICTequipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICTequipment.ForeColor = System.Drawing.Color.White;
            this.lblICTequipment.Location = new System.Drawing.Point(247, 41);
            this.lblICTequipment.Name = "lblICTequipment";
            this.lblICTequipment.Size = new System.Drawing.Size(87, 79);
            this.lblICTequipment.TabIndex = 6;
            this.lblICTequipment.Text = "00";
            this.lblICTequipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(247, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 50);
            this.label7.TabIndex = 5;
            this.label7.Text = "ICT Equipment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtherMachineries
            // 
            this.lblOtherMachineries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOtherMachineries.BackColor = System.Drawing.Color.Teal;
            this.lblOtherMachineries.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherMachineries.ForeColor = System.Drawing.Color.White;
            this.lblOtherMachineries.Location = new System.Drawing.Point(359, 41);
            this.lblOtherMachineries.Name = "lblOtherMachineries";
            this.lblOtherMachineries.Size = new System.Drawing.Size(87, 79);
            this.lblOtherMachineries.TabIndex = 8;
            this.lblOtherMachineries.Text = "00";
            this.lblOtherMachineries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.Aqua;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 50);
            this.label9.TabIndex = 7;
            this.label9.Text = "Other Machineries and Equipment";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotorVehicles
            // 
            this.lblMotorVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotorVehicles.BackColor = System.Drawing.Color.Teal;
            this.lblMotorVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorVehicles.ForeColor = System.Drawing.Color.White;
            this.lblMotorVehicles.Location = new System.Drawing.Point(471, 41);
            this.lblMotorVehicles.Name = "lblMotorVehicles";
            this.lblMotorVehicles.Size = new System.Drawing.Size(87, 79);
            this.lblMotorVehicles.TabIndex = 10;
            this.lblMotorVehicles.Text = "00";
            this.lblMotorVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(471, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 50);
            this.label11.TabIndex = 9;
            this.label11.Text = "Motor Vehicles";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedicalDental
            // 
            this.lblMedicalDental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMedicalDental.BackColor = System.Drawing.Color.Teal;
            this.lblMedicalDental.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalDental.ForeColor = System.Drawing.Color.White;
            this.lblMedicalDental.Location = new System.Drawing.Point(583, 41);
            this.lblMedicalDental.Name = "lblMedicalDental";
            this.lblMedicalDental.Size = new System.Drawing.Size(87, 79);
            this.lblMedicalDental.TabIndex = 12;
            this.lblMedicalDental.Text = "00";
            this.lblMedicalDental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.Aqua;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(583, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 50);
            this.label13.TabIndex = 11;
            this.label13.Text = "Medical Dental Equipment";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSAGF
            // 
            this.lblSAGF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSAGF.BackColor = System.Drawing.Color.Teal;
            this.lblSAGF.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAGF.ForeColor = System.Drawing.Color.White;
            this.lblSAGF.Location = new System.Drawing.Point(695, 41);
            this.lblSAGF.Name = "lblSAGF";
            this.lblSAGF.Size = new System.Drawing.Size(87, 79);
            this.lblSAGF.TabIndex = 14;
            this.lblSAGF.Text = "00";
            this.lblSAGF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.BackColor = System.Drawing.Color.Aqua;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(695, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 50);
            this.label15.TabIndex = 13;
            this.label15.Text = "Special Account General Fund (SAGF)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblForeignGrants
            // 
            this.lblForeignGrants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForeignGrants.BackColor = System.Drawing.Color.Teal;
            this.lblForeignGrants.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForeignGrants.ForeColor = System.Drawing.Color.White;
            this.lblForeignGrants.Location = new System.Drawing.Point(807, 41);
            this.lblForeignGrants.Name = "lblForeignGrants";
            this.lblForeignGrants.Size = new System.Drawing.Size(87, 79);
            this.lblForeignGrants.TabIndex = 16;
            this.lblForeignGrants.Text = "00";
            this.lblForeignGrants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.Aqua;
            this.label17.Location = new System.Drawing.Point(807, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 50);
            this.label17.TabIndex = 15;
            this.label17.Text = "Foreign Grants";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommunication
            // 
            this.lblCommunication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommunication.BackColor = System.Drawing.Color.Teal;
            this.lblCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommunication.ForeColor = System.Drawing.Color.White;
            this.lblCommunication.Location = new System.Drawing.Point(919, 41);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new System.Drawing.Size(87, 79);
            this.lblCommunication.TabIndex = 18;
            this.lblCommunication.Text = "00";
            this.lblCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.BackColor = System.Drawing.Color.Aqua;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(919, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 50);
            this.label19.TabIndex = 17;
            this.label19.Text = "Communication Equipment";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotorpool
            // 
            this.lblMotorpool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotorpool.BackColor = System.Drawing.Color.Teal;
            this.lblMotorpool.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorpool.ForeColor = System.Drawing.Color.White;
            this.lblMotorpool.Location = new System.Drawing.Point(1031, 41);
            this.lblMotorpool.Name = "lblMotorpool";
            this.lblMotorpool.Size = new System.Drawing.Size(87, 79);
            this.lblMotorpool.TabIndex = 20;
            this.lblMotorpool.Text = "00";
            this.lblMotorpool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.BackColor = System.Drawing.Color.Aqua;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1031, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 50);
            this.label21.TabIndex = 19;
            this.label21.Text = "Motorpool Tools and Equipment";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirearms
            // 
            this.lblFirearms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirearms.BackColor = System.Drawing.Color.Teal;
            this.lblFirearms.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirearms.ForeColor = System.Drawing.Color.White;
            this.lblFirearms.Location = new System.Drawing.Point(1148, 41);
            this.lblFirearms.Name = "lblFirearms";
            this.lblFirearms.Size = new System.Drawing.Size(87, 79);
            this.lblFirearms.TabIndex = 22;
            this.lblFirearms.Text = "00";
            this.lblFirearms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.BackColor = System.Drawing.Color.Aqua;
            this.label23.Location = new System.Drawing.Point(1148, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 50);
            this.label23.TabIndex = 21;
            this.label23.Text = "MPaSE (Firearms)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1285, 657);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistics Management System - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFirearms;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMotorpool;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblCommunication;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblForeignGrants;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSAGF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMedicalDental;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMotorVehicles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOtherMachineries;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblICTequipment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOfficeEquipment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDRRE;
        private System.Windows.Forms.Label label2;
    }
}