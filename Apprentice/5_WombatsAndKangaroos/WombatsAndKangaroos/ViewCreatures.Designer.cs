namespace WombatsAndKangaroos
{
    partial class ViewCreatures
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.clbAllCreatures = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(162, 410);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // clbAllCreatures
            // 
            this.clbAllCreatures.CheckOnClick = true;
            this.clbAllCreatures.FormattingEnabled = true;
            this.clbAllCreatures.Location = new System.Drawing.Point(13, 14);
            this.clbAllCreatures.Name = "clbAllCreatures";
            this.clbAllCreatures.Size = new System.Drawing.Size(329, 379);
            this.clbAllCreatures.Sorted = true;
            this.clbAllCreatures.TabIndex = 5;
            // 
            // ViewCreatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 445);
            this.Controls.Add(this.clbAllCreatures);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Name = "ViewCreatures";
            this.Text = "ViewRemoveCreatures";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckedListBox clbAllCreatures;
    }
}