namespace NavigatorAndFloatingWindows
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
            this.kryptonDockingManager = new Krypton.Docking.KryptonDockingManager();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableNavigator = new Krypton.Docking.KryptonDockableNavigator();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonDockableNavigator);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel.Size = new System.Drawing.Size(533, 336);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonDockableNavigator
            // 
            this.kryptonDockableNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context;
            this.kryptonDockableNavigator.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose;
            this.kryptonDockableNavigator.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage;
            this.kryptonDockableNavigator.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonDockableNavigator.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonDockableNavigator.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonDockableNavigator.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonDockableNavigator.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonDockableNavigator.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonDockableNavigator.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonDockableNavigator.ControlKryptonFormFeatures = false;
            this.kryptonDockableNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator.Location = new System.Drawing.Point(4, 4);
            this.kryptonDockableNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonDockableNavigator.Name = "kryptonDockableNavigator";
            this.kryptonDockableNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonDockableNavigator.Owner = null;
            this.kryptonDockableNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonDockableNavigator.Size = new System.Drawing.Size(525, 328);
            this.kryptonDockableNavigator.TabIndex = 0;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Navigator + FloatingWindows";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Docking.KryptonDockingManager kryptonDockingManager;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Krypton.Docking.KryptonDockableNavigator kryptonDockableNavigator;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

