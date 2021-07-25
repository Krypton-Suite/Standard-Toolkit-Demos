
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
            this.viewCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.cmbTheme = new Krypton.Toolkit.KryptonComboBox();
            this.groupBox3 = new Krypton.Toolkit.KryptonGroupBox();
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
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3.Panel)).BeginInit();
            this.groupBox3.Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.viewCheckBox);
            this.kryptonPanel1.Controls.Add(this.cmbTheme);
            this.kryptonPanel1.Controls.Add(this.groupBox3);
            this.kryptonPanel1.Controls.Add(this.groupBox2);
            this.kryptonPanel1.Controls.Add(this.groupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(720, 365);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // viewCheckBox
            // 
            this.viewCheckBox.Location = new System.Drawing.Point(463, 342);
            this.viewCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewCheckBox.Name = "viewCheckBox";
            this.viewCheckBox.Size = new System.Drawing.Size(76, 20);
            this.viewCheckBox.TabIndex = 6;
            this.viewCheckBox.Values.Text = "CheckBox";
            this.viewCheckBox.CheckedChanged += new System.EventHandler(this.ViewCheckBox_CheckedChanged);
            // 
            // cmbTheme
            // 
            this.cmbTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTheme.DropDownWidth = 199;
            this.cmbTheme.IntegralHeight = false;
            this.cmbTheme.Location = new System.Drawing.Point(562, 342);
            this.cmbTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(149, 21);
            this.cmbTheme.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbTheme.TabIndex = 5;
            this.cmbTheme.Text = "Office 2010 - Blue";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.CmbTheme_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(378, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            // 
            // groupBox3.Panel
            // 
            this.groupBox3.Panel.Controls.Add(this.listKrypton);
            this.groupBox3.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBox3_Panel_Paint);
            this.groupBox3.Size = new System.Drawing.Size(340, 326);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.Values.Heading = "Krypton ListView";
            // 
            // listKrypton
            // 
            this.listKrypton.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listKrypton.BackColor = System.Drawing.Color.Transparent;
            this.listKrypton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKrypton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listKrypton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
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
            this.listKrypton.ItemStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.listKrypton.LargeImageList = this.imageList2;
            this.listKrypton.Location = new System.Drawing.Point(0, 0);
            this.listKrypton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listKrypton.Name = "listKrypton";
            this.listKrypton.OwnerDraw = true;
            this.listKrypton.Size = new System.Drawing.Size(336, 302);
            this.listKrypton.SmallImageList = this.imageList1;
            this.listKrypton.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKrypton.StateCommon.Item.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.listKrypton.StateCommon.Item.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.listKrypton.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
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
            this.groupBox2.Location = new System.Drawing.Point(10, 336);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(400, 29);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Type";
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(323, 10);
            this.rbDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(57, 17);
            this.rbDetails.TabIndex = 4;
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(266, 9);
            this.rbTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(42, 17);
            this.rbTile.TabIndex = 3;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(179, 12);
            this.rbList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(41, 17);
            this.rbList.TabIndex = 2;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(92, 11);
            this.rbSmallIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(74, 17);
            this.rbSmallIcon.TabIndex = 1;
            this.rbSmallIcon.Text = "Small Icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.ViewTypeChanged);
            // 
            // rbLargIcon
            // 
            this.rbLargIcon.AutoSize = true;
            this.rbLargIcon.Checked = true;
            this.rbLargIcon.Location = new System.Drawing.Point(5, 11);
            this.rbLargIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLargIcon.Name = "rbLargIcon";
            this.rbLargIcon.Size = new System.Drawing.Size(76, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(356, 319);
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
            this.listWinform.Location = new System.Drawing.Point(2, 15);
            this.listWinform.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listWinform.Name = "listWinform";
            this.listWinform.Size = new System.Drawing.Size(352, 302);
            this.listWinform.SmallImageList = this.imageList1;
            this.listWinform.TabIndex = 0;
            this.listWinform.UseCompatibleStateImageBehavior = false;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 365);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ListView Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3.Panel)).EndInit();
            this.groupBox3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private Krypton.Toolkit.KryptonComboBox cmbTheme;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonCheckBox viewCheckBox;
        private System.Windows.Forms.RadioButton rbDetails;
        private Krypton.Toolkit.KryptonListView listKrypton;
        private ImageList imageList2;
    }
}

