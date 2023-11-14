
namespace KryptonFolderBrowserDialog_Example_2019
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
            buttonFileOpenDialog = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonCheckBox2 = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            kryptonGroupBox1.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonFileOpenDialog
            // 
            buttonFileOpenDialog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonFileOpenDialog.Location = new System.Drawing.Point(264, 404);
            buttonFileOpenDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonFileOpenDialog.Name = "buttonFileOpenDialog";
            buttonFileOpenDialog.Size = new System.Drawing.Size(307, 74);
            buttonFileOpenDialog.TabIndex = 19;
            buttonFileOpenDialog.Values.Text = "Folder Browser Dialog";
            buttonFileOpenDialog.Click += ButtonShowFileDialog_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonThemeComboBox1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(kryptonGroupBox2);
            kryptonPanel1.Controls.Add(kryptonGroupBox1);
            kryptonPanel1.Controls.Add(buttonFileOpenDialog);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(594, 513);
            kryptonPanel1.TabIndex = 20;
            // 
            // kryptonThemeComboBox1
            // 
            kryptonThemeComboBox1.DisplayMember = "30";
            kryptonThemeComboBox1.DropDownWidth = 339;
            kryptonThemeComboBox1.IntegralHeight = false;
            kryptonThemeComboBox1.Location = new System.Drawing.Point(12, 73);
            kryptonThemeComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            kryptonThemeComboBox1.Size = new System.Drawing.Size(339, 25);
            kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox1.TabIndex = 25;
            kryptonThemeComboBox1.ValueMember = "30";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            kryptonLabel1.Location = new System.Drawing.Point(12, 35);
            kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(68, 24);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Target = kryptonThemeComboBox1;
            kryptonLabel1.Values.Text = "&Themes:";
            // 
            // kryptonGroupBox2
            // 
            kryptonGroupBox2.Location = new System.Drawing.Point(372, 35);
            kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonGroupBox2.Name = "kryptonGroupBox2";
            kryptonGroupBox2.Size = new System.Drawing.Size(199, 362);
            kryptonGroupBox2.TabIndex = 21;
            kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.Location = new System.Drawing.Point(12, 191);
            kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // 
            // 
            kryptonGroupBox1.Panel.Controls.Add(kryptonTextBox1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonNumericUpDown1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonButton1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonCheckBox1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonListBox1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonComboBox1);
            kryptonGroupBox1.Size = new System.Drawing.Size(348, 205);
            kryptonGroupBox1.TabIndex = 20;
            kryptonGroupBox1.Values.Heading = "Style to match:";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new System.Drawing.Point(156, 36);
            kryptonTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new System.Drawing.Size(134, 27);
            kryptonTextBox1.TabIndex = 6;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonNumericUpDown1
            // 
            kryptonNumericUpDown1.Location = new System.Drawing.Point(156, 122);
            kryptonNumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            kryptonNumericUpDown1.Size = new System.Drawing.Size(90, 26);
            kryptonNumericUpDown1.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new System.Drawing.Point(156, 82);
            kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(90, 31);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new System.Drawing.Point(156, 5);
            kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new System.Drawing.Size(152, 24);
            kryptonCheckBox1.TabIndex = 2;
            kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Items.AddRange(new object[] { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1" });
            kryptonListBox1.Location = new System.Drawing.Point(4, 36);
            kryptonListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            kryptonListBox1.Size = new System.Drawing.Size(120, 120);
            kryptonListBox1.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            kryptonComboBox1.DropDownWidth = 121;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Items.AddRange(new object[] { "Microsoft Sans Serif" });
            kryptonComboBox1.Location = new System.Drawing.Point(4, 5);
            kryptonComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new System.Drawing.Size(146, 25);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 0;
            kryptonComboBox1.Text = "Microsoft Sans Serif";
            // 
            // kryptonCheckBox2
            // 
            kryptonCheckBox2.Checked = true;
            kryptonCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            kryptonCheckBox2.Location = new System.Drawing.Point(4, 180);
            kryptonCheckBox2.Name = "kryptonCheckBox2";
            kryptonCheckBox2.Size = new System.Drawing.Size(143, 24);
            kryptonCheckBox2.TabIndex = 6;
            kryptonCheckBox2.Values.Text = "Restore Directory";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(594, 513);
            Controls.Add(kryptonPanel1);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Text = "KryptonFolderBrowserDialog Example";
            Controls.SetChildIndex(kryptonPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            kryptonGroupBox1.Panel.ResumeLayout(false);
            kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton buttonFileOpenDialog;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
    }
}

