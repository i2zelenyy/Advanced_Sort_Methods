namespace Advanced_Sortring_Methods
{
    partial class About_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.About_Label = new System.Windows.Forms.Label();
            this.About_Inscription = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.About_Label);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 322);
            this.panel1.TabIndex = 2;
            // 
            // About_Label
            // 
            this.About_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_Label.Location = new System.Drawing.Point(89, 0);
            this.About_Label.Name = "About_Label";
            this.About_Label.Size = new System.Drawing.Size(222, 321);
            this.About_Label.TabIndex = 0;
            this.About_Label.Text = "__________________________\r\nCourse Paper\r\n\r\nAdvanced Sort Methods\r\n\r\nMade by Ivan" +
    " Zelenyy\r\nStudent of IT1903 Group\r\n\r\n4th Semester\r\nat KubSAU\r\n__________________" +
    "________";
            this.About_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About_Inscription
            // 
            this.About_Inscription.AutoSize = true;
            this.About_Inscription.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.About_Inscription.Location = new System.Drawing.Point(132, 6);
            this.About_Inscription.Name = "About_Inscription";
            this.About_Inscription.Size = new System.Drawing.Size(169, 65);
            this.About_Inscription.TabIndex = 7;
            this.About_Inscription.Text = "About";
            // 
            // Back_Button
            // 
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Button.FlatAppearance.BorderSize = 3;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(12, 19);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(114, 52);
            this.Back_Button.TabIndex = 8;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // About_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(415, 407);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.About_Inscription);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Sort Methods";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_Form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label About_Label;
        private System.Windows.Forms.Label About_Inscription;
        private System.Windows.Forms.Button Back_Button;
    }
}