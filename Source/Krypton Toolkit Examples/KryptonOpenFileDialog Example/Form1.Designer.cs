
namespace KryptonOpenFileDialog_Example_2019
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
            chkRestoreDirectory = new Krypton.Toolkit.KryptonCheckBox();
            chkReadOnlyChecked = new Krypton.Toolkit.KryptonCheckBox();
            chkMultiselect = new Krypton.Toolkit.KryptonCheckBox();
            chkDereferenceLinks = new Krypton.Toolkit.KryptonCheckBox();
            chkCheckPathExists = new Krypton.Toolkit.KryptonCheckBox();
            chkCheckFileExists = new Krypton.Toolkit.KryptonCheckBox();
            chkAddExtension = new Krypton.Toolkit.KryptonCheckBox();
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
            kryptonGroupBox2.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            kryptonGroupBox1.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonFileOpenDialog
            // 
            buttonFileOpenDialog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonFileOpenDialog.Location = new System.Drawing.Point(396, 505);
            buttonFileOpenDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonFileOpenDialog.Name = "buttonFileOpenDialog";
            buttonFileOpenDialog.Size = new System.Drawing.Size(460, 92);
            buttonFileOpenDialog.TabIndex = 19;
            buttonFileOpenDialog.Values.Text = "File Open Dialog";
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
            kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(891, 641);
            kryptonPanel1.TabIndex = 20;
            // 
            // kryptonThemeComboBox1
            // 
            kryptonThemeComboBox1.DisplayMember = "30";
            kryptonThemeComboBox1.DropDownWidth = 339;
            kryptonThemeComboBox1.IntegralHeight = false;
            kryptonThemeComboBox1.Location = new System.Drawing.Point(18, 91);
            kryptonThemeComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            kryptonThemeComboBox1.Size = new System.Drawing.Size(508, 37);
            kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox1.TabIndex = 25;
            kryptonThemeComboBox1.ValueMember = "30";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            kryptonLabel1.Location = new System.Drawing.Point(18, 44);
            kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(104, 37);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Target = kryptonThemeComboBox1;
            kryptonLabel1.Values.Text = "&Themes:";
            // 
            // kryptonGroupBox2
            // 
            kryptonGroupBox2.Location = new System.Drawing.Point(558, 44);
            kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // 
            // 
            kryptonGroupBox2.Panel.Controls.Add(chkRestoreDirectory);
            kryptonGroupBox2.Panel.Controls.Add(chkReadOnlyChecked);
            kryptonGroupBox2.Panel.Controls.Add(chkMultiselect);
            kryptonGroupBox2.Panel.Controls.Add(chkDereferenceLinks);
            kryptonGroupBox2.Panel.Controls.Add(chkCheckPathExists);
            kryptonGroupBox2.Panel.Controls.Add(chkCheckFileExists);
            kryptonGroupBox2.Panel.Controls.Add(chkAddExtension);
            kryptonGroupBox2.Size = new System.Drawing.Size(298, 452);
            kryptonGroupBox2.TabIndex = 21;
            kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // chkRestoreDirectory
            // 
            chkRestoreDirectory.Checked = true;
            chkRestoreDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            chkRestoreDirectory.Location = new System.Drawing.Point(6, 281);
            chkRestoreDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkRestoreDirectory.Name = "chkRestoreDirectory";
            chkRestoreDirectory.Size = new System.Drawing.Size(217, 37);
            chkRestoreDirectory.TabIndex = 6;
            chkRestoreDirectory.Values.Text = "Restore Directory";
            // 
            // chkReadOnlyChecked
            // 
            chkReadOnlyChecked.Location = new System.Drawing.Point(6, 234);
            chkReadOnlyChecked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkReadOnlyChecked.Name = "chkReadOnlyChecked";
            chkReadOnlyChecked.Size = new System.Drawing.Size(240, 37);
            chkReadOnlyChecked.TabIndex = 5;
            chkReadOnlyChecked.Values.Text = "Read Only Checked";
            // 
            // chkMultiselect
            // 
            chkMultiselect.Location = new System.Drawing.Point(6, 188);
            chkMultiselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkMultiselect.Name = "chkMultiselect";
            chkMultiselect.Size = new System.Drawing.Size(156, 37);
            chkMultiselect.TabIndex = 4;
            chkMultiselect.Values.Text = "Multi Select";
            // 
            // chkDereferenceLinks
            // 
            chkDereferenceLinks.Location = new System.Drawing.Point(6, 141);
            chkDereferenceLinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkDereferenceLinks.Name = "chkDereferenceLinks";
            chkDereferenceLinks.Size = new System.Drawing.Size(221, 37);
            chkDereferenceLinks.TabIndex = 3;
            chkDereferenceLinks.Values.Text = "Dereference Links";
            // 
            // chkCheckPathExists
            // 
            chkCheckPathExists.Location = new System.Drawing.Point(4, 94);
            chkCheckPathExists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkCheckPathExists.Name = "chkCheckPathExists";
            chkCheckPathExists.Size = new System.Drawing.Size(215, 37);
            chkCheckPathExists.TabIndex = 2;
            chkCheckPathExists.Values.Text = "Check Path Exists";
            // 
            // chkCheckFileExists
            // 
            chkCheckFileExists.Checked = true;
            chkCheckFileExists.CheckState = System.Windows.Forms.CheckState.Checked;
            chkCheckFileExists.Location = new System.Drawing.Point(6, 47);
            chkCheckFileExists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkCheckFileExists.Name = "chkCheckFileExists";
            chkCheckFileExists.Size = new System.Drawing.Size(203, 37);
            chkCheckFileExists.TabIndex = 1;
            chkCheckFileExists.Values.Text = "Check File Exists";
            // 
            // chkAddExtension
            // 
            chkAddExtension.Location = new System.Drawing.Point(6, 0);
            chkAddExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkAddExtension.Name = "chkAddExtension";
            chkAddExtension.Size = new System.Drawing.Size(183, 37);
            chkAddExtension.TabIndex = 0;
            chkAddExtension.Values.Text = "Add Extension";
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.Location = new System.Drawing.Point(18, 239);
            kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            kryptonGroupBox1.Size = new System.Drawing.Size(522, 256);
            kryptonGroupBox1.TabIndex = 20;
            kryptonGroupBox1.Values.Heading = "Style to match:";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new System.Drawing.Point(234, 45);
            kryptonTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new System.Drawing.Size(201, 39);
            kryptonTextBox1.TabIndex = 6;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonNumericUpDown1
            // 
            kryptonNumericUpDown1.Location = new System.Drawing.Point(234, 152);
            kryptonNumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            kryptonNumericUpDown1.Size = new System.Drawing.Size(135, 38);
            kryptonNumericUpDown1.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new System.Drawing.Point(234, 102);
            kryptonButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(135, 39);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new System.Drawing.Point(234, 6);
            kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new System.Drawing.Size(231, 37);
            kryptonCheckBox1.TabIndex = 2;
            kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Items.AddRange(new object[] { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1" });
            kryptonListBox1.Location = new System.Drawing.Point(6, 45);
            kryptonListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            kryptonListBox1.Size = new System.Drawing.Size(180, 150);
            kryptonListBox1.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            kryptonComboBox1.DropDownWidth = 121;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Items.AddRange(new object[] { "Microsoft Sans Serif" });
            kryptonComboBox1.Location = new System.Drawing.Point(6, 6);
            kryptonComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new System.Drawing.Size(219, 37);
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
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(891, 641);
            Controls.Add(kryptonPanel1);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Text = "KryptonOpenFileDialog Example";
            Controls.SetChildIndex(kryptonPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).EndInit();
            kryptonGroupBox2.Panel.ResumeLayout(false);
            kryptonGroupBox2.Panel.PerformLayout();
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
        private Krypton.Toolkit.KryptonCheckBox chkAddExtension;
        private Krypton.Toolkit.KryptonCheckBox chkCheckFileExists;
        private Krypton.Toolkit.KryptonCheckBox chkRestoreDirectory;
        private Krypton.Toolkit.KryptonCheckBox chkReadOnlyChecked;
        private Krypton.Toolkit.KryptonCheckBox chkMultiselect;
        private Krypton.Toolkit.KryptonCheckBox chkDereferenceLinks;
        private Krypton.Toolkit.KryptonCheckBox chkCheckPathExists;
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

