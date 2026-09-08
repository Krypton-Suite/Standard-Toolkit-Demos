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
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Krypton.Ribbon;
using Krypton.Toolkit;

using RibbonControls.Properties;

namespace RibbonControls;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private static LinkLabel CreateLinkLabel(string text)
    {
        var ll = new LinkLabel
        {
            BackColor = Color.Transparent,
            Text = text
        };
        return ll;
    }

    private static NumericUpDown CreateNumericUpDown(decimal value)
    {
        var nud = new NumericUpDown
        {
            Value = value
        };
        return nud;
    }

    private static ProgressBar CreateProgressBar(int value)
    {
        var pb = new ProgressBar
        {
            Value = value
        };
        return pb;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Load the rich text box with RTF
        if (richTextBox1.RichTextBox is { } richTextBox)
        {
            richTextBox.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\colortbl ;\red0\green0\blue255;\red0\green128\blue0;\red255\green0\blue0;}{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\f0\fs20 RichTextBox\cf0  with \cf2 Multiline\cf0  set to \cf3 True\cf0 .\par}";
        }

        // Hook into the button spec buttons
        textBox3.ButtonSpecs[0].Click += OnTextBox3Clear!;
        comboBox3.ButtonSpecs[0].Click += OnComboBox3Clear!;
        dateTimePicker3.ButtonSpecs[0].Click += OnDateTimePicker3Clear!;
        maskedTextBox3.ButtonSpecs[0].Click += OnMaskedTextBox3Clear!;
        numericUpDown2.ButtonSpecs[0].Click += OnNumericUpDown2Clear!;

        // Create and associate various controls
        custom9.CustomControl = CreateLinkLabel("LinkLabel Control");
        custom10.CustomControl = CreateNumericUpDown(50);
        custom11.CustomControl = CreateProgressBar(75);

        // Issue #2382: live RTL toggle. Setting both flags on the form is enough; the ribbon syncs.
        var chkRtl = new KryptonCheckBox
        {
            Text = @"Right-to-left ribbon (RightToLeft + RightToLeftLayout) — File, QAT, tabs, and groups pack from the start edge; text stays readable.",
            AutoSize = true,
            Dock = DockStyle.Top,
            Padding = new Padding(8, 6, 8, 6)
        };
        chkRtl.CheckedChanged += (_, _) =>
        {
            var rtl = chkRtl.Checked;
            RightToLeft = rtl ? RightToLeft.Yes : RightToLeft.No;
            RightToLeftLayout = rtl;
        };
        Controls.Add(chkRtl);
        chkRtl.BringToFront();

        // Issue #4369: overlay this ribbon's captions via RibbonTranslations.xml (append; do not replace existing samples).
        AddRibbonTranslationsSection();
    }

    private void AddRibbonTranslationsSection()
    {
        kryptonRibbon.TranslationId = @"ribbonControls";
        kryptonRibbon.EnableAutoDiscoverTranslations = false;
        ribbonTab.TranslationId = @"home";
        kryptonRibbonGroup1.TranslationId = @"textBox";

        var bar = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Padding = new Padding(8, 4, 8, 4),
            WrapContents = true
        };

        var instructions = new KryptonLabel
        {
            AutoSize = true,
            Text = @"Issue #4369 Ribbon translations: export/import this ribbon's captions (XML/JSON). Apply German writes RibbonTranslations.de.xml and Auto Discovers it. Chrome strings stay on KryptonManager."
        };
        bar.Controls.Add(instructions);
        bar.Controls.Add(CreateTranslationsButton(@"Export XML…", OnExportRibbonTranslations));
        bar.Controls.Add(CreateTranslationsButton(@"Import XML…", OnImportRibbonTranslations));
        bar.Controls.Add(CreateTranslationsButton(@"Analyze…", OnAnalyzeRibbonTranslations));
        bar.Controls.Add(CreateTranslationsButton(@"Apply German", OnApplyGermanRibbonTranslations));
        bar.Controls.Add(CreateTranslationsButton(@"Reset English", OnResetEnglishRibbonTranslations));

        Controls.Add(bar);
        bar.BringToFront();
    }

    private static KryptonButton CreateTranslationsButton(string text, EventHandler onClick)
    {
        var button = new KryptonButton
        {
            Text = text,
            AutoSize = true,
            MinimumSize = new Size(110, 28)
        };
        button.Click += onClick;
        return button;
    }

    private void OnExportRibbonTranslations(object sender, EventArgs e)
    {
        using var sfd = new SaveFileDialog
        {
            OverwritePrompt = true,
            DefaultExt = @"xml",
            FileName = @"RibbonTranslations",
            Filter = @"Ribbon translations (*.xml)|*.xml|JSON (*.json)|*.json|All files (*.*)|(*.*)",
            Title = @"Export Ribbon Translations"
        };
        if (sfd.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var options = new RibbonTranslationOptions { IncludeDefaults = true, IncludeChrome = false };
        if (string.Equals(Path.GetExtension(sfd.FileName), @".json", StringComparison.OrdinalIgnoreCase))
        {
            kryptonRibbon.ExportTranslationsToJsonFile(sfd.FileName, options);
        }
        else
        {
            kryptonRibbon.ExportTranslationsToXmlFile(sfd.FileName, options);
        }
    }

    private void OnImportRibbonTranslations(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog
        {
            CheckFileExists = true,
            FileName = @"RibbonTranslations",
            Filter = @"Ribbon translations (*.xml;*.json)|*.xml;*.json|XML (*.xml)|*.xml|JSON (*.json)|*.json|All files (*.*)|(*.*)",
            Title = @"Import Ribbon Translations"
        };
        if (ofd.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var options = new RibbonTranslationOptions { ResetFirst = true };
        if (string.Equals(Path.GetExtension(ofd.FileName), @".json", StringComparison.OrdinalIgnoreCase))
        {
            kryptonRibbon.ImportTranslationsFromJsonFile(ofd.FileName, options);
        }
        else
        {
            kryptonRibbon.ImportTranslationsFromXmlFile(ofd.FileName, options);
        }
    }

    private void OnAnalyzeRibbonTranslations(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog
        {
            CheckFileExists = true,
            Filter = @"Ribbon translations (*.xml;*.json)|*.xml;*.json|All files (*.*)|(*.*)",
            Title = @"Analyze Ribbon Translations"
        };
        if (ofd.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var coverage = kryptonRibbon.AnalyzeTranslationsFromFile(ofd.FileName);
        KryptonMessageBox.Show(this,
            $@"Coverage: {coverage}. Missing={coverage.MissingInFile.Count}, Extra={coverage.ExtraInFile.Count}, Applied={coverage.Applied.Count}.",
            @"Ribbon translations");
    }

    private void OnApplyGermanRibbonTranslations(object sender, EventArgs e)
    {
        var folder = Path.Combine(Path.GetTempPath(), @"KryptonRibbonControlsTranslations");
        Directory.CreateDirectory(folder);

        ribbonTab.Text = @"Start";
        kryptonRibbonGroup1.TextLine1 = @"Textfeld";
        kryptonRibbon.RibbonFileAppTab.FileAppTabText = @"Datei";

        var filePath = Path.Combine(folder, @"RibbonTranslations.de.xml");
        kryptonRibbon.ExportTranslationsToXmlFile(filePath, new RibbonTranslationOptions { IncludeDefaults = true });

        OnResetEnglishRibbonTranslations(sender, e);

        kryptonRibbon.TranslationsSearchPath = folder;
        kryptonRibbon.EnableAutoDiscoverTranslations = true;
        kryptonRibbon.TryAutoDiscoverTranslations(folder, new CultureInfo(@"de"));
    }

    private void OnResetEnglishRibbonTranslations(object sender, EventArgs e)
    {
        ribbonTab.Text = @"Home";
        kryptonRibbonGroup1.TextLine1 = @"TextBox";
        kryptonRibbon.RibbonFileAppTab.FileAppTabText = @"File";
        kryptonRibbon.PerformNeedPaint(true);
    }

    private void OnTextBox3Clear(object sender, EventArgs e)
    {
        textBox3.Text = string.Empty;
    }

    private void OnComboBox3Clear(object sender, EventArgs e)
    {
        comboBox3.Text = "Windows Vista";
    }

    private void OnMaskedTextBox3Clear(object sender, EventArgs e)
    {
        maskedTextBox3.Text = string.Empty;
    }

    private void OnDateTimePicker3Clear(object sender, EventArgs e)
    {
        dateTimePicker3.Value = DateTime.Now;
    }

    private void OnNumericUpDown2Clear(object sender, EventArgs e)
    {
        numericUpDown2.Value = numericUpDown2.Minimum;
    }

    private void appMenu_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Settings.Default.Save();
    }
}
