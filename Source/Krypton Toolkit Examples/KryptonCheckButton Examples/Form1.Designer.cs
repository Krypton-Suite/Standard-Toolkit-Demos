namespace KryptonCheckButtonExamples
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBoxCustom = new System.Windows.Forms.GroupBox();
            this.button1Custom = new Krypton.Toolkit.KryptonCheckButton();
            this.button5Custom = new Krypton.Toolkit.KryptonCheckButton();
            this.button2Custom = new Krypton.Toolkit.KryptonCheckButton();
            this.button3Custom = new Krypton.Toolkit.KryptonCheckButton();
            this.button4Custom = new Krypton.Toolkit.KryptonCheckButton();
            this.groupBoxSparkle = new System.Windows.Forms.GroupBox();
            this.button6Sparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.button4Sparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.button5Sparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.button1Sparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.button2Sparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.button3Sparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.groupBoxOffice2007 = new System.Windows.Forms.GroupBox();
            this.button6System = new Krypton.Toolkit.KryptonCheckButton();
            this.button4System = new Krypton.Toolkit.KryptonCheckButton();
            this.button5System = new Krypton.Toolkit.KryptonCheckButton();
            this.button1System = new Krypton.Toolkit.KryptonCheckButton();
            this.button2System = new Krypton.Toolkit.KryptonCheckButton();
            this.button3System = new Krypton.Toolkit.KryptonCheckButton();
            this.groupBox4.SuspendLayout();
            this.groupBoxCustom.SuspendLayout();
            this.groupBoxSparkle.SuspendLayout();
            this.groupBoxOffice2007.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(497, 539);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(250, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 519);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KryptonCheckButton";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 494);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // groupBoxCustom
            // 
            this.groupBoxCustom.Controls.Add(this.button1Custom);
            this.groupBoxCustom.Controls.Add(this.button5Custom);
            this.groupBoxCustom.Controls.Add(this.button2Custom);
            this.groupBoxCustom.Controls.Add(this.button3Custom);
            this.groupBoxCustom.Controls.Add(this.button4Custom);
            this.groupBoxCustom.Location = new System.Drawing.Point(12, 330);
            this.groupBoxCustom.Name = "groupBoxCustom";
            this.groupBoxCustom.Size = new System.Drawing.Size(225, 201);
            this.groupBoxCustom.TabIndex = 2;
            this.groupBoxCustom.TabStop = false;
            this.groupBoxCustom.Text = "Custom Settings";
            // 
            // button1Custom
            // 
            this.button1Custom.AutoSize = true;
            this.button1Custom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button1Custom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1Custom.Location = new System.Drawing.Point(21, 29);
            this.button1Custom.Name = "button1Custom";
            this.button1Custom.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button1Custom.OverrideFocus.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.button1Custom.OverrideFocus.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button1Custom.Size = new System.Drawing.Size(60, 58);
            this.button1Custom.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.button1Custom.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button1Custom.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button1Custom.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.button1Custom.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button1Custom.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button1Custom.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button1Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button1Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button1Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.button1Custom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button1Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button1Custom.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.button1Custom.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button1Custom.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.button1Custom.TabIndex = 0;
            this.button1Custom.Values.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("button1Custom.Values.ImageStates.ImageCheckedNormal")));
            this.button1Custom.Values.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("button1Custom.Values.ImageStates.ImageCheckedPressed")));
            this.button1Custom.Values.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("button1Custom.Values.ImageStates.ImageCheckedTracking")));
            this.button1Custom.Values.ImageStates.ImageNormal = ((System.Drawing.Image)(resources.GetObject("button1Custom.Values.ImageStates.ImageNormal")));
            this.button1Custom.Values.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("button1Custom.Values.ImageStates.ImagePressed")));
            this.button1Custom.Values.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("button1Custom.Values.ImageStates.ImageTracking")));
            this.button1Custom.Values.Text = "";
            this.button1Custom.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button5Custom
            // 
            this.button5Custom.AutoSize = true;
            this.button5Custom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button5Custom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button5Custom.Location = new System.Drawing.Point(106, 29);
            this.button5Custom.Name = "button5Custom";
            this.button5Custom.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button5Custom.OverrideDefault.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.button5Custom.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.OverrideFocus.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.button5Custom.OverrideFocus.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button5Custom.Size = new System.Drawing.Size(106, 54);
            this.button5Custom.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button5Custom.StateCheckedNormal.Back.Image = global::KryptonCheckButtonExamples.Properties.Resources.pageBgChecked;
            this.button5Custom.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button5Custom.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button5Custom.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button5Custom.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button5Custom.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Border.Rounding = 11F;
            this.button5Custom.StateCheckedNormal.Border.Width = 4;
            this.button5Custom.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateCheckedNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button5Custom.StateCheckedNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateCheckedNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateCheckedNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Custom.StateCheckedNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateCheckedNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.button5Custom.StateCheckedNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Custom.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button5Custom.StateCheckedPressed.Back.Image = global::KryptonCheckButtonExamples.Properties.Resources.pageBgChecked;
            this.button5Custom.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedPressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.button5Custom.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button5Custom.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedPressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button5Custom.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button5Custom.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Border.Rounding = 11F;
            this.button5Custom.StateCheckedPressed.Border.Width = 4;
            this.button5Custom.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateCheckedPressed.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button5Custom.StateCheckedPressed.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateCheckedPressed.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateCheckedPressed.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Custom.StateCheckedPressed.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateCheckedPressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.button5Custom.StateCheckedPressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Custom.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button5Custom.StateCheckedTracking.Back.Image = global::KryptonCheckButtonExamples.Properties.Resources.pageBgChecked;
            this.button5Custom.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedTracking.Border.Color1 = System.Drawing.Color.Red;
            this.button5Custom.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button5Custom.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button5Custom.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button5Custom.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Border.Rounding = 11F;
            this.button5Custom.StateCheckedTracking.Border.Width = 4;
            this.button5Custom.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateCheckedTracking.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button5Custom.StateCheckedTracking.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateCheckedTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateCheckedTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Custom.StateCheckedTracking.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateCheckedTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.button5Custom.StateCheckedTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Custom.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button5Custom.StateNormal.Back.Image = global::KryptonCheckButtonExamples.Properties.Resources.pageBg;
            this.button5Custom.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button5Custom.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button5Custom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button5Custom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button5Custom.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Border.Rounding = 11F;
            this.button5Custom.StateNormal.Border.Width = 4;
            this.button5Custom.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateNormal.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button5Custom.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateNormal.Content.LongText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Custom.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Custom.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Custom.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Custom.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.button5Custom.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Custom.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button5Custom.StatePressed.Back.Image = global::KryptonCheckButtonExamples.Properties.Resources.pageBg;
            this.button5Custom.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.button5Custom.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button5Custom.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button5Custom.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button5Custom.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Border.Rounding = 11F;
            this.button5Custom.StatePressed.Border.Width = 4;
            this.button5Custom.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StatePressed.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button5Custom.StatePressed.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StatePressed.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StatePressed.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StatePressed.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StatePressed.Content.LongText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Custom.StatePressed.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Custom.StatePressed.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StatePressed.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StatePressed.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StatePressed.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StatePressed.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StatePressed.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Custom.StatePressed.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.button5Custom.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.button5Custom.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Custom.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button5Custom.StateTracking.Back.Image = global::KryptonCheckButtonExamples.Properties.Resources.pageBg;
            this.button5Custom.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.button5Custom.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button5Custom.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button5Custom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button5Custom.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Border.Rounding = 11F;
            this.button5Custom.StateTracking.Border.Width = 4;
            this.button5Custom.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateTracking.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button5Custom.StateTracking.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateTracking.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateTracking.Content.LongText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateTracking.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateTracking.Content.LongText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Custom.StateTracking.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Custom.StateTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateTracking.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Custom.StateTracking.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Custom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button5Custom.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Custom.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.button5Custom.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Custom.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Custom.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Custom.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Custom.TabIndex = 1;
            this.button5Custom.Values.ExtraText = "ExtraText";
            this.button5Custom.Values.Text = "Text";
            this.button5Custom.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button2Custom
            // 
            this.button2Custom.AutoSize = true;
            this.button2Custom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button2Custom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2Custom.Location = new System.Drawing.Point(154, 97);
            this.button2Custom.Name = "button2Custom";
            this.button2Custom.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button2Custom.OverrideDefault.Back.Color1 = System.Drawing.Color.MintCream;
            this.button2Custom.OverrideDefault.Back.Color2 = System.Drawing.Color.Aquamarine;
            this.button2Custom.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.OverrideDefault.Back.ColorAngle = 75F;
            this.button2Custom.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button2Custom.Size = new System.Drawing.Size(58, 29);
            this.button2Custom.StateCheckedNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.button2Custom.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2Custom.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Back.ColorAngle = 75F;
            this.button2Custom.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateCheckedNormal.Border.Color1 = System.Drawing.Color.Maroon;
            this.button2Custom.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2Custom.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2Custom.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Border.Rounding = 5F;
            this.button2Custom.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button2Custom.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2Custom.StateCheckedNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2Custom.StateCheckedNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button2Custom.StateCheckedPressed.Back.Color1 = System.Drawing.Color.Maroon;
            this.button2Custom.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Maroon;
            this.button2Custom.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Back.ColorAngle = 75F;
            this.button2Custom.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateCheckedPressed.Border.Color1 = System.Drawing.Color.Maroon;
            this.button2Custom.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedPressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2Custom.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2Custom.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Border.Rounding = 5F;
            this.button2Custom.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button2Custom.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2Custom.StateCheckedPressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2Custom.StateCheckedPressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button2Custom.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2Custom.StateCheckedTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.button2Custom.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Back.ColorAngle = 75F;
            this.button2Custom.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateCheckedTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.button2Custom.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2Custom.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2Custom.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Border.Rounding = 5F;
            this.button2Custom.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button2Custom.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2Custom.StateCheckedTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2Custom.StateCheckedTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button2Custom.StateNormal.Back.Color1 = System.Drawing.Color.MintCream;
            this.button2Custom.StateNormal.Back.Color2 = System.Drawing.Color.Aquamarine;
            this.button2Custom.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateNormal.Back.ColorAngle = 75F;
            this.button2Custom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateNormal.Border.Color1 = System.Drawing.Color.LightSeaGreen;
            this.button2Custom.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2Custom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2Custom.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateNormal.Border.Rounding = 5F;
            this.button2Custom.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button2Custom.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Custom.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button2Custom.StatePressed.Back.Color1 = System.Drawing.Color.Turquoise;
            this.button2Custom.StatePressed.Back.Color2 = System.Drawing.Color.Turquoise;
            this.button2Custom.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StatePressed.Back.ColorAngle = 75F;
            this.button2Custom.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StatePressed.Border.Color1 = System.Drawing.Color.LightSeaGreen;
            this.button2Custom.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2Custom.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2Custom.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StatePressed.Border.Rounding = 5F;
            this.button2Custom.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button2Custom.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2Custom.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button2Custom.StateTracking.Back.Color1 = System.Drawing.Color.Aquamarine;
            this.button2Custom.StateTracking.Back.Color2 = System.Drawing.Color.Turquoise;
            this.button2Custom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateTracking.Back.ColorAngle = 75F;
            this.button2Custom.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button2Custom.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button2Custom.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateTracking.Border.Color1 = System.Drawing.Color.LightSeaGreen;
            this.button2Custom.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2Custom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2Custom.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateTracking.Border.Rounding = 5F;
            this.button2Custom.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button2Custom.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2Custom.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button2Custom.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button2Custom.TabIndex = 3;
            this.button2Custom.Values.Text = "Text";
            this.button2Custom.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button3Custom
            // 
            this.button3Custom.AutoSize = true;
            this.button3Custom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button3Custom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button3Custom.Location = new System.Drawing.Point(68, 143);
            this.button3Custom.Name = "button3Custom";
            this.button3Custom.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button3Custom.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            this.button3Custom.OverrideDefault.Back.Color2 = System.Drawing.Color.Silver;
            this.button3Custom.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button3Custom.Size = new System.Drawing.Size(82, 39);
            this.button3Custom.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Silver;
            this.button3Custom.StateCheckedNormal.Back.Color2 = System.Drawing.Color.LightGray;
            this.button3Custom.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Back.ColorAngle = 45F;
            this.button3Custom.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button3Custom.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3Custom.StateCheckedNormal.Border.Color2 = System.Drawing.Color.DimGray;
            this.button3Custom.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Border.ColorAngle = 45F;
            this.button3Custom.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.button3Custom.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3Custom.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button3Custom.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Border.Rounding = 6F;
            this.button3Custom.StateCheckedNormal.Border.Width = 3;
            this.button3Custom.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button3Custom.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.button3Custom.StateCheckedNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3Custom.StateCheckedNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.button3Custom.StateCheckedNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button3Custom.StateCheckedPressed.Back.Color1 = System.Drawing.Color.Black;
            this.button3Custom.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Gray;
            this.button3Custom.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Back.ColorAngle = 45F;
            this.button3Custom.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button3Custom.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateCheckedPressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3Custom.StateCheckedPressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.button3Custom.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Border.ColorAngle = 45F;
            this.button3Custom.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.button3Custom.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedPressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3Custom.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button3Custom.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Border.Rounding = 6F;
            this.button3Custom.StateCheckedPressed.Border.Width = 3;
            this.button3Custom.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button3Custom.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button3Custom.StateCheckedPressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3Custom.StateCheckedPressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.button3Custom.StateCheckedPressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button3Custom.StateCheckedTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.button3Custom.StateCheckedTracking.Back.Color2 = System.Drawing.Color.DarkGray;
            this.button3Custom.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Back.ColorAngle = 45F;
            this.button3Custom.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button3Custom.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3Custom.StateCheckedTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.button3Custom.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Border.ColorAngle = 45F;
            this.button3Custom.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.button3Custom.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3Custom.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button3Custom.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Border.Rounding = 6F;
            this.button3Custom.StateCheckedTracking.Border.Width = 3;
            this.button3Custom.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button3Custom.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button3Custom.StateCheckedTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3Custom.StateCheckedTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.button3Custom.StateCheckedTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button3Custom.StateNormal.Back.Color1 = System.Drawing.Color.Silver;
            this.button3Custom.StateNormal.Back.Color2 = System.Drawing.Color.LightGray;
            this.button3Custom.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateNormal.Back.ColorAngle = 45F;
            this.button3Custom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button3Custom.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateNormal.Border.Color1 = System.Drawing.Color.DimGray;
            this.button3Custom.StateNormal.Border.Color2 = System.Drawing.Color.DimGray;
            this.button3Custom.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button3Custom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3Custom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button3Custom.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateNormal.Border.Rounding = 6F;
            this.button3Custom.StateNormal.Border.Width = 3;
            this.button3Custom.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button3Custom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.button3Custom.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Custom.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.button3Custom.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button3Custom.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.button3Custom.StatePressed.Back.Color2 = System.Drawing.Color.Gray;
            this.button3Custom.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StatePressed.Back.ColorAngle = 45F;
            this.button3Custom.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button3Custom.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StatePressed.Border.Color1 = System.Drawing.Color.DimGray;
            this.button3Custom.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.button3Custom.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StatePressed.Border.ColorAngle = 45F;
            this.button3Custom.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button3Custom.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3Custom.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button3Custom.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StatePressed.Border.Rounding = 6F;
            this.button3Custom.StatePressed.Border.Width = 3;
            this.button3Custom.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button3Custom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button3Custom.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Custom.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.button3Custom.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button3Custom.StateTracking.Back.Color1 = System.Drawing.Color.DimGray;
            this.button3Custom.StateTracking.Back.Color2 = System.Drawing.Color.DarkGray;
            this.button3Custom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateTracking.Back.ColorAngle = 45F;
            this.button3Custom.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.button3Custom.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button3Custom.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateTracking.Border.Color1 = System.Drawing.Color.DimGray;
            this.button3Custom.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.button3Custom.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateTracking.Border.ColorAngle = 45F;
            this.button3Custom.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.button3Custom.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3Custom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button3Custom.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateTracking.Border.Rounding = 6F;
            this.button3Custom.StateTracking.Border.Width = 3;
            this.button3Custom.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button3Custom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button3Custom.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Custom.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.button3Custom.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button3Custom.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button3Custom.TabIndex = 4;
            this.button3Custom.Values.Image = ((System.Drawing.Image)(resources.GetObject("button3Custom.Values.Image")));
            this.button3Custom.Values.Text = "Text";
            this.button3Custom.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button4Custom
            // 
            this.button4Custom.AutoSize = true;
            this.button4Custom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button4Custom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button4Custom.Location = new System.Drawing.Point(21, 97);
            this.button4Custom.Name = "button4Custom";
            this.button4Custom.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button4Custom.OverrideDefault.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.button4Custom.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSteelBlue;
            this.button4Custom.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button4Custom.Size = new System.Drawing.Size(112, 31);
            this.button4Custom.StateCheckedNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.button4Custom.StateCheckedNormal.Back.Color2 = System.Drawing.Color.YellowGreen;
            this.button4Custom.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.button4Custom.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.StateCheckedNormal.Border.Color1 = System.Drawing.Color.Green;
            this.button4Custom.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button4Custom.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedNormal.Border.Rounding = 3F;
            this.button4Custom.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(215)))));
            this.button4Custom.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Green;
            this.button4Custom.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.button4Custom.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.StateCheckedPressed.Border.Color1 = System.Drawing.Color.Green;
            this.button4Custom.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateCheckedPressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button4Custom.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedPressed.Border.Rounding = 3F;
            this.button4Custom.StateCheckedTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.button4Custom.StateCheckedTracking.Back.Color2 = System.Drawing.Color.Green;
            this.button4Custom.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.button4Custom.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.StateCheckedTracking.Border.Color1 = System.Drawing.Color.Green;
            this.button4Custom.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateCheckedTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button4Custom.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateCheckedTracking.Border.Rounding = 3F;
            this.button4Custom.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.button4Custom.StateNormal.Back.Color2 = System.Drawing.Color.LightSteelBlue;
            this.button4Custom.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.button4Custom.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.StateNormal.Border.Color1 = System.Drawing.Color.CornflowerBlue;
            this.button4Custom.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button4Custom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateNormal.Border.Rounding = 3F;
            this.button4Custom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button4Custom.StatePressed.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.button4Custom.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.button4Custom.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.StatePressed.Border.Color1 = System.Drawing.Color.CornflowerBlue;
            this.button4Custom.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button4Custom.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StatePressed.Border.Rounding = 3F;
            this.button4Custom.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.button4Custom.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button4Custom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut;
            this.button4Custom.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Custom.StateTracking.Border.Color1 = System.Drawing.Color.CornflowerBlue;
            this.button4Custom.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Custom.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Custom.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button4Custom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.button4Custom.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Custom.StateTracking.Border.Rounding = 3F;
            this.button4Custom.TabIndex = 2;
            this.button4Custom.Values.ExtraText = "ExtraText";
            this.button4Custom.Values.Image = ((System.Drawing.Image)(resources.GetObject("button4Custom.Values.Image")));
            this.button4Custom.Values.Text = "Text";
            this.button4Custom.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // groupBoxSparkle
            // 
            this.groupBoxSparkle.Controls.Add(this.button6Sparkle);
            this.groupBoxSparkle.Controls.Add(this.button4Sparkle);
            this.groupBoxSparkle.Controls.Add(this.button5Sparkle);
            this.groupBoxSparkle.Controls.Add(this.button1Sparkle);
            this.groupBoxSparkle.Controls.Add(this.button2Sparkle);
            this.groupBoxSparkle.Controls.Add(this.button3Sparkle);
            this.groupBoxSparkle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSparkle.Name = "groupBoxSparkle";
            this.groupBoxSparkle.Size = new System.Drawing.Size(223, 153);
            this.groupBoxSparkle.TabIndex = 0;
            this.groupBoxSparkle.TabStop = false;
            this.groupBoxSparkle.Text = "Sparkle - Blue";
            // 
            // button6Sparkle
            // 
            this.button6Sparkle.AutoSize = true;
            this.button6Sparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button6Sparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button6Sparkle.Location = new System.Drawing.Point(80, 27);
            this.button6Sparkle.Name = "button6Sparkle";
            this.button6Sparkle.Orientation = Krypton.Toolkit.VisualOrientation.Left;
            this.button6Sparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.button6Sparkle.Size = new System.Drawing.Size(31, 110);
            this.button6Sparkle.TabIndex = 3;
            this.button6Sparkle.Values.ExtraText = "Left";
            this.button6Sparkle.Values.Image = ((System.Drawing.Image)(resources.GetObject("button6Sparkle.Values.Image")));
            this.button6Sparkle.Values.Text = "Direction";
            this.button6Sparkle.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button4Sparkle
            // 
            this.button4Sparkle.AutoSize = true;
            this.button4Sparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button4Sparkle.Checked = true;
            this.button4Sparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button4Sparkle.Location = new System.Drawing.Point(142, 27);
            this.button4Sparkle.Name = "button4Sparkle";
            this.button4Sparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button4Sparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.button4Sparkle.Size = new System.Drawing.Size(70, 58);
            this.button4Sparkle.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Sparkle.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Sparkle.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button4Sparkle.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4Sparkle.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4Sparkle.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button4Sparkle.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4Sparkle.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button4Sparkle.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button4Sparkle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button4Sparkle.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button4Sparkle.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4Sparkle.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button4Sparkle.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button4Sparkle.TabIndex = 4;
            this.button4Sparkle.Values.ExtraText = "ExtraText";
            this.button4Sparkle.Values.Image = ((System.Drawing.Image)(resources.GetObject("button4Sparkle.Values.Image")));
            this.button4Sparkle.Values.Text = "Text";
            // 
            // button5Sparkle
            // 
            this.button5Sparkle.AutoSize = true;
            this.button5Sparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button5Sparkle.Checked = true;
            this.button5Sparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button5Sparkle.Location = new System.Drawing.Point(124, 100);
            this.button5Sparkle.Name = "button5Sparkle";
            this.button5Sparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button5Sparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.button5Sparkle.Size = new System.Drawing.Size(88, 42);
            this.button5Sparkle.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Sparkle.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Sparkle.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button5Sparkle.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5Sparkle.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Sparkle.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Sparkle.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Sparkle.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5Sparkle.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Sparkle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5Sparkle.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5Sparkle.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Sparkle.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5Sparkle.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5Sparkle.TabIndex = 5;
            this.button5Sparkle.Values.ExtraText = "ExtraText";
            this.button5Sparkle.Values.Image = ((System.Drawing.Image)(resources.GetObject("button5Sparkle.Values.Image")));
            this.button5Sparkle.Values.Text = "Text";
            this.button5Sparkle.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button1Sparkle
            // 
            this.button1Sparkle.AutoSize = true;
            this.button1Sparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button1Sparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1Sparkle.Location = new System.Drawing.Point(12, 27);
            this.button1Sparkle.Name = "button1Sparkle";
            this.button1Sparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button1Sparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.button1Sparkle.Size = new System.Drawing.Size(40, 38);
            this.button1Sparkle.TabIndex = 0;
            this.button1Sparkle.Values.Image = ((System.Drawing.Image)(resources.GetObject("button1Sparkle.Values.Image")));
            this.button1Sparkle.Values.Text = "";
            this.button1Sparkle.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button2Sparkle
            // 
            this.button2Sparkle.AutoSize = true;
            this.button2Sparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button2Sparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2Sparkle.Location = new System.Drawing.Point(12, 74);
            this.button2Sparkle.Name = "button2Sparkle";
            this.button2Sparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button2Sparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.button2Sparkle.Size = new System.Drawing.Size(40, 24);
            this.button2Sparkle.TabIndex = 1;
            this.button2Sparkle.Values.Text = "Text";
            this.button2Sparkle.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button3Sparkle
            // 
            this.button3Sparkle.AutoSize = true;
            this.button3Sparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button3Sparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button3Sparkle.Location = new System.Drawing.Point(12, 107);
            this.button3Sparkle.Name = "button3Sparkle";
            this.button3Sparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button3Sparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.button3Sparkle.Size = new System.Drawing.Size(55, 30);
            this.button3Sparkle.TabIndex = 2;
            this.button3Sparkle.Values.Image = ((System.Drawing.Image)(resources.GetObject("button3Sparkle.Values.Image")));
            this.button3Sparkle.Values.Text = "Text";
            this.button3Sparkle.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // groupBoxOffice2007
            // 
            this.groupBoxOffice2007.Controls.Add(this.button6System);
            this.groupBoxOffice2007.Controls.Add(this.button4System);
            this.groupBoxOffice2007.Controls.Add(this.button5System);
            this.groupBoxOffice2007.Controls.Add(this.button1System);
            this.groupBoxOffice2007.Controls.Add(this.button2System);
            this.groupBoxOffice2007.Controls.Add(this.button3System);
            this.groupBoxOffice2007.Location = new System.Drawing.Point(12, 171);
            this.groupBoxOffice2007.Name = "groupBoxOffice2007";
            this.groupBoxOffice2007.Size = new System.Drawing.Size(225, 153);
            this.groupBoxOffice2007.TabIndex = 1;
            this.groupBoxOffice2007.TabStop = false;
            this.groupBoxOffice2007.Text = "Office 2007 - Blue";
            // 
            // button6System
            // 
            this.button6System.AutoSize = true;
            this.button6System.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button6System.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button6System.Location = new System.Drawing.Point(80, 27);
            this.button6System.Name = "button6System";
            this.button6System.Orientation = Krypton.Toolkit.VisualOrientation.Left;
            this.button6System.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.button6System.Size = new System.Drawing.Size(31, 110);
            this.button6System.TabIndex = 3;
            this.button6System.Values.ExtraText = "Left";
            this.button6System.Values.Image = ((System.Drawing.Image)(resources.GetObject("button6System.Values.Image")));
            this.button6System.Values.Text = "Direction";
            this.button6System.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button4System
            // 
            this.button4System.AutoSize = true;
            this.button4System.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button4System.Checked = true;
            this.button4System.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button4System.Location = new System.Drawing.Point(142, 27);
            this.button4System.Name = "button4System";
            this.button4System.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button4System.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.button4System.Size = new System.Drawing.Size(70, 58);
            this.button4System.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button4System.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button4System.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button4System.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4System.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4System.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4System.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4System.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button4System.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4System.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4System.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button4System.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button4System.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button4System.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4System.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button4System.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button4System.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button4System.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4System.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button4System.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button4System.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button4System.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button4System.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button4System.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button4System.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button4System.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button4System.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button4System.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button4System.TabIndex = 4;
            this.button4System.Values.ExtraText = "ExtraText";
            this.button4System.Values.Image = ((System.Drawing.Image)(resources.GetObject("button4System.Values.Image")));
            this.button4System.Values.Text = "Text";
            this.button4System.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button5System
            // 
            this.button5System.AutoSize = true;
            this.button5System.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button5System.Checked = true;
            this.button5System.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button5System.Location = new System.Drawing.Point(124, 100);
            this.button5System.Name = "button5System";
            this.button5System.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button5System.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.button5System.Size = new System.Drawing.Size(88, 42);
            this.button5System.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.button5System.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.button5System.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.button5System.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button5System.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5System.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5System.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5System.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5System.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5System.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5System.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5System.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5System.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5System.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5System.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.button5System.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5System.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.button5System.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5System.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.button5System.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.button5System.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.button5System.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.button5System.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.button5System.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.button5System.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.button5System.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5System.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.button5System.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.button5System.TabIndex = 5;
            this.button5System.Values.ExtraText = "ExtraText";
            this.button5System.Values.Image = ((System.Drawing.Image)(resources.GetObject("button5System.Values.Image")));
            this.button5System.Values.Text = "Text";
            this.button5System.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button1System
            // 
            this.button1System.AutoSize = true;
            this.button1System.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button1System.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1System.Location = new System.Drawing.Point(12, 27);
            this.button1System.Name = "button1System";
            this.button1System.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button1System.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.button1System.Size = new System.Drawing.Size(42, 40);
            this.button1System.TabIndex = 0;
            this.button1System.Values.Image = ((System.Drawing.Image)(resources.GetObject("button1System.Values.Image")));
            this.button1System.Values.Text = "";
            this.button1System.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button2System
            // 
            this.button2System.AutoSize = true;
            this.button2System.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button2System.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2System.Location = new System.Drawing.Point(12, 74);
            this.button2System.Name = "button2System";
            this.button2System.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button2System.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.button2System.Size = new System.Drawing.Size(40, 25);
            this.button2System.TabIndex = 1;
            this.button2System.Values.Text = "Text";
            this.button2System.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // button3System
            // 
            this.button3System.AutoSize = true;
            this.button3System.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.button3System.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button3System.Location = new System.Drawing.Point(12, 107);
            this.button3System.Name = "button3System";
            this.button3System.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.button3System.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.button3System.Size = new System.Drawing.Size(55, 30);
            this.button3System.TabIndex = 2;
            this.button3System.Values.Image = ((System.Drawing.Image)(resources.GetObject("button3System.Values.Image")));
            this.button3System.Values.Text = "Text";
            this.button3System.Enter += new System.EventHandler(this.checkButton_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(581, 569);
            this.Controls.Add(this.groupBoxOffice2007);
            this.Controls.Add(this.groupBoxSparkle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxCustom);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonCheckButton Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBoxCustom.ResumeLayout(false);
            this.groupBoxCustom.PerformLayout();
            this.groupBoxSparkle.ResumeLayout(false);
            this.groupBoxSparkle.PerformLayout();
            this.groupBoxOffice2007.ResumeLayout(false);
            this.groupBoxOffice2007.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBoxCustom;
        private Krypton.Toolkit.KryptonCheckButton button5Custom;
        private Krypton.Toolkit.KryptonCheckButton button2Custom;
        private Krypton.Toolkit.KryptonCheckButton button3Custom;
        private Krypton.Toolkit.KryptonCheckButton button4Custom;
        private System.Windows.Forms.GroupBox groupBoxSparkle;
        private Krypton.Toolkit.KryptonCheckButton button6Sparkle;
        private Krypton.Toolkit.KryptonCheckButton button4Sparkle;
        private Krypton.Toolkit.KryptonCheckButton button5Sparkle;
        private Krypton.Toolkit.KryptonCheckButton button1Sparkle;
        private Krypton.Toolkit.KryptonCheckButton button2Sparkle;
        private Krypton.Toolkit.KryptonCheckButton button3Sparkle;
        private System.Windows.Forms.GroupBox groupBoxOffice2007;
        private Krypton.Toolkit.KryptonCheckButton button6System;
        private Krypton.Toolkit.KryptonCheckButton button4System;
        private Krypton.Toolkit.KryptonCheckButton button5System;
        private Krypton.Toolkit.KryptonCheckButton button1System;
        private Krypton.Toolkit.KryptonCheckButton button2System;
        private Krypton.Toolkit.KryptonCheckButton button3System;
        private Krypton.Toolkit.KryptonCheckButton button1Custom;
    }
}

