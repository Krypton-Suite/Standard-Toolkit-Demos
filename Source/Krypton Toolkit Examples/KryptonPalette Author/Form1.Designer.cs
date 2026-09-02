#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, tobitege, KamaniAR, Lesandro Gotardo (aka lesandrog), Jorge A. Avilés (aka mcpbcs) et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonPaletteAuthor;

partial class Form1
{
    private IContainer components = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new Container();
        kryptonManager = new KryptonManager(components);
        kryptonPalette = new KryptonCustomPaletteBase(components);
        menuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparatorFile1 = new ToolStripSeparator();
        saveToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparatorFile2 = new ToolStripSeparator();
        convertToolStripMenuItem = new ToolStripMenuItem();
        upgradeXmlToolStripMenuItem = new ToolStripMenuItem();
        upgradeXmlFolderToolStripMenuItem = new ToolStripMenuItem();
        packFolderToolStripMenuItem = new ToolStripMenuItem();
        editPackToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparatorFile3 = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        paletteToolStripMenuItem = new ToolStripMenuItem();
        populateToolStripMenuItem = new ToolStripMenuItem();
        applyPreviewToolStripMenuItem = new ToolStripMenuItem();
        resetDefaultsToolStripMenuItem = new ToolStripMenuItem();
        statusStrip = new StatusStrip();
        statusLabel = new ToolStripStatusLabel();
        splitMain = new KryptonSplitContainer();
        panelFolder = new Panel();
        lblFolder = new KryptonLabel();
        txtFolder = new KryptonTextBox();
        btnBrowseFolder = new KryptonButton();
        btnReload = new KryptonButton();
        btnOpenSelected = new KryptonButton();
        fileTree = new KryptonPaletteFileTreeView();
        splitWork = new KryptonSplitContainer();
        panelPreviewHost = new KryptonPanel();
        panelTools = new Panel();
        lblBaseTheme = new KryptonLabel();
        cboBaseTheme = new KryptonComboBox();
        btnPopulate = new KryptonButton();
        lblName = new KryptonLabel();
        txtPaletteName = new KryptonTextBox();
        btnSetName = new KryptonButton();
        picThumbnail = new PictureBox();
        btnLoadThumbnail = new KryptonButton();
        btnClearThumbnail = new KryptonButton();
        headerPreview = new KryptonHeaderGroup();
        flowPreview = new FlowLayoutPanel();
        btnPreview = new KryptonButton();
        chkPreview = new KryptonCheckBox();
        radioPreview = new KryptonRadioButton();
        textPreview = new KryptonTextBox();
        progressPreview = new KryptonProgressBar();
        trackPreview = new KryptonTrackBar();
        propertyGrid = new KryptonPropertyGrid();
        lblInstructions = new KryptonWrapLabel();
        menuStrip.SuspendLayout();
        statusStrip.SuspendLayout();
        ((ISupportInitialize)splitMain).BeginInit();
        ((ISupportInitialize)splitMain.Panel1).BeginInit();
        splitMain.Panel1.SuspendLayout();
        ((ISupportInitialize)splitMain.Panel2).BeginInit();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        panelFolder.SuspendLayout();
        ((ISupportInitialize)splitWork).BeginInit();
        ((ISupportInitialize)splitWork.Panel1).BeginInit();
        splitWork.Panel1.SuspendLayout();
        ((ISupportInitialize)splitWork.Panel2).BeginInit();
        splitWork.Panel2.SuspendLayout();
        splitWork.SuspendLayout();
        panelPreviewHost.SuspendLayout();
        panelTools.SuspendLayout();
        ((ISupportInitialize)cboBaseTheme).BeginInit();
        ((ISupportInitialize)picThumbnail).BeginInit();
        ((ISupportInitialize)headerPreview).BeginInit();
        headerPreview.Panel.SuspendLayout();
        headerPreview.SuspendLayout();
        flowPreview.SuspendLayout();
        SuspendLayout();
        //
        // menuStrip
        //
        menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, paletteToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(1184, 24);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip";
        //
        // fileToolStripMenuItem
        //
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
        {
            newToolStripMenuItem,
            openToolStripMenuItem,
            toolStripSeparatorFile1,
            saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            toolStripSeparatorFile2,
            convertToolStripMenuItem,
            upgradeXmlToolStripMenuItem,
            upgradeXmlFolderToolStripMenuItem,
            packFolderToolStripMenuItem,
            editPackToolStripMenuItem,
            toolStripSeparatorFile3,
            exitToolStripMenuItem
        });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Text = "&File";
        //
        // newToolStripMenuItem
        //
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newToolStripMenuItem.Text = "&New";
        newToolStripMenuItem.Click += NewPalette;
        //
        // openToolStripMenuItem
        //
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openToolStripMenuItem.Text = "&Open...";
        openToolStripMenuItem.Click += OpenPalette;
        //
        // saveToolStripMenuItem
        //
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveToolStripMenuItem.Text = "&Save";
        saveToolStripMenuItem.Click += SavePalette;
        //
        // saveAsToolStripMenuItem
        //
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Text = "Save &As...";
        saveAsToolStripMenuItem.Click += SavePaletteAs;
        //
        // convertToolStripMenuItem
        //
        convertToolStripMenuItem.Name = "convertToolStripMenuItem";
        convertToolStripMenuItem.Text = "&Convert palette file...";
        convertToolStripMenuItem.Click += ConvertPaletteFile;
        //
        // upgradeXmlToolStripMenuItem
        //
        upgradeXmlToolStripMenuItem.Name = "upgradeXmlToolStripMenuItem";
        upgradeXmlToolStripMenuItem.Text = "&Upgrade .xml to .kpalx...";
        upgradeXmlToolStripMenuItem.Click += UpgradeXmlPaletteFile;
        //
        // upgradeXmlFolderToolStripMenuItem
        //
        upgradeXmlFolderToolStripMenuItem.Name = "upgradeXmlFolderToolStripMenuItem";
        upgradeXmlFolderToolStripMenuItem.Text = "Upgrade &folder .xml to .kpalx...";
        upgradeXmlFolderToolStripMenuItem.Click += UpgradeXmlFolder;
        //
        // packFolderToolStripMenuItem
        //
        packFolderToolStripMenuItem.Name = "packFolderToolStripMenuItem";
        packFolderToolStripMenuItem.Text = "Pack &folder to .kpal...";
        packFolderToolStripMenuItem.Click += PackFolder;
        //
        // editPackToolStripMenuItem
        //
        editPackToolStripMenuItem.Name = "editPackToolStripMenuItem";
        editPackToolStripMenuItem.Text = "&Edit .kpal pack...";
        editPackToolStripMenuItem.Click += EditPack;
        //
        // exitToolStripMenuItem
        //
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Text = "E&xit";
        exitToolStripMenuItem.Click += (_, _) => Close();
        //
        // paletteToolStripMenuItem
        //
        paletteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
        {
            populateToolStripMenuItem,
            applyPreviewToolStripMenuItem,
            resetDefaultsToolStripMenuItem
        });
        paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
        paletteToolStripMenuItem.Text = "&Palette";
        //
        // populateToolStripMenuItem
        //
        populateToolStripMenuItem.Name = "populateToolStripMenuItem";
        populateToolStripMenuItem.Text = "&Populate from builtin theme";
        populateToolStripMenuItem.Click += PopulateFromSelectedTheme;
        //
        // applyPreviewToolStripMenuItem
        //
        applyPreviewToolStripMenuItem.Name = "applyPreviewToolStripMenuItem";
        applyPreviewToolStripMenuItem.Text = "&Apply to preview";
        applyPreviewToolStripMenuItem.Click += (_, _) => ApplyPreview();
        //
        // resetDefaultsToolStripMenuItem
        //
        resetDefaultsToolStripMenuItem.Name = "resetDefaultsToolStripMenuItem";
        resetDefaultsToolStripMenuItem.Text = "&Reset to defaults";
        resetDefaultsToolStripMenuItem.Click += ResetPalette;
        //
        // statusStrip
        //
        statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
        statusStrip.Location = new Point(0, 697);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1184, 22);
        statusStrip.TabIndex = 1;
        //
        // statusLabel
        //
        statusLabel.Name = "statusLabel";
        statusLabel.Spring = true;
        statusLabel.Text = "Ready. New, Open, or populate from a builtin theme, then save as .kpalx or .kpal.";
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // splitMain
        //
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(0, 24);
        splitMain.Name = "splitMain";
        splitMain.SeparatorStyle = SeparatorStyle.HighProfile;
        splitMain.Size = new Size(1184, 673);
        splitMain.SplitterDistance = 280;
        splitMain.TabIndex = 2;
        //
        // splitMain.Panel1
        //
        splitMain.Panel1.Padding = new Padding(8);
        splitMain.Panel1.Controls.Add(fileTree);
        splitMain.Panel1.Controls.Add(btnOpenSelected);
        splitMain.Panel1.Controls.Add(panelFolder);
        //
        // panelFolder
        //
        panelFolder.Controls.Add(btnReload);
        panelFolder.Controls.Add(btnBrowseFolder);
        panelFolder.Controls.Add(txtFolder);
        panelFolder.Controls.Add(lblFolder);
        panelFolder.Dock = DockStyle.Top;
        panelFolder.Height = 88;
        panelFolder.Name = "panelFolder";
        //
        // lblFolder
        //
        lblFolder.Location = new Point(0, 4);
        lblFolder.Name = "lblFolder";
        lblFolder.Size = new Size(92, 20);
        lblFolder.Values.Text = "Working folder";
        //
        // txtFolder
        //
        txtFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtFolder.Location = new Point(0, 28);
        txtFolder.Name = "txtFolder";
        txtFolder.Size = new Size(256, 23);
        txtFolder.TabIndex = 0;
        //
        // btnBrowseFolder
        //
        btnBrowseFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnBrowseFolder.Location = new Point(0, 56);
        btnBrowseFolder.Name = "btnBrowseFolder";
        btnBrowseFolder.Size = new Size(80, 28);
        btnBrowseFolder.TabIndex = 1;
        btnBrowseFolder.Values.Text = "Browse...";
        btnBrowseFolder.Click += BrowseFolder;
        //
        // btnReload
        //
        btnReload.Location = new Point(86, 56);
        btnReload.Name = "btnReload";
        btnReload.Size = new Size(80, 28);
        btnReload.TabIndex = 2;
        btnReload.Values.Text = "Reload";
        btnReload.Click += (_, _) => ReloadFolderTree();
        //
        // btnOpenSelected
        //
        btnOpenSelected.Dock = DockStyle.Bottom;
        btnOpenSelected.Location = new Point(8, 637);
        btnOpenSelected.Name = "btnOpenSelected";
        btnOpenSelected.Size = new Size(264, 28);
        btnOpenSelected.TabIndex = 3;
        btnOpenSelected.Values.Text = "Open selected theme";
        btnOpenSelected.Click += OpenSelectedFromTree;
        //
        // fileTree
        //
        fileTree.AutoApply = false;
        fileTree.Dock = DockStyle.Fill;
        fileTree.Location = new Point(8, 96);
        fileTree.Name = "fileTree";
        fileTree.SearchSubdirectories = true;
        fileTree.ShowThumbnails = true;
        fileTree.Size = new Size(264, 541);
        fileTree.TabIndex = 4;
        fileTree.NodeMouseDoubleClick += FileTreeDoubleClick;
        //
        // splitMain.Panel2
        //
        splitMain.Panel2.Controls.Add(splitWork);
        splitMain.Panel2.Controls.Add(lblInstructions);
        //
        // lblInstructions
        //
        lblInstructions.Dock = DockStyle.Top;
        lblInstructions.LabelStyle = LabelStyle.NormalControl;
        lblInstructions.Location = new Point(0, 0);
        lblInstructions.Name = "lblInstructions";
        lblInstructions.Size = new Size(899, 56);
        lblInstructions.Text = "Author a custom palette: populate from a builtin/extra theme or open a .kpalx / .kpal file. Edit values in the property grid. Save writes .kpalx (XML) by default; choose .kpal for the native binary container. File > Upgrade .xml to .kpalx rewrites a legacy .xml beside the source. File > Upgrade folder .xml to .kpalx converts a directory of palettes. Pack folder stores a directory tree as path-named themes in one .kpal. Double-click a tree node to load that file into the editor.";
        //
        // splitWork
        //
        splitWork.Dock = DockStyle.Fill;
        splitWork.Location = new Point(0, 56);
        splitWork.Name = "splitWork";
        splitWork.Orientation = Orientation.Vertical;
        splitWork.SeparatorStyle = SeparatorStyle.HighProfile;
        splitWork.Size = new Size(899, 617);
        splitWork.SplitterDistance = 460;
        splitWork.TabIndex = 0;
        //
        // splitWork.Panel1
        //
        splitWork.Panel1.Controls.Add(panelPreviewHost);
        //
        // panelPreviewHost
        //
        panelPreviewHost.Controls.Add(headerPreview);
        panelPreviewHost.Controls.Add(panelTools);
        panelPreviewHost.Dock = DockStyle.Fill;
        panelPreviewHost.Name = "panelPreviewHost";
        //
        // panelTools
        //
        panelTools.Controls.Add(btnClearThumbnail);
        panelTools.Controls.Add(btnLoadThumbnail);
        panelTools.Controls.Add(picThumbnail);
        panelTools.Controls.Add(btnSetName);
        panelTools.Controls.Add(txtPaletteName);
        panelTools.Controls.Add(lblName);
        panelTools.Controls.Add(btnPopulate);
        panelTools.Controls.Add(cboBaseTheme);
        panelTools.Controls.Add(lblBaseTheme);
        panelTools.Dock = DockStyle.Top;
        panelTools.Height = 112;
        panelTools.Name = "panelTools";
        panelTools.Padding = new Padding(8);
        //
        // lblBaseTheme
        //
        lblBaseTheme.Location = new Point(8, 10);
        lblBaseTheme.Name = "lblBaseTheme";
        lblBaseTheme.Size = new Size(72, 20);
        lblBaseTheme.Values.Text = "Base theme";
        //
        // cboBaseTheme
        //
        cboBaseTheme.DropDownStyle = ComboBoxStyle.DropDownList;
        cboBaseTheme.Location = new Point(86, 8);
        cboBaseTheme.Name = "cboBaseTheme";
        cboBaseTheme.Size = new Size(220, 22);
        cboBaseTheme.TabIndex = 0;
        //
        // btnPopulate
        //
        btnPopulate.Location = new Point(312, 6);
        btnPopulate.Name = "btnPopulate";
        btnPopulate.Size = new Size(100, 28);
        btnPopulate.TabIndex = 1;
        btnPopulate.Values.Text = "Populate";
        btnPopulate.Click += PopulateFromSelectedTheme;
        //
        // lblName
        //
        lblName.Location = new Point(8, 42);
        lblName.Name = "lblName";
        lblName.Size = new Size(72, 20);
        lblName.Values.Text = "Palette name";
        //
        // txtPaletteName
        //
        txtPaletteName.Location = new Point(86, 40);
        txtPaletteName.Name = "txtPaletteName";
        txtPaletteName.Size = new Size(220, 23);
        txtPaletteName.TabIndex = 2;
        //
        // btnSetName
        //
        btnSetName.Location = new Point(312, 38);
        btnSetName.Name = "btnSetName";
        btnSetName.Size = new Size(100, 28);
        btnSetName.TabIndex = 3;
        btnSetName.Values.Text = "Set name";
        btnSetName.Click += SetPaletteName;
        //
        // picThumbnail
        //
        picThumbnail.BorderStyle = BorderStyle.FixedSingle;
        picThumbnail.Location = new Point(8, 72);
        picThumbnail.Name = "picThumbnail";
        picThumbnail.Size = new Size(32, 32);
        picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
        picThumbnail.TabIndex = 4;
        picThumbnail.TabStop = false;
        //
        // btnLoadThumbnail
        //
        btnLoadThumbnail.Location = new Point(46, 72);
        btnLoadThumbnail.Name = "btnLoadThumbnail";
        btnLoadThumbnail.Size = new Size(120, 28);
        btnLoadThumbnail.TabIndex = 5;
        btnLoadThumbnail.Values.Text = "Load thumbnail...";
        btnLoadThumbnail.Click += LoadThumbnail;
        //
        // btnClearThumbnail
        //
        btnClearThumbnail.Location = new Point(172, 72);
        btnClearThumbnail.Name = "btnClearThumbnail";
        btnClearThumbnail.Size = new Size(120, 28);
        btnClearThumbnail.TabIndex = 6;
        btnClearThumbnail.Values.Text = "Clear thumbnail";
        btnClearThumbnail.Click += ClearThumbnail;
        //
        // headerPreview
        //
        headerPreview.Dock = DockStyle.Fill;
        headerPreview.Location = new Point(0, 112);
        headerPreview.Name = "headerPreview";
        headerPreview.Size = new Size(460, 505);
        headerPreview.TabIndex = 1;
        headerPreview.ValuesPrimary.Heading = "Live preview";
        headerPreview.ValuesPrimary.Description = "Controls follow the working custom palette.";
        //
        // headerPreview.Panel
        //
        headerPreview.Panel.Controls.Add(flowPreview);
        //
        // flowPreview
        //
        flowPreview.AutoScroll = true;
        flowPreview.Controls.Add(btnPreview);
        flowPreview.Controls.Add(chkPreview);
        flowPreview.Controls.Add(radioPreview);
        flowPreview.Controls.Add(textPreview);
        flowPreview.Controls.Add(progressPreview);
        flowPreview.Controls.Add(trackPreview);
        flowPreview.Dock = DockStyle.Fill;
        flowPreview.Location = new Point(0, 0);
        flowPreview.Name = "flowPreview";
        flowPreview.Padding = new Padding(8);
        flowPreview.Size = new Size(458, 454);
        flowPreview.TabIndex = 0;
        //
        // btnPreview
        //
        btnPreview.Location = new Point(11, 11);
        btnPreview.Name = "btnPreview";
        btnPreview.Size = new Size(120, 32);
        btnPreview.TabIndex = 0;
        btnPreview.Values.Text = "Button";
        //
        // chkPreview
        //
        chkPreview.Location = new Point(137, 11);
        chkPreview.Name = "chkPreview";
        chkPreview.Size = new Size(90, 20);
        chkPreview.TabIndex = 1;
        chkPreview.Values.Text = "Check box";
        //
        // radioPreview
        //
        radioPreview.Location = new Point(233, 11);
        radioPreview.Name = "radioPreview";
        radioPreview.Size = new Size(100, 20);
        radioPreview.TabIndex = 2;
        radioPreview.Values.Text = "Radio button";
        //
        // textPreview
        //
        textPreview.Location = new Point(11, 49);
        textPreview.Name = "textPreview";
        textPreview.Size = new Size(180, 23);
        textPreview.TabIndex = 3;
        textPreview.Text = "Sample text";
        //
        // progressPreview
        //
        progressPreview.Location = new Point(197, 49);
        progressPreview.Name = "progressPreview";
        progressPreview.Size = new Size(180, 23);
        progressPreview.TabIndex = 4;
        progressPreview.Value = 60;
        //
        // trackPreview
        //
        trackPreview.Location = new Point(11, 78);
        trackPreview.Name = "trackPreview";
        trackPreview.Size = new Size(220, 21);
        trackPreview.TabIndex = 5;
        trackPreview.Value = 6;
        //
        // splitWork.Panel2
        //
        splitWork.Panel2.Controls.Add(propertyGrid);
        //
        // propertyGrid
        //
        propertyGrid.Dock = DockStyle.Fill;
        propertyGrid.Location = new Point(0, 0);
        propertyGrid.Name = "propertyGrid";
        propertyGrid.Size = new Size(434, 617);
        propertyGrid.TabIndex = 0;
        propertyGrid.PropertyValueChanged += PropertyGridValueChanged;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1184, 719);
        Controls.Add(splitMain);
        Controls.Add(statusStrip);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        MinimumSize = new Size(960, 600);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Krypton Palette Author";
        FormClosing += Form1_FormClosing;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ((ISupportInitialize)splitMain.Panel1).EndInit();
        splitMain.Panel1.ResumeLayout(false);
        ((ISupportInitialize)splitMain.Panel2).EndInit();
        splitMain.Panel2.ResumeLayout(false);
        ((ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        panelFolder.ResumeLayout(false);
        panelFolder.PerformLayout();
        ((ISupportInitialize)splitWork.Panel1).EndInit();
        splitWork.Panel1.ResumeLayout(false);
        ((ISupportInitialize)splitWork.Panel2).EndInit();
        splitWork.Panel2.ResumeLayout(false);
        ((ISupportInitialize)splitWork).EndInit();
        splitWork.ResumeLayout(false);
        panelPreviewHost.ResumeLayout(false);
        panelTools.ResumeLayout(false);
        panelTools.PerformLayout();
        ((ISupportInitialize)cboBaseTheme).EndInit();
        ((ISupportInitialize)picThumbnail).EndInit();
        headerPreview.Panel.ResumeLayout(false);
        ((ISupportInitialize)headerPreview).EndInit();
        headerPreview.ResumeLayout(false);
        flowPreview.ResumeLayout(false);
        flowPreview.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KryptonManager kryptonManager;
    private KryptonCustomPaletteBase kryptonPalette;
    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparatorFile1;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparatorFile2;
    private ToolStripMenuItem convertToolStripMenuItem;
    private ToolStripMenuItem upgradeXmlToolStripMenuItem;
    private ToolStripMenuItem upgradeXmlFolderToolStripMenuItem;
    private ToolStripMenuItem packFolderToolStripMenuItem;
    private ToolStripSeparator toolStripSeparatorFile3;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem paletteToolStripMenuItem;
    private ToolStripMenuItem populateToolStripMenuItem;
    private ToolStripMenuItem applyPreviewToolStripMenuItem;
    private ToolStripMenuItem resetDefaultsToolStripMenuItem;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel statusLabel;
    private KryptonSplitContainer splitMain;
    private Panel panelFolder;
    private KryptonLabel lblFolder;
    private KryptonTextBox txtFolder;
    private KryptonButton btnBrowseFolder;
    private KryptonButton btnReload;
    private KryptonButton btnOpenSelected;
    private KryptonPaletteFileTreeView fileTree;
    private KryptonSplitContainer splitWork;
    private KryptonWrapLabel lblInstructions;
    private KryptonPanel panelPreviewHost;
    private Panel panelTools;
    private KryptonLabel lblBaseTheme;
    private KryptonComboBox cboBaseTheme;
    private KryptonButton btnPopulate;
    private KryptonLabel lblName;
    private KryptonTextBox txtPaletteName;
    private KryptonButton btnSetName;
    private PictureBox picThumbnail;
    private KryptonButton btnLoadThumbnail;
    private KryptonButton btnClearThumbnail;
    private KryptonHeaderGroup headerPreview;
    private FlowLayoutPanel flowPreview;
    private KryptonButton btnPreview;
    private KryptonCheckBox chkPreview;
    private KryptonRadioButton radioPreview;
    private KryptonTextBox textPreview;
    private KryptonProgressBar progressPreview;
    private KryptonTrackBar trackPreview;
    private KryptonPropertyGrid propertyGrid;
}
