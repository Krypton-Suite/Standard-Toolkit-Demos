namespace KryptonOutlookGrid
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
            Krypton.Toolkit.OutlookGridGroupCollection outlookGridGroupCollection1 = new Krypton.Toolkit.OutlookGridGroupCollection();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonHeaderGroup1 = new Krypton.Toolkit.KryptonHeaderGroup();
            this.bsaLoadConfiguration = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.bsaSaveConfiguration = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.bsaToggleAllNodes = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kogExample = new Krypton.Toolkit.KryptonOutlookGrid();
            this.kryptonOutlookGridGroupBox1 = new Krypton.Toolkit.KryptonOutlookGridGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kogExample)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 422);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonPanel1.Size = new System.Drawing.Size(822, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnClose
            // 
            this.kbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnClose.Location = new System.Drawing.Point(716, 13);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 25);
            this.kbtnClose.TabIndex = 1;
            this.kbtnClose.Values.Text = "Close";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderSecondary;
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(822, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(822, 422);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.Add(this.bsaLoadConfiguration);
            this.kryptonHeaderGroup1.ButtonSpecs.Add(this.bsaSaveConfiguration);
            this.kryptonHeaderGroup1.ButtonSpecs.Add(this.bsaToggleAllNodes);
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(13, 13);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kogExample);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonOutlookGridGroupBox1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(793, 383);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Outlook Grid Example";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            // 
            // bsaLoadConfiguration
            // 
            this.bsaLoadConfiguration.Text = "Load Configuration";
            this.bsaLoadConfiguration.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Open;
            this.bsaLoadConfiguration.UniqueName = "d8f2e1da9b144a5785d49e4a4dd3aa08";
            this.bsaLoadConfiguration.Click += new System.EventHandler(this.bsaLoadConfiguration_Click);
            // 
            // bsaSaveConfiguration
            // 
            this.bsaSaveConfiguration.Text = "Save Configuration";
            this.bsaSaveConfiguration.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Save;
            this.bsaSaveConfiguration.UniqueName = "0efa88c5c41e4e9f8c9272a78b64c2a6";
            this.bsaSaveConfiguration.Click += new System.EventHandler(this.bsaSaveConfiguration_Click);
            // 
            // bsaToggleAllNodes
            // 
            this.bsaToggleAllNodes.Text = "Toggle All Nodes";
            this.bsaToggleAllNodes.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.bsaToggleAllNodes.UniqueName = "f12cbc90253e434da4f578d14f723d9d";
            this.bsaToggleAllNodes.Click += new System.EventHandler(this.bsaToggleAllNodes_Click);
            // 
            // kogExample
            // 
            this.kogExample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kogExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kogExample.FillMode = Krypton.Toolkit.FillMode.GroupsOnly;
            this.kogExample.GroupCollection = outlookGridGroupCollection1;
            this.kogExample.Location = new System.Drawing.Point(0, 46);
            this.kogExample.Name = "kogExample";
            this.kogExample.PreviousSelectedGroupRow = -1;
            this.kogExample.ShowLines = false;
            this.kogExample.Size = new System.Drawing.Size(791, 305);
            this.kogExample.TabIndex = 1;
            this.kogExample.GroupImageClick += new System.EventHandler<Krypton.Toolkit.OutlookGridGroupImageEventArgs>(this.kogExample_GroupImageClick);
            this.kogExample.Resize += new System.EventHandler(this.kogExample_Resize);
            // 
            // kryptonOutlookGridGroupBox1
            // 
            this.kryptonOutlookGridGroupBox1.AllowDrop = true;
            this.kryptonOutlookGridGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonOutlookGridGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonOutlookGridGroupBox1.Name = "kryptonOutlookGridGroupBox1";
            this.kryptonOutlookGridGroupBox1.Size = new System.Drawing.Size(791, 46);
            this.kryptonOutlookGridGroupBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Krypton Outlook Grid Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kogExample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton kbtnClose;
        private Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private Krypton.Toolkit.KryptonOutlookGridGroupBox kryptonOutlookGridGroupBox1;
        private Krypton.Toolkit.KryptonOutlookGrid kogExample;
        private Krypton.Toolkit.ButtonSpecHeaderGroup bsaLoadConfiguration;
        private Krypton.Toolkit.ButtonSpecHeaderGroup bsaSaveConfiguration;
        private Krypton.Toolkit.ButtonSpecHeaderGroup bsaToggleAllNodes;
    }
}