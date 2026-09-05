#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonTagInputExample;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        ktiTags.SetSuggestions(new[]
        {
            "Bug", "Feature", "Documentation", "Performance", "Security",
            "Urgent", "Blocked", "Needs Review", "Good First Issue"
        });
        ktiTags.SetCategoryColor("Bug", Color.IndianRed);
        ktiTags.SetCategoryColor("Feature", Color.SteelBlue);
        ktiTags.SetCategoryColor("Security", Color.DarkOrange);
        ktiTags.SetCategoryColor("Urgent", Color.MediumVioletRed);
        ktiTags.SetCategoryColor("Documentation", Color.SeaGreen);

        ktiTags.Values.CueHintText = "Add a tag";
        ktiTags.AddTag("Bug");
        ktiTags.AddTag("Needs Review");
        RefreshSummary();
    }

    private void ktiTags_TagAdded(object? sender, KryptonTagEventArgs e) => RefreshSummary();

    private void ktiTags_TagRemoved(object? sender, KryptonTagEventArgs e) => RefreshSummary();

    private void ktiTags_TagAdding(object? sender, KryptonTagCancelEventArgs e)
    {
        if (string.Equals(e.Tag, "reject", StringComparison.OrdinalIgnoreCase))
        {
            e.Cancel = true;
            kwlblStatus.Text = "The sample rejects the tag 'reject' via TagAdding.";
        }
    }

    private void chkReadOnly_CheckedChanged(object sender, EventArgs e) =>
        ktiTags.ReadOnly = chkReadOnly.Checked;

    private void chkAllowDuplicates_CheckedChanged(object sender, EventArgs e) =>
        ktiTags.Values.AllowDuplicates = chkAllowDuplicates.Checked;

    private void kbtnAddUrgent_Click(object sender, EventArgs e) => ktiTags.AddTag("Urgent");

    private void kbtnClear_Click(object sender, EventArgs e) => ktiTags.ClearTags();

    private void RefreshSummary()
    {
        kwlblStatus.Text = ktiTags.Tags.Count == 0
            ? "No tags."
            : $"{ktiTags.Tags.Count} tag(s): {string.Join(", ", ktiTags.Tags)}";
    }
}
