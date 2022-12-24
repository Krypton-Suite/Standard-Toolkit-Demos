namespace NavigatorPalettes
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
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage3 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage4 = new Krypton.Navigator.KryptonPage();
            this.groupBoxPalettes = new System.Windows.Forms.GroupBox();
            this.radioOffice2010Black = new System.Windows.Forms.RadioButton();
            this.radioOffice2010Silver = new System.Windows.Forms.RadioButton();
            this.radioOffice2010Blue = new System.Windows.Forms.RadioButton();
            this.radioSparklePurple = new System.Windows.Forms.RadioButton();
            this.radioSparkleOrange = new System.Windows.Forms.RadioButton();
            this.radioSparkleBlue = new System.Windows.Forms.RadioButton();
            this.radioOffice2007Black = new System.Windows.Forms.RadioButton();
            this.radioOffice2007Silver = new System.Windows.Forms.RadioButton();
            this.radioOffice2007Blue = new System.Windows.Forms.RadioButton();
            this.radioLightweight = new System.Windows.Forms.RadioButton();
            this.radioBlogger = new System.Windows.Forms.RadioButton();
            this.radioOffice2003 = new System.Windows.Forms.RadioButton();
            this.radioSystem = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kryptonPaletteBlogger = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonPaletteLightweight = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            this.groupBoxPalettes.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context;
            this.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePage;
            this.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage;
            this.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.kryptonNavigator1.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonNavigator1.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonNavigator1.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kryptonNavigator1.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonNavigator1.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary;
            this.kryptonNavigator1.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonNavigator1.Location = new System.Drawing.Point(236, 18);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2,
            this.kryptonPage3,
            this.kryptonPage4});
            this.kryptonNavigator1.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(378, 321);
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonNavigator1.TabIndex = 1;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage1.ImageLarge")));
            this.kryptonPage1.ImageMedium = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage1.ImageMedium")));
            this.kryptonPage1.ImageSmall = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage1.ImageSmall")));
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(376, 289);
            this.kryptonPage1.Text = "Page 1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "D14D70B626614AABD14D70B626614AAB";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage2.ImageLarge")));
            this.kryptonPage2.ImageMedium = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage2.ImageMedium")));
            this.kryptonPage2.ImageSmall = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage2.ImageSmall")));
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(376, 222);
            this.kryptonPage2.Text = "Page 2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "707E46AE53D14CCD707E46AE53D14CCD";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage3.ImageLarge")));
            this.kryptonPage3.ImageMedium = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage3.ImageMedium")));
            this.kryptonPage3.ImageSmall = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage3.ImageSmall")));
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(376, 222);
            this.kryptonPage3.Text = "Page 3";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "06E429CAACE4494506E429CAACE44945";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage4.ImageLarge")));
            this.kryptonPage4.ImageMedium = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage4.ImageMedium")));
            this.kryptonPage4.ImageSmall = ((System.Drawing.Bitmap)(resources.GetObject("kryptonPage4.ImageSmall")));
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(376, 222);
            this.kryptonPage4.Text = "Page 4";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "361135F47DDF496C361135F47DDF496C";
            // 
            // groupBoxPalettes
            // 
            this.groupBoxPalettes.Controls.Add(this.radioOffice2010Black);
            this.groupBoxPalettes.Controls.Add(this.radioOffice2010Silver);
            this.groupBoxPalettes.Controls.Add(this.radioOffice2010Blue);
            this.groupBoxPalettes.Controls.Add(this.radioSparklePurple);
            this.groupBoxPalettes.Controls.Add(this.radioSparkleOrange);
            this.groupBoxPalettes.Controls.Add(this.radioSparkleBlue);
            this.groupBoxPalettes.Controls.Add(this.radioOffice2007Black);
            this.groupBoxPalettes.Controls.Add(this.radioOffice2007Silver);
            this.groupBoxPalettes.Controls.Add(this.radioOffice2007Blue);
            this.groupBoxPalettes.Controls.Add(this.radioLightweight);
            this.groupBoxPalettes.Controls.Add(this.radioBlogger);
            this.groupBoxPalettes.Controls.Add(this.radioOffice2003);
            this.groupBoxPalettes.Controls.Add(this.radioSystem);
            this.groupBoxPalettes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPalettes.Name = "groupBoxPalettes";
            this.groupBoxPalettes.Size = new System.Drawing.Size(207, 327);
            this.groupBoxPalettes.TabIndex = 0;
            this.groupBoxPalettes.TabStop = false;
            this.groupBoxPalettes.Text = "Palettes";
            // 
            // radioOffice2010Black
            // 
            this.radioOffice2010Black.AutoSize = true;
            this.radioOffice2010Black.Location = new System.Drawing.Point(15, 66);
            this.radioOffice2010Black.Name = "radioOffice2010Black";
            this.radioOffice2010Black.Size = new System.Drawing.Size(115, 17);
            this.radioOffice2010Black.TabIndex = 12;
            this.radioOffice2010Black.Text = "Office 2010 - Black";
            this.radioOffice2010Black.UseVisualStyleBackColor = true;
            this.radioOffice2010Black.CheckedChanged += new System.EventHandler(this.radioOffice2010Black_CheckedChanged);
            // 
            // radioOffice2010Silver
            // 
            this.radioOffice2010Silver.AutoSize = true;
            this.radioOffice2010Silver.Location = new System.Drawing.Point(15, 43);
            this.radioOffice2010Silver.Name = "radioOffice2010Silver";
            this.radioOffice2010Silver.Size = new System.Drawing.Size(117, 17);
            this.radioOffice2010Silver.TabIndex = 11;
            this.radioOffice2010Silver.Text = "Office 2010 - Silver";
            this.radioOffice2010Silver.UseVisualStyleBackColor = true;
            this.radioOffice2010Silver.CheckedChanged += new System.EventHandler(this.radioOffice2010Silver_CheckedChanged);
            // 
            // radioOffice2010Blue
            // 
            this.radioOffice2010Blue.AutoSize = true;
            this.radioOffice2010Blue.Location = new System.Drawing.Point(15, 20);
            this.radioOffice2010Blue.Name = "radioOffice2010Blue";
            this.radioOffice2010Blue.Size = new System.Drawing.Size(111, 17);
            this.radioOffice2010Blue.TabIndex = 10;
            this.radioOffice2010Blue.Text = "Office 2010 - Blue";
            this.radioOffice2010Blue.UseVisualStyleBackColor = true;
            this.radioOffice2010Blue.CheckedChanged += new System.EventHandler(this.radioOffice2010Blue_CheckedChanged);
            // 
            // radioSparklePurple
            // 
            this.radioSparklePurple.AutoSize = true;
            this.radioSparklePurple.Location = new System.Drawing.Point(15, 250);
            this.radioSparklePurple.Name = "radioSparklePurple";
            this.radioSparklePurple.Size = new System.Drawing.Size(100, 17);
            this.radioSparklePurple.TabIndex = 7;
            this.radioSparklePurple.Text = "Sparkle - Purple";
            this.radioSparklePurple.UseVisualStyleBackColor = true;
            this.radioSparklePurple.CheckedChanged += new System.EventHandler(this.radioSparklePurple_CheckedChanged);
            // 
            // radioSparkleOrange
            // 
            this.radioSparkleOrange.AutoSize = true;
            this.radioSparkleOrange.Location = new System.Drawing.Point(15, 227);
            this.radioSparkleOrange.Name = "radioSparkleOrange";
            this.radioSparkleOrange.Size = new System.Drawing.Size(106, 17);
            this.radioSparkleOrange.TabIndex = 6;
            this.radioSparkleOrange.Text = "Sparkle - Orange";
            this.radioSparkleOrange.UseVisualStyleBackColor = true;
            this.radioSparkleOrange.CheckedChanged += new System.EventHandler(this.radioSparkleOrange_CheckedChanged);
            // 
            // radioSparkleBlue
            // 
            this.radioSparkleBlue.AutoSize = true;
            this.radioSparkleBlue.Checked = true;
            this.radioSparkleBlue.Location = new System.Drawing.Point(15, 204);
            this.radioSparkleBlue.Name = "radioSparkleBlue";
            this.radioSparkleBlue.Size = new System.Drawing.Size(90, 17);
            this.radioSparkleBlue.TabIndex = 5;
            this.radioSparkleBlue.TabStop = true;
            this.radioSparkleBlue.Text = "Sparkle - Blue";
            this.radioSparkleBlue.UseVisualStyleBackColor = true;
            this.radioSparkleBlue.CheckedChanged += new System.EventHandler(this.radioSparkleBlue_CheckedChanged);
            // 
            // radioOffice2007Black
            // 
            this.radioOffice2007Black.AutoSize = true;
            this.radioOffice2007Black.Location = new System.Drawing.Point(15, 135);
            this.radioOffice2007Black.Name = "radioOffice2007Black";
            this.radioOffice2007Black.Size = new System.Drawing.Size(115, 17);
            this.radioOffice2007Black.TabIndex = 2;
            this.radioOffice2007Black.Text = "Office 2007 - Black";
            this.radioOffice2007Black.UseVisualStyleBackColor = true;
            this.radioOffice2007Black.CheckedChanged += new System.EventHandler(this.radioOffice2007Black_CheckedChanged);
            // 
            // radioOffice2007Silver
            // 
            this.radioOffice2007Silver.AutoSize = true;
            this.radioOffice2007Silver.Location = new System.Drawing.Point(15, 112);
            this.radioOffice2007Silver.Name = "radioOffice2007Silver";
            this.radioOffice2007Silver.Size = new System.Drawing.Size(117, 17);
            this.radioOffice2007Silver.TabIndex = 1;
            this.radioOffice2007Silver.Text = "Office 2007 - Silver";
            this.radioOffice2007Silver.UseVisualStyleBackColor = true;
            this.radioOffice2007Silver.CheckedChanged += new System.EventHandler(this.radioOffice2007Silver_CheckedChanged);
            // 
            // radioOffice2007Blue
            // 
            this.radioOffice2007Blue.AutoSize = true;
            this.radioOffice2007Blue.Location = new System.Drawing.Point(15, 89);
            this.radioOffice2007Blue.Name = "radioOffice2007Blue";
            this.radioOffice2007Blue.Size = new System.Drawing.Size(111, 17);
            this.radioOffice2007Blue.TabIndex = 0;
            this.radioOffice2007Blue.Text = "Office 2007 - Blue";
            this.radioOffice2007Blue.UseVisualStyleBackColor = true;
            this.radioOffice2007Blue.CheckedChanged += new System.EventHandler(this.radioOffice2007Blue_CheckedChanged);
            // 
            // radioLightweight
            // 
            this.radioLightweight.AutoSize = true;
            this.radioLightweight.Location = new System.Drawing.Point(15, 296);
            this.radioLightweight.Name = "radioLightweight";
            this.radioLightweight.Size = new System.Drawing.Size(119, 17);
            this.radioLightweight.TabIndex = 9;
            this.radioLightweight.Text = "Custom Lightweight";
            this.radioLightweight.UseVisualStyleBackColor = true;
            this.radioLightweight.CheckedChanged += new System.EventHandler(this.radioLightweight_CheckedChanged);
            // 
            // radioBlogger
            // 
            this.radioBlogger.AutoSize = true;
            this.radioBlogger.Location = new System.Drawing.Point(15, 273);
            this.radioBlogger.Name = "radioBlogger";
            this.radioBlogger.Size = new System.Drawing.Size(100, 17);
            this.radioBlogger.TabIndex = 8;
            this.radioBlogger.Text = "Custom Blogger";
            this.radioBlogger.UseVisualStyleBackColor = true;
            this.radioBlogger.CheckedChanged += new System.EventHandler(this.radioBlogger_CheckedChanged);
            // 
            // radioOffice2003
            // 
            this.radioOffice2003.AutoSize = true;
            this.radioOffice2003.Location = new System.Drawing.Point(15, 158);
            this.radioOffice2003.Name = "radioOffice2003";
            this.radioOffice2003.Size = new System.Drawing.Size(149, 17);
            this.radioOffice2003.TabIndex = 3;
            this.radioOffice2003.Text = "Professional - Office 2003";
            this.radioOffice2003.UseVisualStyleBackColor = true;
            this.radioOffice2003.CheckedChanged += new System.EventHandler(this.radioOffice2003_CheckedChanged);
            // 
            // radioSystem
            // 
            this.radioSystem.AutoSize = true;
            this.radioSystem.Location = new System.Drawing.Point(15, 181);
            this.radioSystem.Name = "radioSystem";
            this.radioSystem.Size = new System.Drawing.Size(128, 17);
            this.radioSystem.TabIndex = 4;
            this.radioSystem.Text = "Professional - System";
            this.radioSystem.UseVisualStyleBackColor = true;
            this.radioSystem.CheckedChanged += new System.EventHandler(this.radioSystem_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(539, 356);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kryptonPaletteBlogger
            // 
            this.kryptonPaletteBlogger.AllowFormChrome = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonPaletteBlogger.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3F;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9F;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.Width = 3;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderGroup.StateCommon.DockActiveHeaderPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.HeaderGroup.StateCommon.DockInactiveHeaderPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.HeaderGroup.StateCommon.PrimaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteBlogger.HeaderGroup.StateCommon.SecondaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7F;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.Width = 2;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Content.Padding = new System.Windows.Forms.Padding(4, 6, 2, 4);
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.QuarterPhase;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent;
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White;
            this.kryptonPaletteBlogger.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteBlogger.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent;
            this.kryptonPaletteBlogger.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteBlogger.ToolMenuStatus.UseRoundedEdges = Krypton.Toolkit.InheritBool.False;
            // 
            // kryptonPaletteLightweight
            // 
            this.kryptonPaletteLightweight.AllowFormChrome = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteLightweight.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPaletteLightweight.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 4F;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 1;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 6F;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Width = 1;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderGroup.StateCommon.DockActiveHeaderPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderGroup.StateCommon.DockInactiveHeaderPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteLightweight.HeaderGroup.StateCommon.PrimaryHeaderPadding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.kryptonPaletteLightweight.HeaderGroup.StateCommon.SecondaryHeaderPadding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.Color1 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.QuarterPhase;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 394);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxPalettes);
            this.Controls.Add(this.kryptonNavigator1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Navigator Palettes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            this.groupBoxPalettes.ResumeLayout(false);
            this.groupBoxPalettes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Navigator.KryptonPage kryptonPage3;
        private Krypton.Navigator.KryptonPage kryptonPage4;
        private System.Windows.Forms.GroupBox groupBoxPalettes;
        private System.Windows.Forms.RadioButton radioLightweight;
        private System.Windows.Forms.RadioButton radioBlogger;
        private System.Windows.Forms.RadioButton radioOffice2003;
        private System.Windows.Forms.RadioButton radioSystem;
        private System.Windows.Forms.Button buttonClose;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonPaletteBlogger;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonPaletteLightweight;
        private System.Windows.Forms.RadioButton radioOffice2007Black;
        private System.Windows.Forms.RadioButton radioOffice2007Silver;
        private System.Windows.Forms.RadioButton radioOffice2007Blue;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.RadioButton radioSparkleBlue;
        private System.Windows.Forms.RadioButton radioSparklePurple;
        private System.Windows.Forms.RadioButton radioSparkleOrange;
        private System.Windows.Forms.RadioButton radioOffice2010Black;
        private System.Windows.Forms.RadioButton radioOffice2010Silver;
        private System.Windows.Forms.RadioButton radioOffice2010Blue;
    }
}

