
namespace KryptonPropertyGridExamples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.ktxtTest = new Krypton.Toolkit.KryptonTextBox();
            this.kdbtnTest = new Krypton.Toolkit.KryptonDropButton();
            this.kcmbTest = new Krypton.Toolkit.KryptonComboBox();
            this.kcbtnTest = new Krypton.Toolkit.KryptonColorButton();
            this.kcbTest = new Krypton.Toolkit.KryptonCheckBox();
            this.kbtnTest = new Krypton.Toolkit.KryptonButton();
            this.kpg = new Krypton.Toolkit.KryptonPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ktxtTest);
            this.kryptonPanel1.Controls.Add(this.kdbtnTest);
            this.kryptonPanel1.Controls.Add(this.kcmbTest);
            this.kryptonPanel1.Controls.Add(this.kcbtnTest);
            this.kryptonPanel1.Controls.Add(this.kcbTest);
            this.kryptonPanel1.Controls.Add(this.kbtnTest);
            this.kryptonPanel1.Controls.Add(this.kpg);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(857, 633);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ktxtTest
            // 
            this.ktxtTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktxtTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktxtTest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ktxtTest.Location = new System.Drawing.Point(13, 188);
            this.ktxtTest.Name = "ktxtTest";
            this.ktxtTest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktxtTest.Size = new System.Drawing.Size(349, 23);
            this.ktxtTest.TabIndex = 8;
            this.ktxtTest.Text = "kryptonTextBox1";
            this.ktxtTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ktxtTest.Click += new System.EventHandler(this.ktxtTest_Click);
            // 
            // kdbtnTest
            // 
            this.kdbtnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kdbtnTest.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kdbtnTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kdbtnTest.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kdbtnTest.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.kdbtnTest.Location = new System.Drawing.Point(13, 131);
            this.kdbtnTest.Name = "kdbtnTest";
            this.kdbtnTest.Size = new System.Drawing.Size(176, 25);
            this.kdbtnTest.TabIndex = 5;
            this.kdbtnTest.Values.Text = "kryptonDropButton1";
            this.kdbtnTest.Click += new System.EventHandler(this.kdbtnTest_Click);
            // 
            // kcmbTest
            // 
            this.kcmbTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kcmbTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kcmbTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kcmbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kcmbTest.DropDownWidth = 144;
            this.kcmbTest.IntegralHeight = false;
            this.kcmbTest.Location = new System.Drawing.Point(218, 75);
            this.kcmbTest.Name = "kcmbTest";
            this.kcmbTest.Size = new System.Drawing.Size(144, 21);
            this.kcmbTest.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbTest.TabIndex = 4;
            this.kcmbTest.Text = "kryptonComboBox1";
            this.kcmbTest.Click += new System.EventHandler(this.kcmbTest_Click);
            // 
            // kcbtnTest
            // 
            this.kcbtnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kcbtnTest.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kcbtnTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kcbtnTest.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kcbtnTest.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.kcbtnTest.EmptyBorderColor = System.Drawing.Color.DarkGray;
            this.kcbtnTest.Location = new System.Drawing.Point(13, 75);
            this.kcbtnTest.Name = "kcbtnTest";
            this.kcbtnTest.SchemeStandard = Krypton.Toolkit.ColorScheme.OfficeStandard;
            this.kcbtnTest.SchemeThemes = Krypton.Toolkit.ColorScheme.OfficeThemes;
            this.kcbtnTest.SelectedColor = System.Drawing.Color.Red;
            this.kcbtnTest.SelectedRect = new System.Drawing.Rectangle(0, 12, 16, 4);
            this.kcbtnTest.Size = new System.Drawing.Size(176, 25);
            this.kcbtnTest.TabIndex = 3;
            this.kcbtnTest.Values.Text = "kryptonColorButton1";
            this.kcbtnTest.SelectedColorChanged += new System.EventHandler<Krypton.Toolkit.ColorEventArgs>(this.kcbtnTest_SelectedColorChanged);
            this.kcbtnTest.Click += new System.EventHandler(this.kcbtnTest_Click);
            // 
            // kcbTest
            // 
            this.kcbTest.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.kcbTest.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kcbTest.Location = new System.Drawing.Point(218, 13);
            this.kcbTest.Name = "kcbTest";
            this.kcbTest.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kcbTest.Size = new System.Drawing.Size(125, 20);
            this.kcbTest.TabIndex = 2;
            this.kcbTest.Values.Text = "kryptonCheckBox1";
            this.kcbTest.Click += new System.EventHandler(this.kcbTest_Click);
            // 
            // kbtnTest
            // 
            this.kbtnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kbtnTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kbtnTest.Location = new System.Drawing.Point(13, 13);
            this.kbtnTest.Name = "kbtnTest";
            this.kbtnTest.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kbtnTest.Size = new System.Drawing.Size(132, 25);
            this.kbtnTest.TabIndex = 1;
            this.kbtnTest.Values.Text = "kryptonButton1";
            this.kbtnTest.Click += new System.EventHandler(this.kbtnTest_Click);
            // 
            // kpg
            // 
            this.kpg.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpg.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpg.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpg.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpg.Location = new System.Drawing.Point(548, 12);
            this.kpg.Name = "kpg";
            this.kpg.SelectedObject = ((object)(resources.GetObject("kpg.SelectedObject")));
            this.kpg.Size = new System.Drawing.Size(297, 609);
            this.kpg.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 633);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Krypton PropertyGrid Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox ktxtTest;
        private Krypton.Toolkit.KryptonDropButton kdbtnTest;
        private Krypton.Toolkit.KryptonComboBox kcmbTest;
        private Krypton.Toolkit.KryptonColorButton kcbtnTest;
        private Krypton.Toolkit.KryptonCheckBox kcbTest;
        private Krypton.Toolkit.KryptonButton kbtnTest;
        private Krypton.Toolkit.KryptonPropertyGrid kpg;
    }
}

