namespace Advanced_Sortring_Methods
{
    partial class Help_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Help_Label = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Help_Inscription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.Help_Label);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 542);
            this.panel1.TabIndex = 1;
            // 
            // Help_Label
            // 
            this.Help_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help_Label.Location = new System.Drawing.Point(0, 21);
            this.Help_Label.Name = "Help_Label";
            this.Help_Label.Size = new System.Drawing.Size(984, 521);
            this.Help_Label.TabIndex = 0;
            this.Help_Label.Text = resources.GetString("Help_Label.Text");
            this.Help_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Back_Button
            // 
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Button.FlatAppearance.BorderSize = 3;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(12, 17);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(114, 52);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Help_Inscription
            // 
            this.Help_Inscription.AutoSize = true;
            this.Help_Inscription.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Help_Inscription.Location = new System.Drawing.Point(440, 3);
            this.Help_Inscription.Name = "Help_Inscription";
            this.Help_Inscription.Size = new System.Drawing.Size(135, 65);
            this.Help_Inscription.TabIndex = 6;
            this.Help_Inscription.Text = "Help";
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1011, 632);
            this.Controls.Add(this.Help_Inscription);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Sort Methods";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Help_Form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Help_Label;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label Help_Inscription;
    }
}