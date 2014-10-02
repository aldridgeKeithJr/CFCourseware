namespace WombatsAndKangaroos
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
            this.btnAddCreature = new System.Windows.Forms.Button();
            this.btnViewRemoveCreature = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreatureTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCreature
            // 
            this.btnAddCreature.Enabled = false;
            this.btnAddCreature.Location = new System.Drawing.Point(50, 21);
            this.btnAddCreature.Name = "btnAddCreature";
            this.btnAddCreature.Size = new System.Drawing.Size(193, 29);
            this.btnAddCreature.TabIndex = 0;
            this.btnAddCreature.Text = "Add a Creature";
            this.btnAddCreature.UseVisualStyleBackColor = true;
            this.btnAddCreature.Click += new System.EventHandler(this.btnAddCreature_Click);
            // 
            // btnViewRemoveCreature
            // 
            this.btnViewRemoveCreature.Enabled = false;
            this.btnViewRemoveCreature.Location = new System.Drawing.Point(50, 63);
            this.btnViewRemoveCreature.Name = "btnViewRemoveCreature";
            this.btnViewRemoveCreature.Size = new System.Drawing.Size(193, 29);
            this.btnViewRemoveCreature.TabIndex = 1;
            this.btnViewRemoveCreature.Text = "View / Remove Creatures";
            this.btnViewRemoveCreature.UseVisualStyleBackColor = true;
            this.btnViewRemoveCreature.Click += new System.EventHandler(this.btnViewRemoveCreature_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreatureTypes
            // 
            this.btnCreatureTypes.Location = new System.Drawing.Point(50, 105);
            this.btnCreatureTypes.Name = "btnCreatureTypes";
            this.btnCreatureTypes.Size = new System.Drawing.Size(193, 29);
            this.btnCreatureTypes.TabIndex = 5;
            this.btnCreatureTypes.Text = "Creature Types";
            this.btnCreatureTypes.UseVisualStyleBackColor = true;
            this.btnCreatureTypes.Click += new System.EventHandler(this.btnCreatureTypes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.btnCreatureTypes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewRemoveCreature);
            this.Controls.Add(this.btnAddCreature);
            this.Name = "Menu";
            this.Text = "Wombats and Kangaroos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCreature;
        private System.Windows.Forms.Button btnViewRemoveCreature;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreatureTypes;
    }
}

