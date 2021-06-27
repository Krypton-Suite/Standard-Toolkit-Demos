namespace KryptonTreeViewExamples
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.kryptonTreeView = new Krypton.Toolkit.KryptonTreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuMonthCalendar1 = new Krypton.Toolkit.KryptonContextMenuMonthCalendar();
            this.kryptonContextMenuItems1 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems2 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuHeading2 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuCheckBox1 = new Krypton.Toolkit.KryptonContextMenuCheckBox();
            this.kryptonContextMenuCheckButton1 = new Krypton.Toolkit.KryptonContextMenuCheckButton();
            this.kryptonContextMenuRadioButton1 = new Krypton.Toolkit.KryptonContextMenuRadioButton();
            this.kryptonContextMenuLinkLabel1 = new Krypton.Toolkit.KryptonContextMenuLinkLabel();
            this.kryptonContextMenuColorColumns1 = new Krypton.Toolkit.KryptonContextMenuColorColumns();
            this.kryptonContextMenuImageSelect1 = new Krypton.Toolkit.KryptonContextMenuImageSelect();
            this.kryptonContextMenuSeparator1 = new Krypton.Toolkit.KryptonContextMenuSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSystem = new Krypton.Toolkit.KryptonCheckButton();
            this.checkSparkle = new Krypton.Toolkit.KryptonCheckButton();
            this.check2010Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.check2007Blue = new Krypton.Toolkit.KryptonCheckButton();
            this.buttonAppend = new Krypton.Toolkit.KryptonButton();
            this.buttonInsert = new Krypton.Toolkit.KryptonButton();
            this.buttonClear = new Krypton.Toolkit.KryptonButton();
            this.buttonRemove = new Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonCheckSet = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonContextMenuItem2 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.btnToggleNodeCheckBox = new Krypton.Toolkit.KryptonButton();
            this.groupBox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(667, 631);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.propertyGrid);
            this.groupBox.Location = new System.Drawing.Point(380, 15);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(387, 609);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Properties for Selected KryptonTreeView";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(8, 23);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.kryptonTreeView;
            this.propertyGrid.Size = new System.Drawing.Size(371, 581);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // kryptonTreeView
            // 
            this.kryptonTreeView.CheckBoxes = true;
            this.kryptonTreeView.HideSelection = false;
            this.kryptonTreeView.HotTracking = true;
            this.kryptonTreeView.ImageIndex = 3;
            this.kryptonTreeView.ImageList = this.imageList;
            this.kryptonTreeView.KryptonContextMenu = this.kryptonContextMenu1;
            this.kryptonTreeView.Location = new System.Drawing.Point(17, 38);
            this.kryptonTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonTreeView.Name = "kryptonTreeView";
            this.kryptonTreeView.SelectedImageIndex = 3;
            this.kryptonTreeView.Size = new System.Drawing.Size(340, 319);
            this.kryptonTreeView.TabIndex = 6;
            this.kryptonTreeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.KryptonTreeView_BeforeCheck);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "flag_bahamas.png");
            this.imageList.Images.SetKeyName(1, "flag_china.png");
            this.imageList.Images.SetKeyName(2, "flag_ecuador.png");
            this.imageList.Images.SetKeyName(3, "flag_england.png");
            this.imageList.Images.SetKeyName(4, "flag_france.png");
            this.imageList.Images.SetKeyName(5, "flag_greece.png");
            this.imageList.Images.SetKeyName(6, "flag_netherlands.png");
            this.imageList.Images.SetKeyName(7, "flag_poland.png");
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuMonthCalendar1,
            this.kryptonContextMenuItems1,
            this.kryptonContextMenuCheckBox1,
            this.kryptonContextMenuCheckButton1,
            this.kryptonContextMenuRadioButton1,
            this.kryptonContextMenuLinkLabel1,
            this.kryptonContextMenuColorColumns1,
            this.kryptonContextMenuImageSelect1,
            this.kryptonContextMenuSeparator1});
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuMonthCalendar1
            // 
            this.kryptonContextMenuMonthCalendar1.DayOfWeekStyle = Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.kryptonContextMenuMonthCalendar1.DayStyle = Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.kryptonContextMenuMonthCalendar1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Calendar;
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems2,
            this.kryptonContextMenuHeading2});
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            // 
            // kryptonContextMenuCheckBox1
            // 
            this.kryptonContextMenuCheckBox1.ExtraText = "extra";
            this.kryptonContextMenuCheckBox1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            // 
            // kryptonContextMenuCheckButton1
            // 
            this.kryptonContextMenuCheckButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonContextMenuCheckButton1.ExtraText = "extra";
            this.kryptonContextMenuCheckButton1.Text = "CheckButton";
            // 
            // kryptonContextMenuRadioButton1
            // 
            this.kryptonContextMenuRadioButton1.ExtraText = "extra";
            this.kryptonContextMenuRadioButton1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            // 
            // kryptonContextMenuLinkLabel1
            // 
            this.kryptonContextMenuLinkLabel1.ExtraText = "extra";
            this.kryptonContextMenuLinkLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonContextMenuLinkLabel1.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.AlwaysUnderline;
            // 
            // kryptonContextMenuImageSelect1
            // 
            this.kryptonContextMenuImageSelect1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonContextMenuImageSelect1.ImageIndexEnd = 0;
            this.kryptonContextMenuImageSelect1.ImageIndexStart = 5;
            this.kryptonContextMenuImageSelect1.ImageList = this.imageList;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripComboBoxA,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 72);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripComboBoxA
            // 
            this.toolStripComboBoxA.Items.AddRange(new object[] {
            "rew"});
            this.toolStripComboBoxA.Name = "toolStripComboBoxA";
            this.toolStripComboBoxA.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSystem);
            this.groupBox1.Controls.Add(this.checkSparkle);
            this.groupBox1.Controls.Add(this.check2010Blue);
            this.groupBox1.Controls.Add(this.check2007Blue);
            this.groupBox1.Controls.Add(this.buttonAppend);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Location = new System.Drawing.Point(17, 417);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(340, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // checkSystem
            // 
            this.checkSystem.AutoSize = true;
            this.checkSystem.Location = new System.Drawing.Point(167, 155);
            this.checkSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSystem.Name = "checkSystem";
            this.checkSystem.Size = new System.Drawing.Size(151, 34);
            this.checkSystem.TabIndex = 7;
            this.checkSystem.Values.Text = "System";
            // 
            // checkSparkle
            // 
            this.checkSparkle.AutoSize = true;
            this.checkSparkle.Location = new System.Drawing.Point(167, 114);
            this.checkSparkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSparkle.Name = "checkSparkle";
            this.checkSparkle.Size = new System.Drawing.Size(151, 34);
            this.checkSparkle.TabIndex = 6;
            this.checkSparkle.Values.Text = "Sparkle - Blue";
            // 
            // check2010Blue
            // 
            this.check2010Blue.AutoSize = true;
            this.check2010Blue.Checked = true;
            this.check2010Blue.Location = new System.Drawing.Point(167, 38);
            this.check2010Blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check2010Blue.Name = "check2010Blue";
            this.check2010Blue.Size = new System.Drawing.Size(177, 34);
            this.check2010Blue.TabIndex = 5;
            this.check2010Blue.Values.Text = "Office 2010 - Blue";
            // 
            // check2007Blue
            // 
            this.check2007Blue.AutoSize = true;
            this.check2007Blue.Location = new System.Drawing.Point(167, 76);
            this.check2007Blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check2007Blue.Name = "check2007Blue";
            this.check2007Blue.Size = new System.Drawing.Size(177, 34);
            this.check2007Blue.TabIndex = 4;
            this.check2007Blue.Values.Text = "Office 2007 - Blue";
            // 
            // buttonAppend
            // 
            this.buttonAppend.AutoSize = true;
            this.buttonAppend.Location = new System.Drawing.Point(25, 37);
            this.buttonAppend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(120, 34);
            this.buttonAppend.TabIndex = 0;
            this.buttonAppend.Values.Text = "Append";
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.Location = new System.Drawing.Point(25, 76);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(120, 34);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Values.Text = "Insert";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(25, 155);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 34);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Values.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.Location = new System.Drawing.Point(25, 116);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(120, 34);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Values.Text = "Remove";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // kryptonCheckSet
            // 
            this.kryptonCheckSet.CheckButtons.Add(this.checkSystem);
            this.kryptonCheckSet.CheckButtons.Add(this.checkSparkle);
            this.kryptonCheckSet.CheckButtons.Add(this.check2010Blue);
            this.kryptonCheckSet.CheckButtons.Add(this.check2007Blue);
            this.kryptonCheckSet.CheckedButton = this.check2010Blue;
            this.kryptonCheckSet.CheckedButtonChanged += new System.EventHandler(this.kryptonCheckSet_CheckedButtonChanged);
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Menu Item";
            // 
            // btnToggleNodeCheckBox
            // 
            this.btnToggleNodeCheckBox.AutoSize = true;
            this.btnToggleNodeCheckBox.Location = new System.Drawing.Point(17, 379);
            this.btnToggleNodeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToggleNodeCheckBox.Name = "btnToggleNodeCheckBox";
            this.btnToggleNodeCheckBox.Size = new System.Drawing.Size(184, 31);
            this.btnToggleNodeCheckBox.TabIndex = 8;
            this.btnToggleNodeCheckBox.Values.Text = "Toggle Node CheckBox";
            this.btnToggleNodeCheckBox.Click += new System.EventHandler(this.BtnToggleNodeCheckBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 674);
            this.Controls.Add(this.btnToggleNodeCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonTreeView);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonTreeView Examples";
            this.groupBox.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Krypton.Toolkit.KryptonTreeView kryptonTreeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonCheckButton checkSystem;
        private Krypton.Toolkit.KryptonCheckButton checkSparkle;
        private Krypton.Toolkit.KryptonCheckButton check2010Blue;
        private Krypton.Toolkit.KryptonCheckButton check2007Blue;
        private Krypton.Toolkit.KryptonButton buttonAppend;
        private Krypton.Toolkit.KryptonButton buttonInsert;
        private Krypton.Toolkit.KryptonButton buttonClear;
        private Krypton.Toolkit.KryptonButton buttonRemove;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet;
        private System.Windows.Forms.ImageList imageList;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonContextMenuCheckBox kryptonContextMenuCheckBox1;
        private Krypton.Toolkit.KryptonContextMenuCheckButton kryptonContextMenuCheckButton1;
        private Krypton.Toolkit.KryptonContextMenuRadioButton kryptonContextMenuRadioButton1;
        private Krypton.Toolkit.KryptonContextMenuLinkLabel kryptonContextMenuLinkLabel1;
        private Krypton.Toolkit.KryptonContextMenuColorColumns kryptonContextMenuColorColumns1;
        private Krypton.Toolkit.KryptonContextMenuImageSelect kryptonContextMenuImageSelect1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private Krypton.Toolkit.KryptonContextMenuMonthCalendar kryptonContextMenuMonthCalendar1;
        private Krypton.Toolkit.KryptonButton btnToggleNodeCheckBox;
    }
}

