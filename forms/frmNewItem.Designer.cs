namespace LMSBFP.forms
{
    partial class frmNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewItem));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPropertyNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPARnum = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDateAcquired = new System.Windows.Forms.DateTimePicker();
            this.txtUnitValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addProgressbar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 54);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Article (Item Name):";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Communication Equipment",
            "DRRE Equipment",
            "Foreign Grants",
            "ICT Equipment",
            "Medical Dental Equipment",
            "Motor Vehicles",
            "Motorpool Tools and Equipment",
            "MPaSE (Firearms)",
            "Office Equipment",
            "Other Machineries & Equipment",
            "Special Account General Fund (SAGF)"});
            this.cboCategory.Location = new System.Drawing.Point(117, 64);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(210, 21);
            this.cboCategory.Sorted = true;
            this.cboCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 118);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(210, 66);
            this.txtDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category:";
            // 
            // cboArticle
            // 
            this.cboArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Items.AddRange(new object[] {
            "Accessories",
            "Aircon",
            "Ambulance",
            "Arc Welding Machine",
            "Automated External Defibrillator",
            "Cal. 38, Pistol",
            "Cal. 38, Revolver",
            "Cal. 45, Pistol",
            "Cal. 5.56mm M-16",
            "Cal. 9mm, Pistol",
            "Collapsed Structure & Rescue Truck",
            "Compression Tester",
            "Copier with Toner",
            "Dental Cabinet",
            "Dental Chair",
            "Desktop Computer",
            "Document Scanner",
            "Emergency Spot Lights",
            "Extra Cylinder",
            "Fire Coat & Trouser",
            "Fire Entry Suit",
            "Fire Pump",
            "Firetruck",
            "Generator Set",
            "High Angle Rescue Equipment",
            "High Speed Wrench (Manual)",
            "High Speed Wrench (Pneumatic)",
            "Impact Wrench (Pneumatic)",
            "IT Machinery & Equipment",
            "Ladder",
            "Laptop",
            "Personal Protective Suits & Gears for Hazmat",
            "Pliers Set",
            "Portable Generator",
            "Portable Scene Light",
            "Power Generator",
            "Rescue & Disaster Equipment Van",
            "Rescue Boat",
            "Rescue Tools",
            "SCBA",
            "SCBA Cylinder",
            "SCBA Refilling System",
            "Service Vehicle",
            "Smartphone",
            "Smoke Ejector",
            "Sound System",
            "Sterilizer",
            "Tablet",
            "Wrench Set"});
            this.cboArticle.Location = new System.Drawing.Point(117, 91);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(210, 21);
            this.cboArticle.Sorted = true;
            this.cboArticle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Property Number:";
            // 
            // txtPropertyNum
            // 
            this.txtPropertyNum.Location = new System.Drawing.Point(117, 190);
            this.txtPropertyNum.Name = "txtPropertyNum";
            this.txtPropertyNum.Size = new System.Drawing.Size(210, 20);
            this.txtPropertyNum.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unit of Measure:";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "Box",
            "Pair",
            "Piece",
            "Ream",
            "Roll",
            "Set",
            "Unit"});
            this.cboUnit.Location = new System.Drawing.Point(117, 268);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(210, 21);
            this.cboUnit.Sorted = true;
            this.cboUnit.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(117, 295);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(71, 20);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Region:";
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Items.AddRange(new object[] {
            "NCR",
            "BARMM",
            "CAR",
            "CARAGA",
            "Region 1",
            "Region 2",
            "Region 3",
            "Region 4A",
            "Region 4B",
            "Region 5",
            "Region 6",
            "Region 7",
            "Region 8",
            "Region 9",
            "Region 10",
            "Region 11",
            "Region 12"});
            this.cboRegion.Location = new System.Drawing.Point(117, 321);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(210, 21);
            this.cboRegion.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "PAR Number:";
            // 
            // txtPARnum
            // 
            this.txtPARnum.Location = new System.Drawing.Point(117, 348);
            this.txtPARnum.Name = "txtPARnum";
            this.txtPARnum.Size = new System.Drawing.Size(210, 20);
            this.txtPARnum.TabIndex = 12;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(117, 374);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(210, 20);
            this.txtReference.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reference:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(121, 460);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 51);
            this.cmdSave.TabIndex = 14;
            this.cmdSave.Text = "&SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(227, 460);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 51);
            this.cmdCancel.TabIndex = 15;
            this.cmdCancel.Text = "C&ANCEL";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Date Acquired:";
            // 
            // txtDateAcquired
            // 
            this.txtDateAcquired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateAcquired.Location = new System.Drawing.Point(117, 216);
            this.txtDateAcquired.Name = "txtDateAcquired";
            this.txtDateAcquired.Size = new System.Drawing.Size(210, 20);
            this.txtDateAcquired.TabIndex = 7;
            // 
            // txtUnitValue
            // 
            this.txtUnitValue.Location = new System.Drawing.Point(117, 242);
            this.txtUnitValue.Name = "txtUnitValue";
            this.txtUnitValue.Size = new System.Drawing.Size(166, 20);
            this.txtUnitValue.TabIndex = 8;
            this.txtUnitValue.TextChanged += new System.EventHandler(this.txtUnitValue_TextChanged);
            this.txtUnitValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitValue_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Unit Value (Price):";
            // 
            // addProgressbar
            // 
            this.addProgressbar.Location = new System.Drawing.Point(15, 403);
            this.addProgressbar.Name = "addProgressbar";
            this.addProgressbar.Size = new System.Drawing.Size(312, 23);
            this.addProgressbar.TabIndex = 23;
            this.addProgressbar.Visible = false;
            // 
            // frmNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(357, 523);
            this.Controls.Add(this.addProgressbar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUnitValue);
            this.Controls.Add(this.txtDateAcquired);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtPARnum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPropertyNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPropertyNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPARnum;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtDateAcquired;
        private System.Windows.Forms.TextBox txtUnitValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar addProgressbar;
    }
}