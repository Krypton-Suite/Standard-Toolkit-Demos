namespace KryptonPropertyGridExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPropertyGrid1 = new Krypton.Toolkit.KryptonPropertyGrid();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonMonthCalendar1 = new Krypton.Toolkit.KryptonMonthCalendar();
            kryptonPropertyGrid2 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPropertyGrid1
            // 
            this.kryptonPropertyGrid1.Location = new System.Drawing.Point(17, 16);
            this.kryptonPropertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            this.kryptonPropertyGrid1.SelectedObject = this;
            this.kryptonPropertyGrid1.Size = new System.Drawing.Size(475, 502);
            this.kryptonPropertyGrid1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 527);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(65, 26);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Theme:";
            // 
            // kryptonThemeComboBox1
            // 
            kryptonThemeComboBox1.DisplayMember = "Key";
            kryptonThemeComboBox1.DropDownWidth = 296;
            kryptonThemeComboBox1.IntegralHeight = false;
            kryptonThemeComboBox1.Location = new System.Drawing.Point(97, 527);
            kryptonThemeComboBox1.Margin = new System.Windows.Forms.Padding(4);
            kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            kryptonThemeComboBox1.Size = new System.Drawing.Size(395, 25);
            kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox1.TabIndex = 2;
            kryptonThemeComboBox1.ValueMember = "Value";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new System.Drawing.Point(548, 16);
            kryptonButton1.Margin = new System.Windows.Forms.Padding(4);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(120, 31);
            kryptonButton1.TabIndex = 3;
            kryptonButton1.Values.Image = (System.Drawing.Image)resources.GetObject("kryptonButton1.Values.Image");
            kryptonButton1.Values.Text = "Click Me";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new System.Drawing.Point(548, 181);
            kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new System.Drawing.Size(83, 24);
            kryptonCheckBox1.TabIndex = 4;
            kryptonCheckBox1.Values.Text = "Click Me";
            kryptonCheckBox1.CheckedChanged += kryptonCheckBox1_CheckedChanged;
            // 
            // kryptonCheckedListBox1
            // 
            kryptonCheckedListBox1.Location = new System.Drawing.Point(548, 55);
            kryptonCheckedListBox1.Margin = new System.Windows.Forms.Padding(4);
            kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            kryptonCheckedListBox1.Size = new System.Drawing.Size(160, 118);
            kryptonCheckedListBox1.TabIndex = 5;
            kryptonCheckedListBox1.Click += kryptonCheckedListBox1_Click;
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Location = new System.Drawing.Point(717, 22);
            kryptonDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new System.Drawing.Size(227, 25);
            kryptonDateTimePicker1.TabIndex = 6;
            kryptonDateTimePicker1.Click += kryptonDateTimePicker1_Click;
            // 
            // kryptonMonthCalendar1
            // 
            kryptonMonthCalendar1.Location = new System.Drawing.Point(717, 55);
            kryptonMonthCalendar1.Margin = new System.Windows.Forms.Padding(4);
            kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            kryptonMonthCalendar1.Size = new System.Drawing.Size(293, 218);
            kryptonMonthCalendar1.TabIndex = 7;
            kryptonMonthCalendar1.DateChanged += kryptonMonthCalendar1_DateChanged;
            // 
            // kryptonPropertyGrid2
            // 
            this.kryptonPropertyGrid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kryptonPropertyGrid2.CategoryForeColor = System.Drawing.Color.White;
            this.kryptonPropertyGrid2.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPropertyGrid2.CommandsForeColor = System.Drawing.Color.Black;
            this.kryptonPropertyGrid2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonPropertyGrid2.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.kryptonPropertyGrid2.HelpForeColor = System.Drawing.Color.White;
            this.kryptonPropertyGrid2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.kryptonPropertyGrid2.Location = new System.Drawing.Point(500, 281);
            this.kryptonPropertyGrid2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPropertyGrid2.Name = "kryptonPropertyGrid2";
            this.kryptonPropertyGrid2.SelectedObject = this;
            this.kryptonPropertyGrid2.Size = new System.Drawing.Size(510, 291);
            this.kryptonPropertyGrid2.TabIndex = 9;
            this.kryptonPropertyGrid2.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPropertyGrid2.ViewForeColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.kryptonPropertyGrid2);
            this.Controls.Add(this.kryptonMonthCalendar1);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.kryptonCheckedListBox1);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.kryptonButton1);
            Controls.Add(kryptonThemeComboBox1);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonPropertyGrid1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Krypton Property Grid Example";
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPropertyGrid kryptonPropertyGrid1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
        private System.Windows.Forms.PropertyGrid kryptonPropertyGrid2;
    }
}