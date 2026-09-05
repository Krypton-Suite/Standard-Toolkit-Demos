#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved. 
 *  
 */
#endregion

using System;
using System.IO;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonPaletteExamples;

public partial class Form1 : KryptonForm
{
    private KryptonPaletteFileComboBox? _paletteFileCombo;
    private KryptonPaletteFileTreeView? _paletteFileTree;

    public Form1()
    {
        InitializeComponent();
        AppendPaletteBinaryExport();
    }

    private void AppendPaletteBinaryExport()
    {
        ClientSize = new System.Drawing.Size(ClientSize.Width, ClientSize.Height + 466);

        var instructions = new KryptonWrapLabel
        {
            Location = new System.Drawing.Point(12, 610),
            Size = new System.Drawing.Size(490, 130),
            Text = @"#2117: Import/Export dialogs default to .kthemex (KryptonPalette XML). Use Export native .ktheme for a single theme; Export .ktheme collection stores several named themes. Collection folder to .ktheme stores a directory tree as path-named themes. Edit .ktheme collection adds .kthemex files and removes named themes. Upgrade .xml to .kthemex rewrites a legacy .xml beside the source (UpgradeXmlToKthemex). Upgrade folder .xml to .kthemex converts a directory (UpgradeXmlToKthemexFromDirectory). Convert XML to .kthemex writes a chosen destination."
        };

        var btnKthemex = new KryptonButton
        {
            Location = new System.Drawing.Point(512, 610),
            Size = new System.Drawing.Size(114, 43),
            Name = @"btnExportKthemex"
        };
        btnKthemex.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnKthemex.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnKthemex.Values.Text = @"Export" + Environment.NewLine + @".kthemex XML";
        btnKthemex.Click += (_, _) => ExportPaletteFormat(KryptonPaletteFileFormat.Xml, @"custom.kthemex");

        var btnNative = new KryptonButton
        {
            Location = new System.Drawing.Point(632, 610),
            Size = new System.Drawing.Size(114, 43),
            Name = @"btnExportPaletteBinary"
        };
        btnNative.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnNative.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnNative.Values.Text = @"Export native" + Environment.NewLine + @".ktheme";
        btnNative.Click += (_, _) => ExportPaletteFormat(KryptonPaletteFileFormat.PaletteBinary, @"custom.ktheme");

        var btnConvert = new KryptonButton
        {
            Location = new System.Drawing.Point(512, 658),
            Size = new System.Drawing.Size(114, 43),
            Name = @"btnConvertPaletteFile"
        };
        btnConvert.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnConvert.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnConvert.Values.Text = @"Convert XML" + Environment.NewLine + @"to .kthemex";
        btnConvert.Click += (_, _) => ConvertPaletteFile();

        var btnUpgradeXml = new KryptonButton
        {
            Location = new System.Drawing.Point(632, 658),
            Size = new System.Drawing.Size(114, 43),
            Name = @"btnUpgradeXmlPaletteFile"
        };
        btnUpgradeXml.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnUpgradeXml.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnUpgradeXml.Values.Text = @"Upgrade .xml" + Environment.NewLine + @"to .kthemex";
        btnUpgradeXml.Click += (_, _) => UpgradeXmlPaletteFile();

        var btnExportCollection = new KryptonButton
        {
            Location = new System.Drawing.Point(512, 706),
            Size = new System.Drawing.Size(114, 43),
            Name = @"btnExportPaletteCollection"
        };
        btnExportCollection.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnExportCollection.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnExportCollection.Values.Text = @"Export" + Environment.NewLine + @".ktheme collection";
        btnExportCollection.Click += (_, _) => ExportPaletteCollection();

        var btnImportCollection = new KryptonButton
        {
            Location = new System.Drawing.Point(632, 706),
            Size = new System.Drawing.Size(114, 43),
            Name = @"btnImportPaletteCollection"
        };
        btnImportCollection.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnImportCollection.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnImportCollection.Values.Text = @"Import pack" + Environment.NewLine + @"theme";
        btnImportCollection.Click += (_, _) => ImportPaletteCollection();

        var btnCollectionFolder = new KryptonButton
        {
            Location = new System.Drawing.Point(512, 754),
            Size = new System.Drawing.Size(234, 43),
            Name = @"btnCollectionFolder"
        };
        btnCollectionFolder.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnCollectionFolder.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnCollectionFolder.Values.Text = @"Collection folder" + Environment.NewLine + @"to .ktheme";
        btnCollectionFolder.Click += (_, _) => ExportCollectionFromFolder();

        var btnUpgradeXmlFolder = new KryptonButton
        {
            Location = new System.Drawing.Point(512, 802),
            Size = new System.Drawing.Size(234, 43),
            Name = @"btnUpgradeXmlFolder"
        };
        btnUpgradeXmlFolder.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnUpgradeXmlFolder.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnUpgradeXmlFolder.Values.Text = @"Upgrade folder" + Environment.NewLine + @".xml to .kthemex";
        btnUpgradeXmlFolder.Click += (_, _) => UpgradeXmlFolder();

        var btnEditCollection = new KryptonButton
        {
            Location = new System.Drawing.Point(512, 850),
            Size = new System.Drawing.Size(234, 43),
            Name = @"btnEditPaletteCollection"
        };
        btnEditCollection.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
        btnEditCollection.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
        btnEditCollection.Values.Text = @"Edit .ktheme collection" + Environment.NewLine + @"(add / remove)";
        btnEditCollection.Click += (_, _) => EditPaletteCollection();

        _paletteFileCombo = new KryptonPaletteFileComboBox
        {
            Location = new System.Drawing.Point(12, 748),
            Size = new System.Drawing.Size(490, 28),
            Name = @"kryptonPaletteFileComboBox",
            AutoApply = true,
            SearchSubdirectories = true
        };

        _paletteFileTree = new KryptonPaletteFileTreeView
        {
            Location = new System.Drawing.Point(12, 784),
            Size = new System.Drawing.Size(490, 160),
            Name = @"kryptonPaletteFileTreeView",
            AutoApply = true,
            SearchSubdirectories = true
        };

        Controls.Add(instructions);
        Controls.Add(btnKthemex);
        Controls.Add(btnNative);
        Controls.Add(btnConvert);
        Controls.Add(btnUpgradeXml);
        Controls.Add(btnExportCollection);
        Controls.Add(btnImportCollection);
        Controls.Add(btnCollectionFolder);
        Controls.Add(btnUpgradeXmlFolder);
        Controls.Add(btnEditCollection);
        Controls.Add(_paletteFileCombo);
        Controls.Add(_paletteFileTree);
        instructions.BringToFront();
        btnKthemex.BringToFront();
        btnNative.BringToFront();
        btnConvert.BringToFront();
        btnUpgradeXml.BringToFront();
        btnExportCollection.BringToFront();
        btnImportCollection.BringToFront();
        btnCollectionFolder.BringToFront();
        btnUpgradeXmlFolder.BringToFront();
        btnEditCollection.BringToFront();
        _paletteFileCombo.BringToFront();
        _paletteFileTree.BringToFront();
    }

    private void ExportPaletteCollection()
    {
        using var dialog = new SaveFileDialog
        {
            Title = @"Save Palette Collection",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.BinaryExtension,
            FileName = @"themes.ktheme",
            OverwritePrompt = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(kryptonPaletteCustom.GetPaletteName()))
        {
            kryptonPaletteCustom.SetPaletteName(@"Custom");
        }

        using var second = new KryptonCustomPaletteBase();
        second.SetPaletteName(@"Second");
        KryptonPaletteFile.ExportCollection(dialog.FileName, new[] { kryptonPaletteCustom, second }, ignoreDefaults: true, collectionName: @"Example pack");
        BindPaletteFileCombo(dialog.FileName);
        KryptonMessageBox.Show(this, $@"Exported pack to {dialog.FileName}", @"Palette Collection");
    }

    private void ExportCollectionFromFolder()
    {
        using var folder = new FolderBrowserDialog
        {
            Description = @"Select a folder of palette files (subfolders are included).",
            ShowNewFolderButton = false
        };

        if (folder.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Title = @"Save Folder Pack",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.BinaryExtension,
            FileName = Path.GetFileName(folder.SelectedPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)) + @".ktheme",
            OverwritePrompt = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var destination = KryptonPaletteFile.ExportCollectionFromDirectory(dialog.FileName, folder.SelectedPath);
            BindPaletteFileCombo(destination);
            var names = KryptonPaletteFile.GetThemeNames(destination);
            KryptonMessageBox.Show(this, $@"Packed {names.Length} themes to {destination}", @"Palette Collection");
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void ImportPaletteCollection()
    {
        using var dialog = new OpenFileDialog
        {
            Title = @"Load Palette Collection",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.BinaryExtension,
            CheckFileExists = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var names = KryptonPaletteFile.GetThemeNames(dialog.FileName);
            if (names.Length == 0)
            {
                return;
            }

            var themeName = names[0];
            kryptonPaletteCustom.Import(dialog.FileName, themeName, silent: true);
            ApplyCustomPalette();
            propertyGrid.SelectedObject = kryptonPaletteCustom;
            KryptonMessageBox.Show(this,
                $@"Loaded '{themeName}'. Themes in this pack: {string.Join(@", ", names)}",
                @"Palette Collection");
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void ConvertPaletteFile()
    {
        using var open = new OpenFileDialog
        {
            Title = @"Convert Palette From",
            Filter = KryptonPaletteFile.DialogFilter,
            // ToDo V120 LTS: Default this open dialog to Extension (.kthemex) once .xml is retired.
            DefaultExt = KryptonPaletteFile.XmlExtension,
            CheckFileExists = true
        };

        if (open.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        using var save = new SaveFileDialog
        {
            Title = @"Convert Palette To",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.Extension,
            FileName = Path.GetFileNameWithoutExtension(open.FileName) + @"." + KryptonPaletteFile.Extension,
            OverwritePrompt = true
        };

        if (save.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var destination = kryptonPaletteCustom.ConvertFile(open.FileName, save.FileName);
            ApplyCustomPalette();
            propertyGrid.SelectedObject = kryptonPaletteCustom;
            BindPaletteFileCombo(destination);
            KryptonMessageBox.Show(this, $@"Converted to {destination}", @"Palette Convert");
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void UpgradeXmlPaletteFile()
    {
        using var open = new OpenFileDialog
        {
            Title = @"Upgrade legacy .xml palette",
            Filter = @"XML palette files (*.xml)|*.xml|All files (*.*)|*.*",
            DefaultExt = KryptonPaletteFile.XmlExtension,
            CheckFileExists = true
        };

        if (open.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var destination = kryptonPaletteCustom.UpgradeXmlToKthemex(open.FileName);
            ApplyCustomPalette();
            propertyGrid.SelectedObject = kryptonPaletteCustom;
            BindPaletteFileCombo(destination);
            KryptonMessageBox.Show(this,
                $@"Upgraded to {destination}. The source .xml was left in place.",
                @"Palette Upgrade");
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void UpgradeXmlFolder()
    {
        using var folder = new FolderBrowserDialog
        {
            Description = @"Select a folder of legacy .xml palettes (subfolders are included).",
            ShowNewFolderButton = false
        };

        if (folder.ShowDialog(this) != DialogResult.OK || string.IsNullOrWhiteSpace(folder.SelectedPath))
        {
            return;
        }

        try
        {
            var result = KryptonPaletteFile.UpgradeXmlToKthemexFromDirectory(folder.SelectedPath, searchSubdirectories: true);
            BindPaletteFileCombo(folder.SelectedPath);
            var icon = result.ErrorCount > 0 ? KryptonMessageBoxIcon.Warning : KryptonMessageBoxIcon.Information;
            KryptonMessageBox.Show(this, result.ToSummaryString(), @"Upgrade folder .xml to .kthemex",
                KryptonMessageBoxButtons.OK, icon);
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void EditPaletteCollection()
    {
        using var dialog = new OpenFileDialog
        {
            Title = @"Edit Palette Collection",
            Filter = @"Krypton theme containers (*.ktheme)|*.ktheme|All files (*.*)|*.*",
            DefaultExt = KryptonPaletteFile.BinaryExtension,
            CheckFileExists = false
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        KryptonPaletteCollectionEditor.Show(this, dialog.FileName);
        if (File.Exists(dialog.FileName))
        {
            BindPaletteFileCombo(dialog.FileName);
        }
    }

    private void ExportPaletteFormat(KryptonPaletteFileFormat format, string suggestedName)
    {
        using var dialog = new SaveFileDialog
        {
            Title = @"Save Palette As",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.Extension,
            FileName = suggestedName,
            OverwritePrompt = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        kryptonPaletteCustom.Export(dialog.FileName, ignoreDefaults: true, silent: true, format);
        BindPaletteFileCombo(dialog.FileName);
        KryptonMessageBox.Show(this, $@"Exported {format} to {dialog.FileName}", @"Palette Export");
    }

    private void BindPaletteFileCombo(string palettePath)
    {
        if (_paletteFileCombo == null)
        {
            return;
        }

        var directory = Directory.Exists(palettePath)
            ? palettePath
            : Path.GetDirectoryName(palettePath);
        if (string.IsNullOrWhiteSpace(directory))
        {
            return;
        }

        _paletteFileCombo.AutoApply = false;
        _paletteFileCombo.SearchSubdirectories = true;
        _paletteFileCombo.PaletteDirectory = directory;
        _paletteFileCombo.AutoApply = true;

        if (_paletteFileTree != null)
        {
            _paletteFileTree.AutoApply = false;
            _paletteFileTree.SearchSubdirectories = true;
            _paletteFileTree.PaletteDirectory = directory;
            _paletteFileTree.AutoApply = true;
        }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        kryptonPaletteCustom.Export();

        btnExport.Enabled = false;
    }

    private void btnImportCustomPalette_Click(object sender, EventArgs e)
    {
        try
        {
            kryptonPaletteCustom.Import();

            ApplyCustomPalette();
            propertyGrid.SelectedObject = kryptonPaletteCustom;
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void kryptonThemeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnExport.Enabled = (kryptonThemeComboBox1.Text == @"Custom");
        if (btnExport.Enabled)
        {
            propertyGrid.SelectedObject = kryptonPaletteCustom;
        }
        else
        {
            //propertyGrid.SelectedObject = new KryptonCustomPaletteBase(components) {
            //    BasePaletteMode = kryptonThemeComboBox1.Manager.GlobalPaletteMode
            //};
            //propertyGrid.SelectedObject = kryptonThemeComboBox1.Manager.GlobalPaletteMode;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            // Simulate loading from Stream (i.e. from application resource) by acquiring filename first
            using var kofd = new KryptonOpenFileDialog {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = KryptonPaletteFile.Extension,
                Filter = KryptonPaletteFile.DialogFilter,
                Title = @"Load Custom Palette"
            };

            string paletteFileName = (kofd.ShowDialog() == DialogResult.OK)
                ? kofd.FileName
                : string.Empty;
            if (string.IsNullOrWhiteSpace(paletteFileName))
            {
                return;
            }
            kryptonPaletteCustom.ImportWithUpgrade(File.OpenRead(paletteFileName));

            ApplyCustomPalette();
            propertyGrid.SelectedObject = kryptonPaletteCustom;
        }
        catch (Exception exc)
        {
            KryptonMessageBox.Show(this, exc.ToString());
        }
    }

    private void ApplyCustomPalette() => ThemeManager.ApplyTheme(kryptonPaletteCustom, new KryptonManager());

    private void Form1_OnShown(object sender, EventArgs e) =>
        propertyGrid.SelectedObject = new KryptonCustomPaletteBase(components);

    private void button1_Click_1(object sender, EventArgs e)
    {

    }
}
