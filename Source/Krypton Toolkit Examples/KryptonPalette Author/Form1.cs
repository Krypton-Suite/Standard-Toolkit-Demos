#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, tobitege, KamaniAR, Lesandro Gotardo (aka lesandrog), Jorge A. Avilés (aka mcpbcs) et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonPaletteAuthor;

public partial class Form1 : KryptonForm
{
    private string? _currentPath;
    private bool _dirty;

    public Form1()
    {
        InitializeComponent();
        KryptonPaletteFile.EnsureShellAssociations();
        TryLoadExtraThemesAssembly();
        FillBaseThemes();
        propertyGrid.SelectedObject = kryptonPalette;
        ApplyPreview();
        UpdateCaption();
    }

    private static void TryLoadExtraThemesAssembly()
    {
        try
        {
            Assembly.Load("Krypton.Themes");
        }
        catch (Exception)
        {
            // Extra palettes stay unavailable when Krypton.Themes is not beside the executable.
        }
    }

    private void FillBaseThemes()
    {
        cboBaseTheme.Items.Clear();
        var names = ThemeManager.GetThemesArray();
        for (var i = 0; i < names.Length; i++)
        {
            var name = names[i];
            if (PaletteModeStrings.SupportedThemesMap.TryGetValue(name, out var mode)
                && mode != PaletteMode.Custom
                && mode != PaletteMode.Global)
            {
                cboBaseTheme.Items.Add(name);
            }
        }

        if (cboBaseTheme.Items.Count > 0)
        {
            var office = cboBaseTheme.Items.IndexOf(KryptonThemeCatalog.GetDisplayName(PaletteMode.Office2010Blue));
            cboBaseTheme.SelectedIndex = office >= 0 ? office : 0;
        }
    }

    private void NewPalette(object? sender, EventArgs e)
    {
        if (!ConfirmDiscard())
        {
            return;
        }

        kryptonPalette.ResetToDefaults(silent: true);
        kryptonPalette.SetPaletteName(string.Empty);
        kryptonPalette.Thumbnail = null;
        _currentPath = null;
        _dirty = false;
        BindEditors();
        ApplyPreview();
        SetStatus("New palette.");
    }

    private void OpenPalette(object? sender, EventArgs e)
    {
        if (!ConfirmDiscard())
        {
            return;
        }

        using var dialog = new OpenFileDialog
        {
            Title = @"Open palette",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.Extension,
            CheckFileExists = true
        };
        SetInitialDirectory(dialog);

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        OpenFromPath(dialog.FileName, themeName: null);
    }

    private void OpenSelectedFromTree(object? sender, EventArgs e) => OpenTreeSelection();

    private void FileTreeDoubleClick(object? sender, TreeNodeMouseClickEventArgs e) => OpenTreeSelection();

    private void OpenTreeSelection()
    {
        var item = fileTree.SelectedPaletteTheme;
        if (item == null)
        {
            return;
        }

        if (!ConfirmDiscard())
        {
            return;
        }

        OpenFromPath(item.FilePath, string.IsNullOrEmpty(item.ThemeName) ? null : item.ThemeName);
    }

    private void OpenFromPath(string path, string? themeName)
    {
        try
        {
            if (themeName == null && KryptonPaletteFile.IsPack(path))
            {
                var names = KryptonPaletteFile.GetThemeNames(path);
                if (names.Length == 0)
                {
                    throw new InvalidOperationException("The pack does not contain any named themes.");
                }

                if (names.Length == 1)
                {
                    themeName = names[0];
                }
                else
                {
                    themeName = PromptPackTheme(path, names);
                    if (themeName == null)
                    {
                        return;
                    }
                }
            }

            if (themeName is string selectedTheme && selectedTheme.Length > 0)
            {
                kryptonPalette.Import(path, selectedTheme, silent: true);
            }
            else
            {
                kryptonPalette.Import(path, silent: true);
            }

            _currentPath = path;
            _dirty = false;
            RememberFolder(Path.GetDirectoryName(path));
            BindEditors();
            ApplyPreview();
            ReloadFolderTree();
            var loadedName = themeName is string openedTheme && openedTheme.Length > 0
                ? openedTheme
                : kryptonPalette.GetPaletteName();
            SetStatus($"Opened '{loadedName}' from {path}.");
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(this, ex.Message, @"Open palette", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            SetStatus("Open failed.");
        }
    }

    private string? PromptPackTheme(string path, string[] names)
    {
        using var prompt = new KryptonForm
        {
            Text = @"Select pack theme",
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            ClientSize = new Size(420, 140),
            MaximizeBox = false,
            MinimizeBox = false,
            ShowInTaskbar = false
        };
        var label = new KryptonWrapLabel
        {
            Dock = DockStyle.Top,
            AutoSize = false,
            Height = 40,
            Text = $"'{Path.GetFileName(path)}' contains {names.Length} themes. Choose one to edit."
        };
        var combo = new KryptonComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Dock = DockStyle.Top,
            Height = 24
        };
        combo.Items.AddRange(names);
        combo.SelectedIndex = 0;
        var buttons = new FlowLayoutPanel
        {
            Dock = DockStyle.Bottom,
            FlowDirection = FlowDirection.RightToLeft,
            Height = 40,
            Padding = new Padding(8)
        };
        var ok = new KryptonButton { Text = @"OK", DialogResult = DialogResult.OK, Width = 80 };
        var cancel = new KryptonButton { Text = @"Cancel", DialogResult = DialogResult.Cancel, Width = 80 };
        buttons.Controls.Add(ok);
        buttons.Controls.Add(cancel);
        prompt.Controls.Add(buttons);
        prompt.Controls.Add(combo);
        prompt.Controls.Add(label);
        prompt.AcceptButton = ok;
        prompt.CancelButton = cancel;
        return prompt.ShowDialog(this) == DialogResult.OK
            ? combo.SelectedItem as string
            : null;
    }

    private void SavePalette(object? sender, EventArgs e)
    {
        if (_currentPath is string path && path.Length > 0)
        {
            WriteCurrentPath(path);
            return;
        }

        SavePaletteAs(sender, e);
    }

    private void SavePaletteAs(object? sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Title = @"Save palette",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.Extension,
            FileName = SuggestFileName(),
            OverwritePrompt = true
        };
        SetInitialDirectory(dialog);

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        WriteCurrentPath(dialog.FileName);
    }

    private void WriteCurrentPath(string path)
    {
        try
        {
            SyncNameFromEditor();
            kryptonPalette.Export(path, ignoreDefaults: false, silent: true);
            _currentPath = path;
            _dirty = false;
            RememberFolder(Path.GetDirectoryName(path));
            ReloadFolderTree();
            BindEditors();
            var info = new FileInfo(path);
            SetStatus($"Saved {path} ({info.Length:N0} bytes).");
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(this, ex.Message, @"Save palette", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            SetStatus("Save failed.");
        }
    }

    private void ConvertPaletteFile(object? sender, EventArgs e)
    {
        using var open = new OpenFileDialog
        {
            Title = @"Convert palette from",
            Filter = KryptonPaletteFile.DialogFilter,
            // ToDo V120 LTS: Default this open dialog to Extension (.kpalx) once .xml is retired.
            DefaultExt = KryptonPaletteFile.XmlExtension,
            CheckFileExists = true
        };
        SetInitialDirectory(open);
        if (open.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        using var save = new SaveFileDialog
        {
            Title = @"Convert palette to",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.Extension,
            FileName = Path.GetFileNameWithoutExtension(open.FileName) + @"." + KryptonPaletteFile.Extension,
            OverwritePrompt = true
        };
        SetInitialDirectory(save);
        if (save.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var destination = kryptonPalette.ConvertFile(open.FileName, save.FileName);
            _currentPath = destination;
            _dirty = false;
            RememberFolder(Path.GetDirectoryName(destination));
            ReloadFolderTree();
            BindEditors();
            ApplyPreview();
            var info = new FileInfo(destination);
            SetStatus($"Converted to {destination} ({info.Length:N0} bytes).");
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(this, ex.Message, @"Convert palette", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            SetStatus("Convert failed.");
        }
    }

    private void UpgradeXmlPaletteFile(object? sender, EventArgs e)
    {
        using var open = new OpenFileDialog
        {
            Title = @"Upgrade legacy .xml palette",
            Filter = @"XML palette files (*.xml)|*.xml|All files (*.*)|*.*",
            DefaultExt = KryptonPaletteFile.XmlExtension,
            CheckFileExists = true
        };
        SetInitialDirectory(open);
        if (open.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var destination = kryptonPalette.UpgradeXmlToKpalx(open.FileName);
            _currentPath = destination;
            _dirty = false;
            RememberFolder(Path.GetDirectoryName(destination));
            ReloadFolderTree();
            BindEditors();
            ApplyPreview();
            var info = new FileInfo(destination);
            SetStatus($"Upgraded to {destination} ({info.Length:N0} bytes). Source .xml left in place.");
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(this, ex.Message, @"Upgrade palette", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            SetStatus("Upgrade failed.");
        }
    }

    private void UpgradeXmlFolder(object? sender, EventArgs e)
    {
        using var folder = new FolderBrowserDialog
        {
            Description = @"Select a folder of legacy .xml palettes (subfolders are included).",
            ShowNewFolderButton = false
        };
        if (!string.IsNullOrWhiteSpace(txtFolder.Text) && Directory.Exists(txtFolder.Text))
        {
            folder.SelectedPath = txtFolder.Text;
        }

        if (folder.ShowDialog(this) != DialogResult.OK || string.IsNullOrWhiteSpace(folder.SelectedPath))
        {
            return;
        }

        try
        {
            var result = KryptonPaletteFile.UpgradeXmlToKpalxFromDirectory(folder.SelectedPath, searchSubdirectories: true);
            RememberFolder(folder.SelectedPath);
            ReloadFolderTree();
            SetStatus($"Converted {result.ConvertedCount} palette(s) to .kpalx ({result.SkippedCount} skipped, {result.ErrorCount} failed).");
            var icon = result.ErrorCount > 0 ? KryptonMessageBoxIcon.Warning : KryptonMessageBoxIcon.Information;
            KryptonMessageBox.Show(this, result.ToSummaryString(), @"Upgrade folder .xml to .kpalx",
                KryptonMessageBoxButtons.OK, icon);
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(this, ex.Message, @"Upgrade folder", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            SetStatus("Upgrade folder failed.");
        }
    }

    private void PackFolder(object? sender, EventArgs e)
    {
        using var folder = new FolderBrowserDialog
        {
            Description = @"Select a folder of .kpalx / .kpal / .xml palettes (subfolders are included).",
            ShowNewFolderButton = false
        };
        if (!string.IsNullOrWhiteSpace(txtFolder.Text) && Directory.Exists(txtFolder.Text))
        {
            folder.SelectedPath = txtFolder.Text;
        }

        if (folder.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var sourceFolder = folder.SelectedPath ?? string.Empty;
        using var dialog = new SaveFileDialog
        {
            Title = @"Save folder pack",
            Filter = KryptonPaletteFile.DialogFilter,
            DefaultExt = KryptonPaletteFile.BinaryExtension,
            FileName = Path.GetFileName(sourceFolder.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)) + @".kpal",
            OverwritePrompt = true
        };
        SetInitialDirectory(dialog);
        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var destination = KryptonPaletteFile.ExportPackFromDirectory(
                dialog.FileName,
                sourceFolder,
                searchSubdirectories: true,
                ignoreDefaults: false,
                packName: Path.GetFileName(sourceFolder));
            RememberFolder(Path.GetDirectoryName(destination));
            ReloadFolderTree();
            var names = KryptonPaletteFile.GetThemeNames(destination);
            var info = new FileInfo(destination);
            SetStatus($"Packed {names.Length} themes to {destination} ({info.Length:N0} bytes).");
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(this, ex.Message, @"Pack folder", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            SetStatus("Pack folder failed.");
        }
    }

    private void EditPack(object? sender, EventArgs e)
    {
        string? packPath = null;
        if (!string.IsNullOrWhiteSpace(_currentPath)
            && string.Equals(Path.GetExtension(_currentPath), @"." + KryptonPaletteFile.BinaryExtension, StringComparison.OrdinalIgnoreCase))
        {
            packPath = _currentPath;
        }

        KryptonPalettePackEditor.Show(this, packPath);
        ReloadFolderTree();
        SetStatus("Closed the pack editor.");
    }

    private void PopulateFromSelectedTheme(object? sender, EventArgs e)
    {
        if (cboBaseTheme.SelectedItem is not string name
            || !PaletteModeStrings.SupportedThemesMap.TryGetValue(name, out var mode)
            || mode == PaletteMode.Custom)
        {
            KryptonMessageBox.Show(this, @"Select a builtin theme to copy values from.", @"Populate",
                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            return;
        }

        kryptonPalette.BasePaletteMode = mode;
        kryptonPalette.PopulateFromBase(silent: true);
        kryptonPalette.SetPaletteName(name);
        _dirty = true;
        BindEditors();
        ApplyPreview();
        SetStatus($"Populated from '{name}'.");
    }

    private void ResetPalette(object? sender, EventArgs e)
    {
        if (!ConfirmDiscard())
        {
            return;
        }

        kryptonPalette.ResetToDefaults(silent: true);
        _dirty = true;
        BindEditors();
        ApplyPreview();
        SetStatus("Reset to defaults.");
    }

    private void SetPaletteName(object? sender, EventArgs e)
    {
        SyncNameFromEditor();
        _dirty = true;
        ApplyPreview();
        SetStatus($"Palette name set to '{kryptonPalette.GetPaletteName()}'.");
    }

    private void LoadThumbnail(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Title = @"Load thumbnail",
            Filter = @"Images|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files|*.*",
            CheckFileExists = true
        };
        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        using var loaded = Image.FromFile(dialog.FileName);
        var copy = new Bitmap(loaded);
        var previous = kryptonPalette.Thumbnail;
        kryptonPalette.Thumbnail = copy;
        previous?.Dispose();
        _dirty = true;
        BindEditors();
        SetStatus($"Thumbnail loaded ({copy.Width}×{copy.Height}). Recommended size is {KryptonPaletteFile.RecommendedThumbnailSize}×{KryptonPaletteFile.RecommendedThumbnailSize}.");
    }

    private void ClearThumbnail(object? sender, EventArgs e)
    {
        var previous = kryptonPalette.Thumbnail;
        kryptonPalette.Thumbnail = null;
        previous?.Dispose();
        _dirty = true;
        BindEditors();
        SetStatus("Thumbnail cleared.");
    }

    private void BrowseFolder(object? sender, EventArgs e)
    {
        using var folder = new FolderBrowserDialog
        {
            Description = @"Folder of palette files to list in the tree.",
            ShowNewFolderButton = true
        };
        if (!string.IsNullOrWhiteSpace(txtFolder.Text) && Directory.Exists(txtFolder.Text))
        {
            folder.SelectedPath = txtFolder.Text;
        }

        if (folder.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        RememberFolder(folder.SelectedPath);
        ReloadFolderTree();
    }

    private void PropertyGridValueChanged(object? sender, PropertyValueChangedEventArgs e)
    {
        _dirty = true;
        ApplyPreview();
        BindEditors();
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (!ConfirmDiscard())
        {
            e.Cancel = true;
        }
    }

    private void ApplyPreview()
    {
        kryptonManager.GlobalCustomPalette = kryptonPalette;
        kryptonManager.GlobalPaletteMode = PaletteMode.Custom;
        propertyGrid.SelectedObject = kryptonPalette;
        propertyGrid.Refresh();
        UpdateCaption();
    }

    private void BindEditors()
    {
        txtPaletteName.Text = kryptonPalette.GetPaletteName();
        picThumbnail.Image = kryptonPalette.Thumbnail;
        UpdateCaption();
    }

    private void SyncNameFromEditor()
    {
        kryptonPalette.SetPaletteName(txtPaletteName.Text ?? string.Empty);
        headerPreview.ValuesPrimary.Heading = string.IsNullOrWhiteSpace(txtPaletteName.Text)
            ? @"Live preview"
            : txtPaletteName.Text;
    }

    private void ReloadFolderTree()
    {
        var folder = txtFolder.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrEmpty(folder) || !Directory.Exists(folder))
        {
            fileTree.PaletteDirectory = string.Empty;
            fileTree.Reload();
            return;
        }

        fileTree.PaletteDirectory = folder;
        fileTree.Reload();
    }

    private void RememberFolder(string? folder)
    {
        if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
        {
            return;
        }

        txtFolder.Text = folder;
    }

    private void SetInitialDirectory(FileDialog dialog)
    {
        if (!string.IsNullOrWhiteSpace(txtFolder.Text) && Directory.Exists(txtFolder.Text))
        {
            dialog.InitialDirectory = txtFolder.Text;
        }
        else if (!string.IsNullOrEmpty(_currentPath))
        {
            var folder = Path.GetDirectoryName(_currentPath);
            if (!string.IsNullOrEmpty(folder))
            {
                dialog.InitialDirectory = folder;
            }
        }
    }

    private string SuggestFileName()
    {
        if (!string.IsNullOrEmpty(_currentPath))
        {
            return Path.GetFileName(_currentPath);
        }

        var name = kryptonPalette.GetPaletteName();
        return string.IsNullOrWhiteSpace(name)
            ? @"palette." + KryptonPaletteFile.Extension
            : name + @"." + KryptonPaletteFile.Extension;
    }

    private bool ConfirmDiscard()
    {
        if (!_dirty)
        {
            return true;
        }

        var result = KryptonMessageBox.Show(this,
            @"The palette has unsaved changes. Save before continuing?",
            @"Krypton Palette Author",
            KryptonMessageBoxButtons.YesNoCancel,
            KryptonMessageBoxIcon.Warning);
        if (result == DialogResult.Cancel)
        {
            return false;
        }

        if (result == DialogResult.Yes)
        {
            SavePalette(this, EventArgs.Empty);
            return !_dirty;
        }

        return true;
    }

    private void SetStatus(string text)
    {
        statusLabel.Text = text;
        UpdateCaption();
    }

    private void UpdateCaption()
    {
        var name = string.IsNullOrEmpty(_currentPath)
            ? @"Untitled"
            : Path.GetFileName(_currentPath);
        var dirty = _dirty ? @"*" : string.Empty;
        Text = $"{dirty}{name} — Krypton Palette Author";
    }
}
