namespace WinForms_1
{
    partial class AddHouse
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSqft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPropType = new System.Windows.Forms.ComboBox();
            this.cmbBeds = new System.Windows.Forms.ComboBox();
            this.cmbBaths = new System.Windows.Forms.ComboBox();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 21);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Another";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 21);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Bathrooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Bedrooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Property Type";
            // 
            // txtSqft
            // 
            this.txtSqft.Location = new System.Drawing.Point(132, 120);
            this.txtSqft.Name = "txtSqft";
            this.txtSqft.Size = new System.Drawing.Size(167, 20);
            this.txtSqft.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Square Footage";
            // 
            // cmbPropType
            // 
            this.cmbPropType.FormattingEnabled = true;
            this.cmbPropType.Items.AddRange(new object[] {
            "Single Family Home",
            "Apartment or Townhome",
            "Land / Acreage"});
            this.cmbPropType.Location = new System.Drawing.Point(132, 21);
            this.cmbPropType.Name = "cmbPropType";
            this.cmbPropType.Size = new System.Drawing.Size(166, 21);
            this.cmbPropType.TabIndex = 18;
            // 
            // cmbBeds
            // 
            this.cmbBeds.FormattingEnabled = true;
            this.cmbBeds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6+"});
            this.cmbBeds.Location = new System.Drawing.Point(133, 54);
            this.cmbBeds.Name = "cmbBeds";
            this.cmbBeds.Size = new System.Drawing.Size(166, 21);
            this.cmbBeds.TabIndex = 19;
            // 
            // cmbBaths
            // 
            this.cmbBaths.FormattingEnabled = true;
            this.cmbBaths.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5+"});
            this.cmbBaths.Location = new System.Drawing.Point(132, 87);
            this.cmbBaths.Name = "cmbBaths";
            this.cmbBaths.Size = new System.Drawing.Size(166, 21);
            this.cmbBaths.TabIndex = 20;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(125, 156);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(89, 21);
            this.btnSaveExit.TabIndex = 21;
            this.btnSaveExit.Text = "Save and Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // AddHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 197);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.cmbBaths);
            this.Controls.Add(this.cmbBeds);
            this.Controls.Add(this.cmbPropType);
            this.Controls.Add(this.txtSqft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHouse";
            this.Text = "AddHouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSqft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPropType;
        private System.Windows.Forms.ComboBox cmbBeds;
        private System.Windows.Forms.ComboBox cmbBaths;
        private System.Windows.Forms.Button btnSaveExit;
    }
}