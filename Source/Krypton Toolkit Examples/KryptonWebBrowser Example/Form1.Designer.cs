
namespace KryptonWebBrowserExample
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser2 = new Krypton.Toolkit.KryptonWebBrowser();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuCheckButton1 = new Krypton.Toolkit.KryptonContextMenuCheckButton();
            this.kryptonContextMenuCheckButton2 = new Krypton.Toolkit.KryptonContextMenuCheckButton();
            this.kcmbTheme = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(2, 227);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(360, 189);
            this.webBrowser1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser2.KryptonContextMenu = this.kryptonContextMenu1;
            this.webBrowser2.Location = new System.Drawing.Point(366, 227);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(360, 189);
            this.webBrowser2.TabIndex = 1;
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuCheckButton1,
            this.kryptonContextMenuCheckButton2});
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuCheckButton1
            // 
            this.kryptonContextMenuCheckButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonContextMenuCheckButton1.Text = "CheckButton";
            // 
            // kryptonContextMenuCheckButton2
            // 
            this.kryptonContextMenuCheckButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonContextMenuCheckButton2.Text = "CheckButton";
            // 
            // kcmbTheme
            // 
            this.kcmbTheme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kcmbTheme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kcmbTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kcmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.kcmbTheme.DropDownWidth = 218;
            this.kcmbTheme.IntegralHeight = false;
            this.kcmbTheme.Location = new System.Drawing.Point(2, 2);
            this.kcmbTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kcmbTheme.Name = "kcmbTheme";
            this.kcmbTheme.Size = new System.Drawing.Size(164, 21);
            this.kcmbTheme.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbTheme.TabIndex = 2;
            this.kcmbTheme.Text = "kryptonComboBox1";
            this.kcmbTheme.SelectedValueChanged += new System.EventHandler(this.KcmbTheme_SelectedValueChanged);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonRichTextBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 418);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kryptonPanel2, 2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.kcmbTheme);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(2, 2);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(724, 28);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(277, 2);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(191, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Left = Winform | Right = Krypton";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1,
            this.buttonSpecAny2});
            this.kryptonRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonRichTextBox1.KryptonContextMenu = this.kryptonContextMenu1;
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(366, 34);
            this.kryptonRichTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(360, 189);
            this.kryptonRichTextBox1.TabIndex = 4;
            this.kryptonRichTextBox1.Text = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.ToolTipValues.EnableToolTips = true;
            this.kryptonRichTextBox1.ToolTipValues.Heading = "Right click in each area";
            this.kryptonRichTextBox1.ToolTipValues.Image = null;
            this.kryptonRichTextBox1.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Relative;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            this.buttonSpecAny1.UniqueName = "dd412874d51045e685c06bf93bf1cf38";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormMax;
            this.buttonSpecAny2.UniqueName = "17c416590cf64a3599cbbb3aea002abb";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 34);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 189);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Winform Rich Text Box";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(728, 418);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 418);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Comparison between Winform and Krypton controls";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private Krypton.Toolkit.KryptonWebBrowser webBrowser2;
        private Krypton.Toolkit.KryptonComboBox kcmbTheme;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private Krypton.Toolkit.KryptonContextMenuCheckButton kryptonContextMenuCheckButton1;
        private Krypton.Toolkit.KryptonContextMenuCheckButton kryptonContextMenuCheckButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

