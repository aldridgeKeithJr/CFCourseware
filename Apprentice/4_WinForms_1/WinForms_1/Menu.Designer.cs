namespace WinForms_1
{
    partial class Menu
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnViewAllCars = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnViewAllHouses = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(52, 54);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(291, 35);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add a Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnViewAllCars
            // 
            this.btnViewAllCars.Location = new System.Drawing.Point(52, 95);
            this.btnViewAllCars.Name = "btnViewAllCars";
            this.btnViewAllCars.Size = new System.Drawing.Size(291, 35);
            this.btnViewAllCars.TabIndex = 2;
            this.btnViewAllCars.Text = "View / Remove Cars";
            this.btnViewAllCars.UseVisualStyleBackColor = true;
            this.btnViewAllCars.Click += new System.EventHandler(this.btnViewAllCars_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(52, 136);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(291, 35);
            this.btnAddHouse.TabIndex = 3;
            this.btnAddHouse.Text = "Add a House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnViewAllHouses
            // 
            this.btnViewAllHouses.Location = new System.Drawing.Point(52, 177);
            this.btnViewAllHouses.Name = "btnViewAllHouses";
            this.btnViewAllHouses.Size = new System.Drawing.Size(291, 35);
            this.btnViewAllHouses.TabIndex = 5;
            this.btnViewAllHouses.Text = "View / Remove Houses";
            this.btnViewAllHouses.UseVisualStyleBackColor = true;
            this.btnViewAllHouses.Click += new System.EventHandler(this.btnViewAllHouses_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(291, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 341);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewAllHouses);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.btnViewAllCars);
            this.Controls.Add(this.btnAddCar);
            this.Name = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnViewAllCars;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnViewAllHouses;
        private System.Windows.Forms.Button btnExit;
    }
}

