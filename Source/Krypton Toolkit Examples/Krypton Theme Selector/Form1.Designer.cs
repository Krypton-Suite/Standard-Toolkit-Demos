namespace KryptonThemeSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonThemeComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(441, 124);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 48);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(132, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Selected Theme:";
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "System.String[]"});
            this.kryptonThemeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kryptonThemeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kryptonThemeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonThemeComboBox1.DropDownWidth = 278;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Items.AddRange(new object[] {
            "Professional - System",
            "Professional - Office 2003",
            "Office 2007 - Black",
            "Office 2007 - Black (Dark Mode)",
            "Office 2007 - Blue",
            "Office 2007 - Blue (Dark Mode)",
            "Office 2007 - Blue (Light Mode)",
            "Office 2007 - Silver",
            "Office 2007 - Silver (Dark Mode)",
            "Office 2007 - Silver (Light Mode)",
            "Office 2010 - Black",
            "Office 2010 - Black (Dark Mode)",
            "Office 2010 - Blue",
            "Office 2010 - Blue (Dark Mode)",
            "Office 2010 - Blue (Light Mode)",
            "Office 2010 - Silver",
            "Office 2010 - Silver (Dark Mode)",
            "Office 2010 - Silver (Light Mode)",
            "Office 2010 - White",
            "Office 2013",
            "Office 365 - Black",
            "Office 365 - Black (Dark Mode)",
            "Office 365 - Blue",
            "Office 365 - Blue (Dark Mode)",
            "Office 365 - Blue (Light Mode)",
            "Office 365 - Silver",
            "Office 365 - Silver (Dark Mode)",
            "Office 365 - Silver (Light Mode)",
            "Office 365 - White",
            "Sparkle - Blue",
            "Sparkle - Blue (Dark Mode)",
            "Sparkle - Blue (Light Mode)",
            "Sparkle - Orange",
            "Sparkle - Orange (Dark Mode)",
            "Sparkle - Orange (Light Mode)",
            "Sparkle - Purple",
            "Sparkle - Purple (Dark Mode)",
            "Sparkle - Purple (Light Mode)",
            "Custom"});
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(151, 47);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(278, 22);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 124);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Theme Selector";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}