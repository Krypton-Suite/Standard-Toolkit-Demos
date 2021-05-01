namespace MDIRibbon
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
            this.ribbon = new .Ribbon.KryptonRibbon();
            this.buttonSpecHelp = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.tabHome = new .Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new .Ribbon.KryptonRibbonGroupTriple();
            this.buttonNewWindow = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new .Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new .Ribbon.KryptonRibbonGroupTriple();
            this.buttonCloseWindow = new .Ribbon.KryptonRibbonGroupButton();
            this.buttonCloseAllWindows = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup1 = new .Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new .Ribbon.KryptonRibbonGroupTriple();
            this.buttonCascade = new .Ribbon.KryptonRibbonGroupButton();
            this.buttonTileHorizontal = new .Ribbon.KryptonRibbonGroupButton();
            this.buttonTileVertical = new .Ribbon.KryptonRibbonGroupButton();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowFormIntegrate = true;
            this.ribbon.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecHelp});
            this.ribbon.InDesignHelperMode = true;
            this.ribbon.Name = "ribbon";
            this.ribbon.QATLocation = .Ribbon.QATLocation.Hidden;
            this.ribbon.RibbonAppButton.AppButtonMenuItems.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            this.ribbon.RibbonAppButton.AppButtonShowRecentDocs = false;
            this.ribbon.RibbonTabs.AddRange(new .Ribbon.KryptonRibbonTab[] {
            this.tabHome});
            this.ribbon.SelectedContext = null;
            this.ribbon.SelectedTab = this.tabHome;
            this.ribbon.Size = new System.Drawing.Size(692, 115);
            this.ribbon.TabIndex = 0;
            // 
            // buttonSpecHelp
            // 
            this.buttonSpecHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecHelp.Image")));
            this.buttonSpecHelp.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this.buttonSpecHelp.UniqueName = "06E98F3735BC4B1106E98F3735BC4B11";
            this.buttonSpecHelp.Click += new System.EventHandler(this.buttonSpecHelp_Click);
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem1.Image")));
            this.kryptonContextMenuItem1.Text = "E&xit";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.appMenu_Click);
            // 
            // tabHome
            // 
            this.tabHome.Groups.AddRange(new .Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup1});
            this.tabHome.KeyTip = "H";
            this.tabHome.Text = "Home";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup2.Image")));
            this.kryptonRibbonGroup2.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup2.KeyTipGroup = "O";
            this.kryptonRibbonGroup2.TextLine1 = "Operations";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.buttonNewWindow});
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonNewWindow.ImageLarge")));
            this.buttonNewWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonNewWindow.ImageSmall")));
            this.buttonNewWindow.KeyTip = "N";
            this.buttonNewWindow.TextLine1 = "New";
            this.buttonNewWindow.TextLine2 = "Window";
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.buttonCloseWindow,
            this.buttonCloseAllWindows});
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.ImageLarge")));
            this.buttonCloseWindow.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.ImageSmall")));
            this.buttonCloseWindow.KeyTip = "X";
            this.buttonCloseWindow.TextLine1 = "Close";
            this.buttonCloseWindow.TextLine2 = "Window";
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonCloseAllWindows
            // 
            this.buttonCloseAllWindows.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonCloseAllWindows.ImageLarge")));
            this.buttonCloseAllWindows.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonCloseAllWindows.ImageSmall")));
            this.buttonCloseAllWindows.KeyTip = "A";
            this.buttonCloseAllWindows.TextLine1 = "Close All";
            this.buttonCloseAllWindows.TextLine2 = "Windows";
            this.buttonCloseAllWindows.Click += new System.EventHandler(this.buttonCloseAllWindows_Click);
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroup1.Image")));
            this.kryptonRibbonGroup1.Items.AddRange(new .Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup1.KeyTipGroup = "A";
            this.kryptonRibbonGroup1.TextLine1 = "Arrange";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new .Ribbon.KryptonRibbonGroupItem[] {
            this.buttonCascade,
            this.buttonTileHorizontal,
            this.buttonTileVertical});
            // 
            // buttonCascade
            // 
            this.buttonCascade.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonCascade.ImageLarge")));
            this.buttonCascade.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonCascade.ImageSmall")));
            this.buttonCascade.KeyTip = "C";
            this.buttonCascade.TextLine1 = "Cascade";
            this.buttonCascade.Click += new System.EventHandler(this.buttonCascade_Click);
            // 
            // buttonTileHorizontal
            // 
            this.buttonTileHorizontal.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonTileHorizontal.ImageLarge")));
            this.buttonTileHorizontal.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonTileHorizontal.ImageSmall")));
            this.buttonTileHorizontal.KeyTip = "H";
            this.buttonTileHorizontal.TextLine1 = "Tile";
            this.buttonTileHorizontal.TextLine2 = "Horizontal";
            this.buttonTileHorizontal.Click += new System.EventHandler(this.buttonTileHorizontal_Click);
            // 
            // buttonTileVertical
            // 
            this.buttonTileVertical.ImageLarge = ((System.Drawing.Image)(resources.GetObject("buttonTileVertical.ImageLarge")));
            this.buttonTileVertical.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonTileVertical.ImageSmall")));
            this.buttonTileVertical.KeyTip = "V";
            this.buttonTileVertical.TextLine1 = "Tile";
            this.buttonTileVertical.TextLine2 = "Vertical";
            this.buttonTileVertical.Click += new System.EventHandler(this.buttonTileVertical_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 516);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "MDI Ribbon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private .Ribbon.KryptonRibbon ribbon;
        private .Ribbon.KryptonRibbonTab tabHome;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private .Ribbon.KryptonRibbonGroupButton buttonNewWindow;
        private .Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private .Ribbon.KryptonRibbonGroupButton buttonCloseWindow;
        private .Ribbon.KryptonRibbonGroupButton buttonCloseAllWindows;
        private .Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private .Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private .Ribbon.KryptonRibbonGroupButton buttonCascade;
        private .Ribbon.KryptonRibbonGroupButton buttonTileHorizontal;
        private .Ribbon.KryptonRibbonGroupButton buttonTileVertical;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecHelp;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}

