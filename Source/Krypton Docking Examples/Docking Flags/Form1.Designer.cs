﻿namespace DockingFlags
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
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace = new Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonDockingManager = new Krypton.Docking.KryptonDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonDockableWorkspace);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPanel.Size = new System.Drawing.Size(684, 564);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonDockableWorkspace
            // 
            this.kryptonDockableWorkspace.ActivePage = null;
            this.kryptonDockableWorkspace.AutoHiddenHost = false;
            this.kryptonDockableWorkspace.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace.Location = new System.Drawing.Point(3, 3);
            this.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            // 
            // 
            // 
            this.kryptonDockableWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonDockableWorkspace.Root.UniqueName = "D3A631E8871B4E59D3A631E8871B4E59";
            this.kryptonDockableWorkspace.Root.WorkspaceControl = this.kryptonDockableWorkspace;
            this.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonDockableWorkspace.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace.Size = new System.Drawing.Size(678, 558);
            this.kryptonDockableWorkspace.SplitterWidth = 5;
            this.kryptonDockableWorkspace.TabIndex = 0;
            this.kryptonDockableWorkspace.TabStop = true;
            // 
            // kryptonDockingManager
            // 
            this.kryptonDockingManager.DefaultCloseRequest = Krypton.Docking.DockingCloseRequest.HidePage;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 564);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Docking Flags";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Krypton.Docking.KryptonDockingManager kryptonDockingManager;
        private System.Windows.Forms.ImageList imageListSmall;
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace;
        private Krypton.Toolkit.KryptonManager kryptonManager;

    }
}

