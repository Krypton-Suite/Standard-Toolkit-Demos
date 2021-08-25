namespace KryptonCheckSetExamples
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxSparkle = new System.Windows.Forms.GroupBox();
            this.thetaSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.gammaSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.betaSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.alphaSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.groupBoxBlue = new System.Windows.Forms.GroupBox();
            this.thetaSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.gammaSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.betaSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.alphaSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckSetOffice = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonCheckSetSystem = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.groupBoxCustom = new System.Windows.Forms.GroupBox();
            this.forwardCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            this.playCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            this.rewindCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            this.pauseCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckSetCustom = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.groupBoxSparkle.SuspendLayout();
            this.groupBoxBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetSystem)).BeginInit();
            this.groupBoxCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(263, 304);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxSparkle
            // 
            this.groupBoxSparkle.Controls.Add(this.thetaSparkle);
            this.groupBoxSparkle.Controls.Add(this.gammaSparkle);
            this.groupBoxSparkle.Controls.Add(this.betaSparkle);
            this.groupBoxSparkle.Controls.Add(this.alphaSparkle);
            this.groupBoxSparkle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSparkle.Name = "groupBoxSparkle";
            this.groupBoxSparkle.Size = new System.Drawing.Size(326, 74);
            this.groupBoxSparkle.TabIndex = 0;
            this.groupBoxSparkle.TabStop = false;
            this.groupBoxSparkle.Text = "Sparkle - Blue";
            // 
            // thetaSparkle
            // 
            this.thetaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.thetaSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.thetaSparkle.Location = new System.Drawing.Point(241, 30);
            this.thetaSparkle.Name = "thetaSparkle";
            this.thetaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.thetaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.thetaSparkle.Size = new System.Drawing.Size(69, 25);
            this.thetaSparkle.TabIndex = 3;
            this.thetaSparkle.Values.Text = "Theta";
            // 
            // gammaSparkle
            // 
            this.gammaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.gammaSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gammaSparkle.Location = new System.Drawing.Point(166, 30);
            this.gammaSparkle.Name = "gammaSparkle";
            this.gammaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.gammaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.gammaSparkle.Size = new System.Drawing.Size(69, 25);
            this.gammaSparkle.TabIndex = 2;
            this.gammaSparkle.Values.Text = "Gamma";
            // 
            // betaSparkle
            // 
            this.betaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.betaSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.betaSparkle.Location = new System.Drawing.Point(91, 30);
            this.betaSparkle.Name = "betaSparkle";
            this.betaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.betaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.betaSparkle.Size = new System.Drawing.Size(69, 25);
            this.betaSparkle.TabIndex = 1;
            this.betaSparkle.Values.Text = "Beta";
            this.betaSparkle.Click += new System.EventHandler(this.betaOffice_Click);
            // 
            // alphaSparkle
            // 
            this.alphaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.alphaSparkle.Checked = true;
            this.alphaSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.alphaSparkle.Location = new System.Drawing.Point(16, 30);
            this.alphaSparkle.Name = "alphaSparkle";
            this.alphaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.alphaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.alphaSparkle.Size = new System.Drawing.Size(69, 25);
            this.alphaSparkle.TabIndex = 0;
            this.alphaSparkle.Values.Text = "Alpha";
            // 
            // groupBoxBlue
            // 
            this.groupBoxBlue.Controls.Add(this.thetaSystem);
            this.groupBoxBlue.Controls.Add(this.gammaSystem);
            this.groupBoxBlue.Controls.Add(this.betaSystem);
            this.groupBoxBlue.Controls.Add(this.alphaSystem);
            this.groupBoxBlue.Location = new System.Drawing.Point(12, 92);
            this.groupBoxBlue.Name = "groupBoxBlue";
            this.groupBoxBlue.Size = new System.Drawing.Size(326, 74);
            this.groupBoxBlue.TabIndex = 1;
            this.groupBoxBlue.TabStop = false;
            this.groupBoxBlue.Text = "Office 2007 - Blue";
            // 
            // thetaSystem
            // 
            this.thetaSystem.AutoSize = true;
            this.thetaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.thetaSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.thetaSystem.Location = new System.Drawing.Point(241, 31);
            this.thetaSystem.Name = "thetaSystem";
            this.thetaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.thetaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.thetaSystem.Size = new System.Drawing.Size(69, 27);
            this.thetaSystem.TabIndex = 3;
            this.thetaSystem.Values.Text = "Theta";
            // 
            // gammaSystem
            // 
            this.gammaSystem.AutoSize = true;
            this.gammaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.gammaSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gammaSystem.Location = new System.Drawing.Point(166, 31);
            this.gammaSystem.Name = "gammaSystem";
            this.gammaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.gammaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.gammaSystem.Size = new System.Drawing.Size(69, 27);
            this.gammaSystem.TabIndex = 2;
            this.gammaSystem.Values.Text = "Gamma";
            // 
            // betaSystem
            // 
            this.betaSystem.AutoSize = true;
            this.betaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.betaSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.betaSystem.Location = new System.Drawing.Point(91, 31);
            this.betaSystem.Name = "betaSystem";
            this.betaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.betaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.betaSystem.Size = new System.Drawing.Size(69, 27);
            this.betaSystem.TabIndex = 1;
            this.betaSystem.Values.Text = "Beta";
            // 
            // alphaSystem
            // 
            this.alphaSystem.AutoSize = true;
            this.alphaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.alphaSystem.Checked = true;
            this.alphaSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.alphaSystem.Location = new System.Drawing.Point(16, 31);
            this.alphaSystem.Name = "alphaSystem";
            this.alphaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.alphaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.alphaSystem.Size = new System.Drawing.Size(69, 27);
            this.alphaSystem.TabIndex = 0;
            this.alphaSystem.Values.Text = "Alpha";
            // 
            // kryptonCheckSetOffice
            // 
            this.kryptonCheckSetOffice.CheckButtons.Add(this.thetaSparkle);
            this.kryptonCheckSetOffice.CheckButtons.Add(this.gammaSparkle);
            this.kryptonCheckSetOffice.CheckButtons.Add(this.betaSparkle);
            this.kryptonCheckSetOffice.CheckButtons.Add(this.alphaSparkle);
            this.kryptonCheckSetOffice.CheckedButton = this.alphaSparkle;
            // 
            // kryptonCheckSetSystem
            // 
            this.kryptonCheckSetSystem.CheckButtons.Add(this.thetaSystem);
            this.kryptonCheckSetSystem.CheckButtons.Add(this.gammaSystem);
            this.kryptonCheckSetSystem.CheckButtons.Add(this.betaSystem);
            this.kryptonCheckSetSystem.CheckButtons.Add(this.alphaSystem);
            this.kryptonCheckSetSystem.CheckedButton = this.alphaSystem;
            // 
            // groupBoxCustom
            // 
            this.groupBoxCustom.Controls.Add(this.forwardCheckButton);
            this.groupBoxCustom.Controls.Add(this.playCheckButton);
            this.groupBoxCustom.Controls.Add(this.rewindCheckButton);
            this.groupBoxCustom.Controls.Add(this.pauseCheckButton);
            this.groupBoxCustom.Location = new System.Drawing.Point(12, 172);
            this.groupBoxCustom.Name = "groupBoxCustom";
            this.groupBoxCustom.Size = new System.Drawing.Size(326, 123);
            this.groupBoxCustom.TabIndex = 2;
            this.groupBoxCustom.TabStop = false;
            this.groupBoxCustom.Text = "Custom Settings";
            // 
            // forwardCheckButton
            // 
            this.forwardCheckButton.AutoSize = true;
            this.forwardCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.forwardCheckButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forwardCheckButton.Location = new System.Drawing.Point(228, 30);
            this.forwardCheckButton.Name = "forwardCheckButton";
            this.forwardCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.forwardCheckButton.Size = new System.Drawing.Size(61, 75);
            this.forwardCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.forwardCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.forwardCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.forwardCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.forwardCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.forwardCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.forwardCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.forwardCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.forwardCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.forwardCheckButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forwardCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.forwardCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.forwardCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.forwardCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.forwardCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.forwardCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.forwardCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.forwardCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.forwardCheckButton.TabIndex = 3;
            this.forwardCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.Image")));
            this.forwardCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.forwardCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.forwardCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.forwardCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImagePressed")));
            this.forwardCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageTracking")));
            this.forwardCheckButton.Values.Text = "Forward";
            // 
            // playCheckButton
            // 
            this.playCheckButton.AutoSize = true;
            this.playCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.playCheckButton.Checked = true;
            this.playCheckButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playCheckButton.Location = new System.Drawing.Point(168, 30);
            this.playCheckButton.Name = "playCheckButton";
            this.playCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.playCheckButton.Size = new System.Drawing.Size(60, 77);
            this.playCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.playCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.playCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.playCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.playCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.playCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.playCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.playCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.playCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.playCheckButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.playCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.playCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.playCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.playCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.playCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.playCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.playCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.playCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.playCheckButton.TabIndex = 2;
            this.playCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.Image")));
            this.playCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.playCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.playCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.playCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImagePressed")));
            this.playCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("playCheckButton.Values.ImageStates.ImageTracking")));
            this.playCheckButton.Values.Text = "Play";
            // 
            // rewindCheckButton
            // 
            this.rewindCheckButton.AutoSize = true;
            this.rewindCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.rewindCheckButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rewindCheckButton.Location = new System.Drawing.Point(52, 30);
            this.rewindCheckButton.Name = "rewindCheckButton";
            this.rewindCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.rewindCheckButton.Size = new System.Drawing.Size(58, 75);
            this.rewindCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.rewindCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.rewindCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.rewindCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.rewindCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.rewindCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.rewindCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.rewindCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.rewindCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rewindCheckButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rewindCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.rewindCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.rewindCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.rewindCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.rewindCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rewindCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.rewindCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.rewindCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.rewindCheckButton.TabIndex = 0;
            this.rewindCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.Image")));
            this.rewindCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.rewindCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.rewindCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.rewindCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImagePressed")));
            this.rewindCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageTracking")));
            this.rewindCheckButton.Values.Text = "Rewind";
            // 
            // pauseCheckButton
            // 
            this.pauseCheckButton.AutoSize = true;
            this.pauseCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.pauseCheckButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pauseCheckButton.Location = new System.Drawing.Point(110, 30);
            this.pauseCheckButton.Name = "pauseCheckButton";
            this.pauseCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.pauseCheckButton.Size = new System.Drawing.Size(58, 75);
            this.pauseCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.pauseCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.pauseCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.pauseCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.pauseCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.pauseCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.pauseCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.pauseCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.pauseCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.pauseCheckButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pauseCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.pauseCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.pauseCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.pauseCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.pauseCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.pauseCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.pauseCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.pauseCheckButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.pauseCheckButton.TabIndex = 1;
            this.pauseCheckButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.Image")));
            this.pauseCheckButton.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedNormal")));
            this.pauseCheckButton.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedPressed")));
            this.pauseCheckButton.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedTracking")));
            this.pauseCheckButton.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImagePressed")));
            this.pauseCheckButton.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageTracking")));
            this.pauseCheckButton.Values.Text = "Pause";
            // 
            // kryptonCheckSetCustom
            // 
            this.kryptonCheckSetCustom.CheckButtons.Add(this.forwardCheckButton);
            this.kryptonCheckSetCustom.CheckButtons.Add(this.playCheckButton);
            this.kryptonCheckSetCustom.CheckButtons.Add(this.rewindCheckButton);
            this.kryptonCheckSetCustom.CheckButtons.Add(this.pauseCheckButton);
            this.kryptonCheckSetCustom.CheckedButton = this.playCheckButton;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 336);
            this.Controls.Add(this.groupBoxCustom);
            this.Controls.Add(this.groupBoxBlue);
            this.Controls.Add(this.groupBoxSparkle);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonCheckSet Examples";
            this.groupBoxSparkle.ResumeLayout(false);
            this.groupBoxBlue.ResumeLayout(false);
            this.groupBoxBlue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetSystem)).EndInit();
            this.groupBoxCustom.ResumeLayout(false);
            this.groupBoxCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSetCustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxSparkle;
        private System.Windows.Forms.GroupBox groupBoxBlue;
        private System.Windows.Forms.GroupBox groupBoxCustom;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSetOffice;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSetSystem;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSetCustom;
        private Krypton.Toolkit.KryptonCheckButton thetaSparkle;
        private Krypton.Toolkit.KryptonCheckButton gammaSparkle;
        private Krypton.Toolkit.KryptonCheckButton betaSparkle;
        private Krypton.Toolkit.KryptonCheckButton alphaSparkle;
        private Krypton.Toolkit.KryptonCheckButton thetaSystem;
        private Krypton.Toolkit.KryptonCheckButton gammaSystem;
        private Krypton.Toolkit.KryptonCheckButton betaSystem;
        private Krypton.Toolkit.KryptonCheckButton alphaSystem;
        private Krypton.Toolkit.KryptonCheckButton forwardCheckButton;
        private Krypton.Toolkit.KryptonCheckButton playCheckButton;
        private Krypton.Toolkit.KryptonCheckButton rewindCheckButton;
        private Krypton.Toolkit.KryptonCheckButton pauseCheckButton;
    }
}

