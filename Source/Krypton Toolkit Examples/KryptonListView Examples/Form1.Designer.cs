
using System.Windows.Forms;

namespace KryptonListViewExamples
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cat with areally long text to see what happens"}, 1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dog     "}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mouse     "}, 3, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cat with areally long text to see what happens",
            "Sub Item 1"}, 1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Dog", 2);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Mouse", 3);
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.chkDisabled = new Krypton.Toolkit.KryptonCheckBox();
            this.viewCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.groupBox3 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.listKrypton = new Krypton.Toolkit.KryptonListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbLargIcon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listWinform = new System.Windows.Forms.ListView();
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3.Panel)).BeginInit();
            this.groupBox3.Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonThemeComboBox1);
            this.kryptonPanel1.Controls.Add(this.chkDisabled);
            this.kryptonPanel1.Controls.Add(this.viewCheckBox);
            this.kryptonPanel1.Controls.Add(this.groupBox3);
            this.kryptonPanel1.Controls.Add(this.groupBox2);
            this.kryptonPanel1.Controls.Add(this.groupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(960, 449);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // chkDisabled
            // 
            this.chkDisabled.Location = new System.Drawing.Point(652, 421);
            this.chkDisabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(86, 26);
            this.chkDisabled.TabIndex = 7;
            this.chkDisabled.Values.Text = "Disabled";
            this.chkDisabled.CheckStateChanged += new System.EventHandler(this.chkDisabled_CheckStateChanged);
            // 
            // viewCheckBox
            // 
            this.viewCheckBox.Location = new System.Drawing.Point(552, 421);
            this.viewCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCheckBox.Name = "viewCheckBox";
            this.viewCheckBox.Size = new System.Drawing.Size(94, 26);
            this.viewCheckBox.TabIndex = 6;
            this.viewCheckBox.Values.Text = "CheckBox";
            this.viewCheckBox.CheckedChanged += new System.EventHandler(this.ViewCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(504, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            // 
            // groupBox3.Panel
            // 
            this.groupBox3.Panel.Controls.Add(this.kryptonTextBox1);
            this.groupBox3.Panel.Controls.Add(this.listKrypton);
            this.groupBox3.Size = new System.Drawing.Size(453, 401);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.Values.Heading = "Krypton ListView";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonTextBox1.Location = new System.Drawing.Point(0, 346);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(449, 27);
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // listKrypton
            // 
            this.listKrypton.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listKrypton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKrypton.FullRowSelect = true;
            this.listKrypton.GridLines = true;
            this.listKrypton.HideSelection = false;
            this.listKrypton.HotTracking = true;
            this.listKrypton.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.listKrypton.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            //this.listKrypton.ItemStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.listKrypton.LargeImageList = this.imageList2;
            this.listKrypton.Location = new System.Drawing.Point(0, 0);
            this.listKrypton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listKrypton.Name = "listKrypton";
            this.listKrypton.Size = new System.Drawing.Size(449, 373);
            this.listKrypton.SmallImageList = this.imageList1;
            this.listKrypton.TabIndex = 0;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "AppMenuClose.png");
            this.imageList2.Images.SetKeyName(1, "AppMenuMemoStyle.PNG");
            this.imageList2.Images.SetKeyName(2, "AppMenuMove.png");
            this.imageList2.Images.SetKeyName(3, "AppMenuNewMailMessage.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AppMenuClose.png");
            this.imageList1.Images.SetKeyName(1, "AppMenuMemoStyle.PNG");
            this.imageList1.Images.SetKeyName(2, "AppMenuMove.png");
            this.imageList1.Images.SetKeyName(3, "AppMenuNewMailMessage.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDetails);
            this.groupBox2.Controls.Add(this.rbTile);
            this.groupBox2.Controls.Add(this.rbList);
            this.groupBox2.Controls.Add(this.rbSmallIcon);
            this.groupBox2.Controls.Add(this.rbLargIcon);
            this.groupBox2.Location = new System.Drawing.Point(13, 414);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(533, 36);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Type";
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(431, 12);
            this.rbDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(70, 20);
            this.rbDetails.TabIndex = 4;
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(355, 11);
            this.rbTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(51, 20);
            this.rbTile.TabIndex = 3;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(239, 15);
            this.rbList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(48, 20);
            this.rbList.TabIndex = 2;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(123, 14);
            this.rbSmallIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(90, 20);
            this.rbSmallIcon.TabIndex = 1;
            this.rbSmallIcon.Text = "Small Icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbLargIcon
            // 
            this.rbLargIcon.AutoSize = true;
            this.rbLargIcon.Checked = true;
            this.rbLargIcon.Location = new System.Drawing.Point(7, 14);
            this.rbLargIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLargIcon.Name = "rbLargIcon";
            this.rbLargIcon.Size = new System.Drawing.Size(91, 20);
            this.rbLargIcon.TabIndex = 0;
            this.rbLargIcon.TabStop = true;
            this.rbLargIcon.Text = "Large Icon";
            this.rbLargIcon.UseVisualStyleBackColor = true;
            this.rbLargIcon.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            this.rbLargIcon.Validated += new System.EventHandler(this.ViewTypeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listWinform);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(475, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Winform ListView";
            // 
            // listWinform
            // 
            this.listWinform.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listWinform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWinform.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWinform.FullRowSelect = true;
            this.listWinform.GridLines = true;
            this.listWinform.HideSelection = false;
            this.listWinform.HotTracking = true;
            this.listWinform.HoverSelection = true;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listWinform.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listWinform.LargeImageList = this.imageList2;
            this.listWinform.Location = new System.Drawing.Point(3, 17);
            this.listWinform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listWinform.Name = "listWinform";
            this.listWinform.Size = new System.Drawing.Size(469, 374);
            this.listWinform.SmallImageList = this.imageList1;
            this.listWinform.TabIndex = 0;
            this.listWinform.UseCompatibleStateImageBehavior = false;
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonThemeComboBox1.DropDownWidth = 121;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(744, 420);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(211, 26);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 449);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ListView Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3.Panel)).EndInit();
            this.groupBox3.Panel.ResumeLayout(false);
            this.groupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listWinform;
        private System.Windows.Forms.ImageList imageList1;
        private Krypton.Toolkit.KryptonGroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.RadioButton rbLargIcon;
        private Krypton.Toolkit.KryptonCheckBox viewCheckBox;
        private System.Windows.Forms.RadioButton rbDetails;
        private Krypton.Toolkit.KryptonListView listKrypton;
        private ImageList imageList2;
        private Krypton.Toolkit.KryptonCheckBox chkDisabled;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
    }
}

