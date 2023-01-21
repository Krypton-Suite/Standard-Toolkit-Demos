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
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonMonthCalendar1 = new Krypton.Toolkit.KryptonMonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPropertyGrid1
            // 
            this.kryptonPropertyGrid1.CategoryForeColor = System.Drawing.Color.White;
            this.kryptonPropertyGrid1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonPropertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.kryptonPropertyGrid1.HelpForeColor = System.Drawing.Color.White;
            this.kryptonPropertyGrid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.kryptonPropertyGrid1.Location = new System.Drawing.Point(13, 13);
            this.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            this.kryptonPropertyGrid1.Size = new System.Drawing.Size(356, 408);
            this.kryptonPropertyGrid1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 428);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Theme:";
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.CornerRoundingRadius = -1F;
            this.kryptonThemeComboBox1.DropDownWidth = 296;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(73, 428);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(296, 21);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 2;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.CustomUACShieldSize = new System.Drawing.Size(16, 16);
            this.kryptonButton1.Location = new System.Drawing.Point(411, 13);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 3;
            this.kryptonButton1.UACShieldIconSize = Krypton.Toolkit.UACShieldIconSize.ExtraSmall;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "Click Me";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(521, 13);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(70, 20);
            this.kryptonCheckBox1.TabIndex = 4;
            this.kryptonCheckBox1.Values.Text = "Click Me";
            this.kryptonCheckBox1.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // kryptonCheckedListBox1
            // 
            this.kryptonCheckedListBox1.CornerRoundingRadius = -1F;
            this.kryptonCheckedListBox1.ItemCornerRoundingRadius = -1F;
            this.kryptonCheckedListBox1.Location = new System.Drawing.Point(411, 45);
            this.kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            this.kryptonCheckedListBox1.Size = new System.Drawing.Size(120, 96);
            this.kryptonCheckedListBox1.TabIndex = 5;
            this.kryptonCheckedListBox1.Click += new System.EventHandler(this.kryptonCheckedListBox1_Click);
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.CornerRoundingRadius = -1F;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(538, 45);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(170, 21);
            this.kryptonDateTimePicker1.TabIndex = 6;
            this.kryptonDateTimePicker1.Click += new System.EventHandler(this.kryptonDateTimePicker1_Click);
            // 
            // kryptonMonthCalendar1
            // 
            this.kryptonMonthCalendar1.Location = new System.Drawing.Point(538, 73);
            this.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            this.kryptonMonthCalendar1.Size = new System.Drawing.Size(230, 184);
            this.kryptonMonthCalendar1.TabIndex = 7;
            this.kryptonMonthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kryptonMonthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(643, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kryptonMonthCalendar1);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.kryptonCheckedListBox1);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonThemeComboBox1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonPropertyGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Krypton Property Grid Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
    }
}