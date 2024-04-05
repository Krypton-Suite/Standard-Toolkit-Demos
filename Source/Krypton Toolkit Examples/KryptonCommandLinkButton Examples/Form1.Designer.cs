namespace KryptonCommandLinkButtonExamples
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
            this.kbtOk = new Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCommandLinkButton5 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonCommandLinkButton4 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonCommandLinkButton3 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonCommandLinkButton2 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonAlternateCommandLinkButton1 = new Krypton.Toolkit.KryptonAlternateCommandLinkButton();
            this.kryptonCommandLinkButton1 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kpgButtons = new Krypton.Toolkit.KryptonPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtOk);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 582);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonPanel1.Size = new System.Drawing.Size(1085, 62);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtOk
            // 
            this.kbtOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtOk.Location = new System.Drawing.Point(949, 16);
            this.kbtOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kbtOk.Name = "kbtOk";
            this.kbtOk.Size = new System.Drawing.Size(120, 31);
            this.kbtOk.TabIndex = 1;
            this.kbtOk.Values.Text = "Ok";
            this.kbtOk.Click += new System.EventHandler(this.kbtOk_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(1085, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonCommandLinkButton5);
            this.kryptonPanel2.Controls.Add(this.kryptonCommandLinkButton4);
            this.kryptonPanel2.Controls.Add(this.kryptonCommandLinkButton3);
            this.kryptonPanel2.Controls.Add(this.kryptonCommandLinkButton2);
            this.kryptonPanel2.Controls.Add(this.kryptonAlternateCommandLinkButton1);
            this.kryptonPanel2.Controls.Add(this.kryptonCommandLinkButton1);
            this.kryptonPanel2.Controls.Add(this.kpgButtons);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1085, 582);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonCommandLinkButton5
            // 
            this.kryptonCommandLinkButton5.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonCommandLinkButton5.CommandLinkTextValues.Description = "What happens when the text is really long, \r\nand wants to go off the edge?\r\nThen " +
    "Use a Multi-line ;-)\r\n";
            this.kryptonCommandLinkButton5.CommandLinkTextValues.Heading = "&Control the World";
            this.kryptonCommandLinkButton5.Location = new System.Drawing.Point(17, 463);
            this.kryptonCommandLinkButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonCommandLinkButton5.Name = "kryptonCommandLinkButton5";
            this.kryptonCommandLinkButton5.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton5.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton5.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton5.Size = new System.Drawing.Size(453, 106);
            this.kryptonCommandLinkButton5.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.kryptonCommandLinkButton5.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonCommandLinkButton5.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonCommandLinkButton5.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton5.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton5.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton5.StateCommon.Border.Rounding = 6F;
            this.kryptonCommandLinkButton5.StateCommon.Border.Width = 2;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.kryptonCommandLinkButton5.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton5.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton5.TabIndex = 11;
            this.kryptonCommandLinkButton5.Click += new System.EventHandler(this.kryptonCommandLinkButton5_Click);
            // 
            // kryptonCommandLinkButton4
            // 
            this.kryptonCommandLinkButton4.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.kryptonCommandLinkButton4.CommandLinkImageValues.Image = ((System.Drawing.Image)(resources.GetObject("kryptonCommandLinkButton4.CommandLinkImageValues.Image")));
            this.kryptonCommandLinkButton4.CommandLinkTextValues.Description = " Demo the Shortcut display and rounded borders";
            this.kryptonCommandLinkButton4.CommandLinkTextValues.Heading = "&Disabled Navigator Mini style";
            this.kryptonCommandLinkButton4.Enabled = false;
            this.kryptonCommandLinkButton4.Location = new System.Drawing.Point(17, 388);
            this.kryptonCommandLinkButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonCommandLinkButton4.Name = "kryptonCommandLinkButton4";
            this.kryptonCommandLinkButton4.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton4.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton4.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton4.Size = new System.Drawing.Size(453, 68);
            this.kryptonCommandLinkButton4.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton4.StateCommon.Border.Rounding = 4F;
            this.kryptonCommandLinkButton4.StateCommon.Border.Width = 2;
            this.kryptonCommandLinkButton4.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton4.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton4.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton4.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton4.TabIndex = 10;
            this.kryptonCommandLinkButton4.Click += new System.EventHandler(this.kryptonCommandLinkButton4_Click);
            // 
            // kryptonCommandLinkButton3
            // 
            this.kryptonCommandLinkButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.kryptonCommandLinkButton3.CommandLinkTextValues.Description = " Demo the Shortcut display and rounded borders";
            this.kryptonCommandLinkButton3.CommandLinkTextValues.Heading = "&Navigator Mini style";
            this.kryptonCommandLinkButton3.Location = new System.Drawing.Point(16, 304);
            this.kryptonCommandLinkButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonCommandLinkButton3.Name = "kryptonCommandLinkButton3";
            this.kryptonCommandLinkButton3.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton3.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton3.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton3.Size = new System.Drawing.Size(455, 75);
            this.kryptonCommandLinkButton3.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton3.StateCommon.Border.Rounding = 4F;
            this.kryptonCommandLinkButton3.StateCommon.Border.Width = 2;
            this.kryptonCommandLinkButton3.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton3.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton3.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton3.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton3.TabIndex = 9;
            this.kryptonCommandLinkButton3.Click += new System.EventHandler(this.kryptonCommandLinkButton3_Click);
            // 
            // kryptonCommandLinkButton2
            // 
            this.kryptonCommandLinkButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonCommandLinkButton2.CommandLinkTextValues.Description = " Here be the extra Text with some spaces";
            this.kryptonCommandLinkButton2.CommandLinkTextValues.Heading = "Standalone Style";
            this.kryptonCommandLinkButton2.Location = new System.Drawing.Point(16, 222);
            this.kryptonCommandLinkButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonCommandLinkButton2.Name = "kryptonCommandLinkButton2";
            this.kryptonCommandLinkButton2.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton2.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton2.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton2.Size = new System.Drawing.Size(455, 75);
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.TabIndex = 8;
            this.kryptonCommandLinkButton2.Click += new System.EventHandler(this.kryptonCommandLinkButton2_Click);
            // 
            // kryptonAlternateCommandLinkButton1
            // 
            this.kryptonAlternateCommandLinkButton1.Location = new System.Drawing.Point(16, 15);
            this.kryptonAlternateCommandLinkButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonAlternateCommandLinkButton1.Name = "kryptonAlternateCommandLinkButton1";
            this.kryptonAlternateCommandLinkButton1.Size = new System.Drawing.Size(455, 85);
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonAlternateCommandLinkButton1.TabIndex = 7;
            this.kryptonAlternateCommandLinkButton1.Values.ExtraText = "Text here is forced in to the  lower part of the button";
            this.kryptonAlternateCommandLinkButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonAlternateCommandLinkButton1.Values.Image")));
            this.kryptonAlternateCommandLinkButton1.Values.Text = "Normal Krypton Button";
            this.kryptonAlternateCommandLinkButton1.Click += new System.EventHandler(this.kryptonAlternateCommandLinkButton1_Click);
            // 
            // kryptonCommandLinkButton1
            // 
            this.kryptonCommandLinkButton1.CommandLinkTextValues.Description = "Here be the \"Note Text\"";
            this.kryptonCommandLinkButton1.CommandLinkTextValues.Heading = "Default Ext Command Link";
            this.kryptonCommandLinkButton1.Location = new System.Drawing.Point(16, 122);
            this.kryptonCommandLinkButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonCommandLinkButton1.Name = "kryptonCommandLinkButton1";
            this.kryptonCommandLinkButton1.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton1.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton1.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton1.Size = new System.Drawing.Size(455, 75);
            this.kryptonCommandLinkButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton1.TabIndex = 6;
            this.kryptonCommandLinkButton1.Click += new System.EventHandler(this.kryptonCommandLinkButton1_Click);
            // 
            // kpgButtons
            // 
            this.kpgButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kpgButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kpgButtons.CategoryForeColor = System.Drawing.Color.White;
            this.kpgButtons.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kpgButtons.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgButtons.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgButtons.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kpgButtons.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kpgButtons.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgButtons.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgButtons.Location = new System.Drawing.Point(523, 15);
            this.kpgButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kpgButtons.Name = "kpgButtons";
            this.kpgButtons.Size = new System.Drawing.Size(547, 554);
            this.kpgButtons.TabIndex = 0;
            this.kpgButtons.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kpgButtons.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1085, 644);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Krypton Command Link Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPropertyGrid kpgButtons;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton5;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton4;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton3;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton2;
        private Krypton.Toolkit.KryptonAlternateCommandLinkButton kryptonAlternateCommandLinkButton1;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton1;
        private Krypton.Toolkit.KryptonButton kbtOk;
    }
}
