namespace KryptonTableLayoutPanelExamples
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4Custom = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel2Custom = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel3Custom = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel1Custom = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel4Blue = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel3Blue = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel2Blue = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel1Blue = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel4Office = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel3Office = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel2Office = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panel1Office = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(267, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 556);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KryptonPanel";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 531);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(514, 574);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4Office);
            this.groupBox1.Controls.Add(this.panel3Office);
            this.groupBox1.Controls.Add(this.panel2Office);
            this.groupBox1.Controls.Add(this.panel1Office);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional - Office 2003";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4Blue);
            this.groupBox2.Controls.Add(this.panel3Blue);
            this.groupBox2.Controls.Add(this.panel2Blue);
            this.groupBox2.Controls.Add(this.panel1Blue);
            this.groupBox2.Location = new System.Drawing.Point(8, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Office 2007 - Blue";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4Custom);
            this.groupBox3.Controls.Add(this.panel2Custom);
            this.groupBox3.Controls.Add(this.panel3Custom);
            this.groupBox3.Controls.Add(this.panel1Custom);
            this.groupBox3.Location = new System.Drawing.Point(8, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // panel4Custom
            // 
            this.panel4Custom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4Custom.BackgroundImage")));
            this.panel4Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4Custom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel4Custom.ColumnCount = 3;
            this.panel4Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel4Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel4Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.panel4Custom.Location = new System.Drawing.Point(138, 138);
            this.panel4Custom.Name = "panel4Custom";
            this.panel4Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panel4Custom.RowCount = 2;
            this.panel4Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel4Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel4Custom.Size = new System.Drawing.Size(100, 100);
            this.panel4Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel4Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel4Custom.StateNormal.ColorAngle = 45F;
            this.panel4Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.panel4Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.panel4Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.panel4Custom.StateNormal.Image = ((System.Drawing.Image)(resources.GetObject("panel4Custom.StateNormal.Image")));
            this.panel4Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.panel4Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel4Custom.TabIndex = 3;
            this.panel4Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel2Custom
            // 
            this.panel2Custom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2Custom.BackgroundImage")));
            this.panel2Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2Custom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel2Custom.ColumnCount = 3;
            this.panel2Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel2Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Custom.Location = new System.Drawing.Point(138, 32);
            this.panel2Custom.Name = "panel2Custom";
            this.panel2Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panel2Custom.RowCount = 3;
            this.panel2Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Custom.Size = new System.Drawing.Size(100, 100);
            this.panel2Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel2Custom.StateNormal.Color2 = System.Drawing.Color.Maroon;
            this.panel2Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel2Custom.StateNormal.ColorAngle = 10F;
            this.panel2Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.panel2Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.panel2Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.panel2Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel2Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel2Custom.TabIndex = 2;
            this.panel2Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel3Custom
            // 
            this.panel3Custom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3Custom.BackgroundImage")));
            this.panel3Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3Custom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel3Custom.ColumnCount = 2;
            this.panel3Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel3Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Custom.Location = new System.Drawing.Point(20, 138);
            this.panel3Custom.Name = "panel3Custom";
            this.panel3Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panel3Custom.RowCount = 3;
            this.panel3Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Custom.Size = new System.Drawing.Size(100, 100);
            this.panel3Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel3Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel3Custom.StateNormal.ColorAngle = 45F;
            this.panel3Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.panel3Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.panel3Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.panel3Custom.StateNormal.Image = ((System.Drawing.Image)(resources.GetObject("panel3Custom.StateNormal.Image")));
            this.panel3Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel3Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.panel3Custom.TabIndex = 1;
            this.panel3Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel1Custom
            // 
            this.panel1Custom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1Custom.BackgroundImage")));
            this.panel1Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1Custom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel1Custom.ColumnCount = 2;
            this.panel1Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel1Custom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Custom.Location = new System.Drawing.Point(20, 32);
            this.panel1Custom.Name = "panel1Custom";
            this.panel1Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panel1Custom.RowCount = 2;
            this.panel1Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Custom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Custom.Size = new System.Drawing.Size(100, 100);
            this.panel1Custom.StateNormal.Color1 = System.Drawing.Color.White;
            this.panel1Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel1Custom.StateNormal.ColorAngle = 60F;
            this.panel1Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.panel1Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.panel1Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.panel1Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.panel1Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.panel1Custom.TabIndex = 0;
            this.panel1Custom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel4Blue
            // 
            this.panel4Blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4Blue.BackgroundImage")));
            this.panel4Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4Blue.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel4Blue.ColumnCount = 2;
            this.panel4Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel4Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Blue.Location = new System.Drawing.Point(138, 84);
            this.panel4Blue.Name = "panel4Blue";
            this.panel4Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.panel4Blue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.panel4Blue.RowCount = 2;
            this.panel4Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Blue.Size = new System.Drawing.Size(100, 49);
            this.panel4Blue.TabIndex = 3;
            this.panel4Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel3Blue
            // 
            this.panel3Blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3Blue.BackgroundImage")));
            this.panel3Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3Blue.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel3Blue.ColumnCount = 2;
            this.panel3Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel3Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Blue.Location = new System.Drawing.Point(20, 84);
            this.panel3Blue.Name = "panel3Blue";
            this.panel3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.panel3Blue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.panel3Blue.RowCount = 2;
            this.panel3Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Blue.Size = new System.Drawing.Size(100, 49);
            this.panel3Blue.TabIndex = 1;
            this.panel3Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel2Blue
            // 
            this.panel2Blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2Blue.BackgroundImage")));
            this.panel2Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2Blue.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel2Blue.ColumnCount = 2;
            this.panel2Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel2Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Blue.Location = new System.Drawing.Point(138, 29);
            this.panel2Blue.Name = "panel2Blue";
            this.panel2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.panel2Blue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.panel2Blue.RowCount = 2;
            this.panel2Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Blue.Size = new System.Drawing.Size(100, 49);
            this.panel2Blue.TabIndex = 2;
            this.panel2Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel1Blue
            // 
            this.panel1Blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1Blue.BackgroundImage")));
            this.panel1Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1Blue.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel1Blue.ColumnCount = 2;
            this.panel1Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel1Blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Blue.Location = new System.Drawing.Point(20, 29);
            this.panel1Blue.Name = "panel1Blue";
            this.panel1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.panel1Blue.RowCount = 2;
            this.panel1Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Blue.Size = new System.Drawing.Size(100, 49);
            this.panel1Blue.TabIndex = 0;
            this.panel1Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel4Office
            // 
            this.panel4Office.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4Office.BackgroundImage")));
            this.panel4Office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4Office.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel4Office.ColumnCount = 2;
            this.panel4Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel4Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Office.Location = new System.Drawing.Point(138, 84);
            this.panel4Office.Name = "panel4Office";
            this.panel4Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel4Office.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.panel4Office.RowCount = 2;
            this.panel4Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel4Office.Size = new System.Drawing.Size(100, 49);
            this.panel4Office.TabIndex = 3;
            this.panel4Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel3Office
            // 
            this.panel3Office.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3Office.BackgroundImage")));
            this.panel3Office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3Office.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel3Office.ColumnCount = 2;
            this.panel3Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel3Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Office.Location = new System.Drawing.Point(20, 84);
            this.panel3Office.Name = "panel3Office";
            this.panel3Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel3Office.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.panel3Office.RowCount = 2;
            this.panel3Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel3Office.Size = new System.Drawing.Size(100, 49);
            this.panel3Office.TabIndex = 1;
            this.panel3Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel2Office
            // 
            this.panel2Office.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2Office.BackgroundImage")));
            this.panel2Office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2Office.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel2Office.ColumnCount = 2;
            this.panel2Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel2Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Office.Location = new System.Drawing.Point(138, 29);
            this.panel2Office.Name = "panel2Office";
            this.panel2Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.panel2Office.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.panel2Office.RowCount = 2;
            this.panel2Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel2Office.Size = new System.Drawing.Size(100, 49);
            this.panel2Office.TabIndex = 2;
            this.panel2Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // panel1Office
            // 
            this.panel1Office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1Office.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panel1Office.ColumnCount = 2;
            this.panel1Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.panel1Office.Location = new System.Drawing.Point(20, 29);
            this.panel1Office.Name = "panel1Office";
            this.panel1Office.RowCount = 2;
            this.panel1Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1Office.Size = new System.Drawing.Size(100, 49);
            this.panel1Office.TabIndex = 0;
            this.panel1Office.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel_MouseDown);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(7, 44);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(125, 48);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonTableLayoutPanel Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel1Office;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel2Office;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel3Office;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel4Office;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel1Blue;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel2Blue;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel3Blue;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel4Blue;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel1Custom;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel2Custom;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel3Custom;
        private Krypton.Toolkit.KryptonTableLayoutPanel panel4Custom;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}

