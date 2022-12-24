namespace CustomControlUsingPalettes
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
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.buttonSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.buttonSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckSet = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.buttonCustom = new Krypton.Toolkit.KryptonCheckButton();
            this.buttonOffice2010Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.buttonOffice2007Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.groupBoxPalettes = new System.Windows.Forms.GroupBox();
            this.groupBoxCustomControl = new System.Windows.Forms.GroupBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.myUserControl1 = new CustomControlUsingPalettes.MyUserControl();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kryptonPaletteCustom = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).BeginInit();
            this.groupBoxPalettes.SuspendLayout();
            this.groupBoxCustomControl.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // buttonSparkle
            // 
            this.buttonSparkle.AutoSize = true;
            this.buttonSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSparkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSparkle.Location = new System.Drawing.Point(20, 98);
            this.buttonSparkle.Name = "buttonSparkle";
            this.buttonSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonSparkle.Size = new System.Drawing.Size(127, 27);
            this.buttonSparkle.TabIndex = 2;
            this.buttonSparkle.Values.Text = "Sparkle - Blue";
            // 
            // buttonSystem
            // 
            this.buttonSystem.AutoSize = true;
            this.buttonSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSystem.Location = new System.Drawing.Point(20, 131);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonSystem.Size = new System.Drawing.Size(127, 27);
            this.buttonSystem.TabIndex = 3;
            this.buttonSystem.Values.Text = "System";
            // 
            // kryptonCheckSet
            // 
            this.kryptonCheckSet.CheckButtons.Add(this.buttonSparkle);
            this.kryptonCheckSet.CheckButtons.Add(this.buttonSystem);
            this.kryptonCheckSet.CheckButtons.Add(this.buttonCustom);
            this.kryptonCheckSet.CheckButtons.Add(this.buttonOffice2010Blue);
            this.kryptonCheckSet.CheckButtons.Add(this.buttonOffice2007Blue);
            this.kryptonCheckSet.CheckedButton = this.buttonOffice2010Blue;
            this.kryptonCheckSet.CheckedButtonChanged += new System.EventHandler(this.kryptonCheckSet_CheckedButtonChanged);
            // 
            // buttonCustom
            // 
            this.buttonCustom.AutoSize = true;
            this.buttonCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonCustom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCustom.Location = new System.Drawing.Point(20, 164);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonCustom.Size = new System.Drawing.Size(127, 27);
            this.buttonCustom.TabIndex = 4;
            this.buttonCustom.Values.Text = "Custom";
            // 
            // buttonOffice2010Blue
            // 
            this.buttonOffice2010Blue.AutoSize = true;
            this.buttonOffice2010Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonOffice2010Blue.Checked = true;
            this.buttonOffice2010Blue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonOffice2010Blue.Location = new System.Drawing.Point(20, 32);
            this.buttonOffice2010Blue.Name = "buttonOffice2010Blue";
            this.buttonOffice2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonOffice2010Blue.Size = new System.Drawing.Size(127, 27);
            this.buttonOffice2010Blue.TabIndex = 0;
            this.buttonOffice2010Blue.Values.Text = "Office 2010 - Blue";
            // 
            // buttonOffice2007Blue
            // 
            this.buttonOffice2007Blue.AutoSize = true;
            this.buttonOffice2007Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonOffice2007Blue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonOffice2007Blue.Location = new System.Drawing.Point(20, 65);
            this.buttonOffice2007Blue.Name = "buttonOffice2007Blue";
            this.buttonOffice2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonOffice2007Blue.Size = new System.Drawing.Size(127, 27);
            this.buttonOffice2007Blue.TabIndex = 1;
            this.buttonOffice2007Blue.Values.Text = "Office 2007 - Blue";
            // 
            // groupBoxPalettes
            // 
            this.groupBoxPalettes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPalettes.Controls.Add(this.buttonOffice2010Blue);
            this.groupBoxPalettes.Controls.Add(this.buttonSystem);
            this.groupBoxPalettes.Controls.Add(this.buttonOffice2007Blue);
            this.groupBoxPalettes.Controls.Add(this.buttonCustom);
            this.groupBoxPalettes.Controls.Add(this.buttonSparkle);
            this.groupBoxPalettes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPalettes.Name = "groupBoxPalettes";
            this.groupBoxPalettes.Size = new System.Drawing.Size(170, 222);
            this.groupBoxPalettes.TabIndex = 0;
            this.groupBoxPalettes.TabStop = false;
            this.groupBoxPalettes.Text = "Palettes";
            // 
            // groupBoxCustomControl
            // 
            this.groupBoxCustomControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomControl.Controls.Add(this.checkBoxEnabled);
            this.groupBoxCustomControl.Controls.Add(this.myUserControl1);
            this.groupBoxCustomControl.Location = new System.Drawing.Point(188, 13);
            this.groupBoxCustomControl.Name = "groupBoxCustomControl";
            this.groupBoxCustomControl.Size = new System.Drawing.Size(262, 221);
            this.groupBoxCustomControl.TabIndex = 1;
            this.groupBoxCustomControl.TabStop = false;
            this.groupBoxCustomControl.Text = "MyCustomControl Instance";
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Checked = true;
            this.checkBoxEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabled.Location = new System.Drawing.Point(15, 190);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(64, 17);
            this.checkBoxEnabled.TabIndex = 1;
            this.checkBoxEnabled.Text = "Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // myUserControl1
            // 
            this.myUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myUserControl1.Location = new System.Drawing.Point(15, 31);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(228, 148);
            this.myUserControl1.TabIndex = 0;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescription.Controls.Add(this.textBox1);
            this.groupBoxDescription.Location = new System.Drawing.Point(12, 241);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxDescription.Size = new System.Drawing.Size(438, 156);
            this.groupBoxDescription.TabIndex = 2;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(5, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(428, 132);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 403);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kryptonPaletteCustom
            // 
            this.kryptonPaletteCustom.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonPaletteCustom.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = System.Drawing.Color.Fuchsia;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Fuchsia;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color2 = System.Drawing.Color.Fuchsia;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAngle = 60F;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color2 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = System.Drawing.Color.Yellow;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.Color1 = System.Drawing.Color.Olive;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Berlin Sans FB", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.Color2 = System.Drawing.Color.GreenYellow;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 432);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxCustomControl);
            this.Controls.Add(this.groupBoxPalettes);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 466);
            this.Name = "Form1";
            this.Text = "Custom Control using Palettes";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).EndInit();
            this.groupBoxPalettes.ResumeLayout(false);
            this.groupBoxPalettes.PerformLayout();
            this.groupBoxCustomControl.ResumeLayout(false);
            this.groupBoxCustomControl.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl myUserControl1;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonCheckButton buttonSparkle;
        private Krypton.Toolkit.KryptonCheckButton buttonSystem;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet;
        private System.Windows.Forms.GroupBox groupBoxPalettes;
        private System.Windows.Forms.GroupBox groupBoxCustomControl;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonPaletteCustom;
        private Krypton.Toolkit.KryptonCheckButton buttonCustom;
        private System.Windows.Forms.TextBox textBox1;
        private Krypton.Toolkit.KryptonCheckButton buttonOffice2010Blue;
        private Krypton.Toolkit.KryptonCheckButton buttonOffice2007Blue;
    }
}

