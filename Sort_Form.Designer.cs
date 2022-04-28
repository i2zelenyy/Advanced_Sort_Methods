namespace Advanced_Sortring_Methods
{
    partial class Sort_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sort_Form));
            this.Back_Button = new System.Windows.Forms.Button();
            this.Sort_Inscription = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Comparisons_label_4 = new System.Windows.Forms.Label();
            this.Comparisons_label_3 = new System.Windows.Forms.Label();
            this.Comparisons_label_1 = new System.Windows.Forms.Label();
            this.Comparisons_label_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Swaps_label_4 = new System.Windows.Forms.Label();
            this.Swaps_label_3 = new System.Windows.Forms.Label();
            this.Swaps_label_1 = new System.Windows.Forms.Label();
            this.Swaps_label_2 = new System.Windows.Forms.Label();
            this.Complexity_label_4 = new System.Windows.Forms.Label();
            this.Complexity_label_3 = new System.Windows.Forms.Label();
            this.Complexity_label_1 = new System.Windows.Forms.Label();
            this.Complexity_label_2 = new System.Windows.Forms.Label();
            this.Generate_button = new System.Windows.Forms.Button();
            this.Sort_button = new System.Windows.Forms.Button();
            this.Length_label = new System.Windows.Forms.Label();
            this.Array_Sorted_label = new System.Windows.Forms.Label();
            this.Sorted_Array_View = new System.Windows.Forms.DataGridView();
            this.Array_label = new System.Windows.Forms.Label();
            this.Origin_Array_View = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Array_Length_label = new System.Windows.Forms.Label();
            this.Ten_Thousand_Length_button = new System.Windows.Forms.Button();
            this.Thousand_Length_button = new System.Windows.Forms.Button();
            this.Hundred_Length_button = new System.Windows.Forms.Button();
            this.Ten_Length_button = new System.Windows.Forms.Button();
            this.Time_label_4 = new System.Windows.Forms.Label();
            this.Time_label_3 = new System.Windows.Forms.Label();
            this.Time_label_1 = new System.Windows.Forms.Label();
            this.Time_label_2 = new System.Windows.Forms.Label();
            this.Insertion_sort_inscription = new System.Windows.Forms.Label();
            this.Bubble_sort_label = new System.Windows.Forms.Label();
            this.Quicksort_label = new System.Windows.Forms.Label();
            this.Shellsort_label = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sorted_Array_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Origin_Array_View)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Button.FlatAppearance.BorderSize = 3;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(16, 19);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(114, 52);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Sort_Inscription
            // 
            this.Sort_Inscription.AutoSize = true;
            this.Sort_Inscription.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Sort_Inscription.Location = new System.Drawing.Point(485, 9);
            this.Sort_Inscription.Name = "Sort_Inscription";
            this.Sort_Inscription.Size = new System.Drawing.Size(123, 65);
            this.Sort_Inscription.TabIndex = 7;
            this.Sort_Inscription.Text = "Sort";
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.LemonChiffon;
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_panel.Controls.Add(this.Comparisons_label_4);
            this.main_panel.Controls.Add(this.Comparisons_label_3);
            this.main_panel.Controls.Add(this.Comparisons_label_1);
            this.main_panel.Controls.Add(this.Comparisons_label_2);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.Swaps_label_4);
            this.main_panel.Controls.Add(this.Swaps_label_3);
            this.main_panel.Controls.Add(this.Swaps_label_1);
            this.main_panel.Controls.Add(this.Swaps_label_2);
            this.main_panel.Controls.Add(this.Complexity_label_4);
            this.main_panel.Controls.Add(this.Complexity_label_3);
            this.main_panel.Controls.Add(this.Complexity_label_1);
            this.main_panel.Controls.Add(this.Complexity_label_2);
            this.main_panel.Controls.Add(this.Generate_button);
            this.main_panel.Controls.Add(this.Sort_button);
            this.main_panel.Controls.Add(this.Length_label);
            this.main_panel.Controls.Add(this.Array_Sorted_label);
            this.main_panel.Controls.Add(this.Sorted_Array_View);
            this.main_panel.Controls.Add(this.Array_label);
            this.main_panel.Controls.Add(this.Origin_Array_View);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.Time_label_4);
            this.main_panel.Controls.Add(this.Time_label_3);
            this.main_panel.Controls.Add(this.Time_label_1);
            this.main_panel.Controls.Add(this.Time_label_2);
            this.main_panel.Controls.Add(this.Insertion_sort_inscription);
            this.main_panel.Controls.Add(this.Bubble_sort_label);
            this.main_panel.Controls.Add(this.Quicksort_label);
            this.main_panel.Controls.Add(this.Shellsort_label);
            this.main_panel.Location = new System.Drawing.Point(12, 77);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1229, 551);
            this.main_panel.TabIndex = 8;
            // 
            // Comparisons_label_4
            // 
            this.Comparisons_label_4.AutoSize = true;
            this.Comparisons_label_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comparisons_label_4.Location = new System.Drawing.Point(781, 485);
            this.Comparisons_label_4.Name = "Comparisons_label_4";
            this.Comparisons_label_4.Size = new System.Drawing.Size(126, 25);
            this.Comparisons_label_4.TabIndex = 35;
            this.Comparisons_label_4.Text = "Comparisons:";
            // 
            // Comparisons_label_3
            // 
            this.Comparisons_label_3.AutoSize = true;
            this.Comparisons_label_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comparisons_label_3.Location = new System.Drawing.Point(781, 383);
            this.Comparisons_label_3.Name = "Comparisons_label_3";
            this.Comparisons_label_3.Size = new System.Drawing.Size(126, 25);
            this.Comparisons_label_3.TabIndex = 34;
            this.Comparisons_label_3.Text = "Comparisons:";
            // 
            // Comparisons_label_1
            // 
            this.Comparisons_label_1.AutoSize = true;
            this.Comparisons_label_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comparisons_label_1.Location = new System.Drawing.Point(782, 172);
            this.Comparisons_label_1.Name = "Comparisons_label_1";
            this.Comparisons_label_1.Size = new System.Drawing.Size(126, 25);
            this.Comparisons_label_1.TabIndex = 33;
            this.Comparisons_label_1.Text = "Comparisons:";
            // 
            // Comparisons_label_2
            // 
            this.Comparisons_label_2.AutoSize = true;
            this.Comparisons_label_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comparisons_label_2.Location = new System.Drawing.Point(782, 277);
            this.Comparisons_label_2.Name = "Comparisons_label_2";
            this.Comparisons_label_2.Size = new System.Drawing.Size(126, 25);
            this.Comparisons_label_2.TabIndex = 32;
            this.Comparisons_label_2.Text = "Comparisons:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1018, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 108);
            this.label1.TabIndex = 31;
            this.label1.Text = "Maximum displayed array length is 50 elements";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Swaps_label_4
            // 
            this.Swaps_label_4.AutoSize = true;
            this.Swaps_label_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Swaps_label_4.Location = new System.Drawing.Point(556, 486);
            this.Swaps_label_4.Name = "Swaps_label_4";
            this.Swaps_label_4.Size = new System.Drawing.Size(69, 25);
            this.Swaps_label_4.TabIndex = 30;
            this.Swaps_label_4.Text = "Swaps:";
            // 
            // Swaps_label_3
            // 
            this.Swaps_label_3.AutoSize = true;
            this.Swaps_label_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Swaps_label_3.Location = new System.Drawing.Point(556, 383);
            this.Swaps_label_3.Name = "Swaps_label_3";
            this.Swaps_label_3.Size = new System.Drawing.Size(69, 25);
            this.Swaps_label_3.TabIndex = 29;
            this.Swaps_label_3.Text = "Swaps:";
            // 
            // Swaps_label_1
            // 
            this.Swaps_label_1.AutoSize = true;
            this.Swaps_label_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Swaps_label_1.Location = new System.Drawing.Point(557, 171);
            this.Swaps_label_1.Name = "Swaps_label_1";
            this.Swaps_label_1.Size = new System.Drawing.Size(69, 25);
            this.Swaps_label_1.TabIndex = 28;
            this.Swaps_label_1.Text = "Swaps:";
            // 
            // Swaps_label_2
            // 
            this.Swaps_label_2.AutoSize = true;
            this.Swaps_label_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Swaps_label_2.Location = new System.Drawing.Point(557, 275);
            this.Swaps_label_2.Name = "Swaps_label_2";
            this.Swaps_label_2.Size = new System.Drawing.Size(69, 25);
            this.Swaps_label_2.TabIndex = 27;
            this.Swaps_label_2.Text = "Swaps:";
            // 
            // Complexity_label_4
            // 
            this.Complexity_label_4.AutoSize = true;
            this.Complexity_label_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Complexity_label_4.Location = new System.Drawing.Point(155, 486);
            this.Complexity_label_4.Name = "Complexity_label_4";
            this.Complexity_label_4.Size = new System.Drawing.Size(110, 25);
            this.Complexity_label_4.TabIndex = 26;
            this.Complexity_label_4.Text = "Complexity:";
            // 
            // Complexity_label_3
            // 
            this.Complexity_label_3.AutoSize = true;
            this.Complexity_label_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Complexity_label_3.Location = new System.Drawing.Point(155, 383);
            this.Complexity_label_3.Name = "Complexity_label_3";
            this.Complexity_label_3.Size = new System.Drawing.Size(110, 25);
            this.Complexity_label_3.TabIndex = 25;
            this.Complexity_label_3.Text = "Complexity:";
            // 
            // Complexity_label_1
            // 
            this.Complexity_label_1.AutoSize = true;
            this.Complexity_label_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Complexity_label_1.Location = new System.Drawing.Point(156, 171);
            this.Complexity_label_1.Name = "Complexity_label_1";
            this.Complexity_label_1.Size = new System.Drawing.Size(110, 25);
            this.Complexity_label_1.TabIndex = 24;
            this.Complexity_label_1.Text = "Complexity:";
            // 
            // Complexity_label_2
            // 
            this.Complexity_label_2.AutoSize = true;
            this.Complexity_label_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Complexity_label_2.Location = new System.Drawing.Point(156, 275);
            this.Complexity_label_2.Name = "Complexity_label_2";
            this.Complexity_label_2.Size = new System.Drawing.Size(110, 25);
            this.Complexity_label_2.TabIndex = 23;
            this.Complexity_label_2.Text = "Complexity:";
            // 
            // Generate_button
            // 
            this.Generate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate_button.Enabled = false;
            this.Generate_button.FlatAppearance.BorderSize = 3;
            this.Generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate_button.Location = new System.Drawing.Point(1027, 67);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(197, 52);
            this.Generate_button.TabIndex = 22;
            this.Generate_button.Text = "Generate";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // Sort_button
            // 
            this.Sort_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_button.Enabled = false;
            this.Sort_button.FlatAppearance.BorderSize = 3;
            this.Sort_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_button.Location = new System.Drawing.Point(1027, 125);
            this.Sort_button.Name = "Sort_button";
            this.Sort_button.Size = new System.Drawing.Size(197, 52);
            this.Sort_button.TabIndex = 21;
            this.Sort_button.Text = "Sort";
            this.Sort_button.UseVisualStyleBackColor = true;
            this.Sort_button.Click += new System.EventHandler(this.Sort_button_Click);
            // 
            // Length_label
            // 
            this.Length_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Length_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length_label.Location = new System.Drawing.Point(1018, -1);
            this.Length_label.Name = "Length_label";
            this.Length_label.Size = new System.Drawing.Size(210, 289);
            this.Length_label.TabIndex = 21;
            this.Length_label.Text = "Current Length: not given";
            this.Length_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Array_Sorted_label
            // 
            this.Array_Sorted_label.AutoSize = true;
            this.Array_Sorted_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array_Sorted_label.Location = new System.Drawing.Point(672, 5);
            this.Array_Sorted_label.Name = "Array_Sorted_label";
            this.Array_Sorted_label.Size = new System.Drawing.Size(146, 32);
            this.Array_Sorted_label.TabIndex = 21;
            this.Array_Sorted_label.Text = "Sorted Array";
            // 
            // Sorted_Array_View
            // 
            this.Sorted_Array_View.AllowUserToAddRows = false;
            this.Sorted_Array_View.AllowUserToDeleteRows = false;
            this.Sorted_Array_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Sorted_Array_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Sorted_Array_View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Sorted_Array_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sorted_Array_View.ColumnHeadersVisible = false;
            this.Sorted_Array_View.GridColor = System.Drawing.SystemColors.Control;
            this.Sorted_Array_View.Location = new System.Drawing.Point(586, 40);
            this.Sorted_Array_View.Name = "Sorted_Array_View";
            this.Sorted_Array_View.ReadOnly = true;
            this.Sorted_Array_View.Size = new System.Drawing.Size(306, 62);
            this.Sorted_Array_View.TabIndex = 20;
            // 
            // Array_label
            // 
            this.Array_label.AutoSize = true;
            this.Array_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array_label.Location = new System.Drawing.Point(226, 5);
            this.Array_label.Name = "Array_label";
            this.Array_label.Size = new System.Drawing.Size(187, 32);
            this.Array_label.TabIndex = 19;
            this.Array_label.Text = "Generated Array";
            // 
            // Origin_Array_View
            // 
            this.Origin_Array_View.AllowUserToAddRows = false;
            this.Origin_Array_View.AllowUserToDeleteRows = false;
            this.Origin_Array_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Origin_Array_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Origin_Array_View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Origin_Array_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Origin_Array_View.ColumnHeadersVisible = false;
            this.Origin_Array_View.GridColor = System.Drawing.SystemColors.Control;
            this.Origin_Array_View.Location = new System.Drawing.Point(161, 40);
            this.Origin_Array_View.Name = "Origin_Array_View";
            this.Origin_Array_View.ReadOnly = true;
            this.Origin_Array_View.Size = new System.Drawing.Size(306, 62);
            this.Origin_Array_View.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Array_Length_label);
            this.panel2.Controls.Add(this.Ten_Thousand_Length_button);
            this.panel2.Controls.Add(this.Thousand_Length_button);
            this.panel2.Controls.Add(this.Hundred_Length_button);
            this.panel2.Controls.Add(this.Ten_Length_button);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 543);
            this.panel2.TabIndex = 17;
            // 
            // Array_Length_label
            // 
            this.Array_Length_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Array_Length_label.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array_Length_label.Location = new System.Drawing.Point(-1, -1);
            this.Array_Length_label.Name = "Array_Length_label";
            this.Array_Length_label.Size = new System.Drawing.Size(146, 127);
            this.Array_Length_label.TabIndex = 18;
            this.Array_Length_label.Text = "Array Length";
            this.Array_Length_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ten_Thousand_Length_button
            // 
            this.Ten_Thousand_Length_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ten_Thousand_Length_button.FlatAppearance.BorderSize = 3;
            this.Ten_Thousand_Length_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ten_Thousand_Length_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ten_Thousand_Length_button.Location = new System.Drawing.Point(14, 460);
            this.Ten_Thousand_Length_button.Name = "Ten_Thousand_Length_button";
            this.Ten_Thousand_Length_button.Size = new System.Drawing.Size(114, 52);
            this.Ten_Thousand_Length_button.TabIndex = 20;
            this.Ten_Thousand_Length_button.Text = "10000";
            this.Ten_Thousand_Length_button.UseVisualStyleBackColor = true;
            this.Ten_Thousand_Length_button.Click += new System.EventHandler(this.Ten_Thousand_Length_button_Click);
            // 
            // Thousand_Length_button
            // 
            this.Thousand_Length_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thousand_Length_button.FlatAppearance.BorderSize = 3;
            this.Thousand_Length_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thousand_Length_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Thousand_Length_button.Location = new System.Drawing.Point(14, 352);
            this.Thousand_Length_button.Name = "Thousand_Length_button";
            this.Thousand_Length_button.Size = new System.Drawing.Size(114, 52);
            this.Thousand_Length_button.TabIndex = 19;
            this.Thousand_Length_button.Text = "1000";
            this.Thousand_Length_button.UseVisualStyleBackColor = true;
            this.Thousand_Length_button.Click += new System.EventHandler(this.Thousand_Length_button_Click);
            // 
            // Hundred_Length_button
            // 
            this.Hundred_Length_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hundred_Length_button.FlatAppearance.BorderSize = 3;
            this.Hundred_Length_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hundred_Length_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hundred_Length_button.Location = new System.Drawing.Point(14, 244);
            this.Hundred_Length_button.Name = "Hundred_Length_button";
            this.Hundred_Length_button.Size = new System.Drawing.Size(114, 52);
            this.Hundred_Length_button.TabIndex = 18;
            this.Hundred_Length_button.Text = "100";
            this.Hundred_Length_button.UseVisualStyleBackColor = true;
            this.Hundred_Length_button.Click += new System.EventHandler(this.Hundred_Length_button_Click);
            // 
            // Ten_Length_button
            // 
            this.Ten_Length_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ten_Length_button.FlatAppearance.BorderSize = 3;
            this.Ten_Length_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ten_Length_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ten_Length_button.Location = new System.Drawing.Point(14, 149);
            this.Ten_Length_button.Name = "Ten_Length_button";
            this.Ten_Length_button.Size = new System.Drawing.Size(114, 52);
            this.Ten_Length_button.TabIndex = 9;
            this.Ten_Length_button.Text = "10";
            this.Ten_Length_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Ten_Length_button.UseVisualStyleBackColor = true;
            this.Ten_Length_button.Click += new System.EventHandler(this.Ten_Length_button_Click);
            // 
            // Time_label_4
            // 
            this.Time_label_4.AutoSize = true;
            this.Time_label_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label_4.Location = new System.Drawing.Point(391, 486);
            this.Time_label_4.Name = "Time_label_4";
            this.Time_label_4.Size = new System.Drawing.Size(57, 25);
            this.Time_label_4.TabIndex = 16;
            this.Time_label_4.Text = "Time:";
            // 
            // Time_label_3
            // 
            this.Time_label_3.AutoSize = true;
            this.Time_label_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label_3.Location = new System.Drawing.Point(391, 383);
            this.Time_label_3.Name = "Time_label_3";
            this.Time_label_3.Size = new System.Drawing.Size(57, 25);
            this.Time_label_3.TabIndex = 15;
            this.Time_label_3.Text = "Time:";
            // 
            // Time_label_1
            // 
            this.Time_label_1.AutoSize = true;
            this.Time_label_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label_1.Location = new System.Drawing.Point(392, 171);
            this.Time_label_1.Name = "Time_label_1";
            this.Time_label_1.Size = new System.Drawing.Size(57, 25);
            this.Time_label_1.TabIndex = 14;
            this.Time_label_1.Text = "Time:";
            // 
            // Time_label_2
            // 
            this.Time_label_2.AutoSize = true;
            this.Time_label_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label_2.Location = new System.Drawing.Point(392, 275);
            this.Time_label_2.Name = "Time_label_2";
            this.Time_label_2.Size = new System.Drawing.Size(57, 25);
            this.Time_label_2.TabIndex = 13;
            this.Time_label_2.Text = "Time:";
            // 
            // Insertion_sort_inscription
            // 
            this.Insertion_sort_inscription.AutoSize = true;
            this.Insertion_sort_inscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Insertion_sort_inscription.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insertion_sort_inscription.Location = new System.Drawing.Point(454, 434);
            this.Insertion_sort_inscription.Name = "Insertion_sort_inscription";
            this.Insertion_sort_inscription.Size = new System.Drawing.Size(159, 34);
            this.Insertion_sort_inscription.TabIndex = 12;
            this.Insertion_sort_inscription.Text = "Insertion Sort";
            // 
            // Bubble_sort_label
            // 
            this.Bubble_sort_label.AutoSize = true;
            this.Bubble_sort_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bubble_sort_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bubble_sort_label.Location = new System.Drawing.Point(464, 326);
            this.Bubble_sort_label.Name = "Bubble_sort_label";
            this.Bubble_sort_label.Size = new System.Drawing.Size(141, 34);
            this.Bubble_sort_label.TabIndex = 11;
            this.Bubble_sort_label.Text = "Bubble Sort";
            // 
            // Quicksort_label
            // 
            this.Quicksort_label.AutoSize = true;
            this.Quicksort_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quicksort_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quicksort_label.Location = new System.Drawing.Point(467, 109);
            this.Quicksort_label.Name = "Quicksort_label";
            this.Quicksort_label.Size = new System.Drawing.Size(127, 34);
            this.Quicksort_label.TabIndex = 10;
            this.Quicksort_label.Text = "Quick Sort";
            // 
            // Shellsort_label
            // 
            this.Shellsort_label.AutoSize = true;
            this.Shellsort_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Shellsort_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shellsort_label.Location = new System.Drawing.Point(472, 221);
            this.Shellsort_label.Name = "Shellsort_label";
            this.Shellsort_label.Size = new System.Drawing.Size(118, 34);
            this.Shellsort_label.TabIndex = 9;
            this.Shellsort_label.Text = "Shell Sort";
            // 
            // Sort_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1253, 640);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Sort_Inscription);
            this.Controls.Add(this.Back_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sort_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Sort Methods";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sort_Form_FormClosed);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sorted_Array_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Origin_Array_View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label Sort_Inscription;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label Shellsort_label;
        private System.Windows.Forms.Label Swaps_label_4;
        private System.Windows.Forms.Label Swaps_label_3;
        private System.Windows.Forms.Label Swaps_label_1;
        private System.Windows.Forms.Label Swaps_label_2;
        private System.Windows.Forms.Label Complexity_label_4;
        private System.Windows.Forms.Label Complexity_label_3;
        private System.Windows.Forms.Label Complexity_label_1;
        private System.Windows.Forms.Label Complexity_label_2;
        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.Button Sort_button;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.Label Array_Sorted_label;
        private System.Windows.Forms.DataGridView Sorted_Array_View;
        private System.Windows.Forms.Label Array_label;
        private System.Windows.Forms.DataGridView Origin_Array_View;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Array_Length_label;
        private System.Windows.Forms.Button Ten_Thousand_Length_button;
        private System.Windows.Forms.Button Thousand_Length_button;
        private System.Windows.Forms.Button Hundred_Length_button;
        private System.Windows.Forms.Button Ten_Length_button;
        private System.Windows.Forms.Label Time_label_4;
        private System.Windows.Forms.Label Time_label_3;
        private System.Windows.Forms.Label Time_label_1;
        private System.Windows.Forms.Label Time_label_2;
        private System.Windows.Forms.Label Insertion_sort_inscription;
        private System.Windows.Forms.Label Bubble_sort_label;
        private System.Windows.Forms.Label Quicksort_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Comparisons_label_4;
        private System.Windows.Forms.Label Comparisons_label_3;
        private System.Windows.Forms.Label Comparisons_label_1;
        private System.Windows.Forms.Label Comparisons_label_2;
    }
}