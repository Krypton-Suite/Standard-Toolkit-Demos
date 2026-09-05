#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
endregion

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonMenuBarExamples;

/// <summary>
/// Consumer example for <see cref="KryptonMenuBar"/> compared with <see cref="KryptonMenuStrip"/> and native <see cref="MenuStrip"/>.
/// </summary>
public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
        MenuBar = kryptonMenuBar1;
        kryptonMenuBar1.InsertStandardItems();
        BuildComparisonStrips();
        WireMenuBarClicks(kryptonMenuBar1.Items);
        AddShortcutDemo();
    }

    private void BuildComparisonStrips()
    {
        kryptonMenuStrip1.Items.AddRange(
        [
            CreateToolStripMenu("&File", "&New", "&Open", "&Save", "-", "E&xit"),
            CreateToolStripMenu("&Edit", "&Undo", "&Redo", "-", "Cu&t", "&Copy", "&Paste")
        ]);

        menuStrip1.Items.AddRange(
        [
            CreateToolStripMenu("&File", "&New", "&Open", "&Save", "-", "E&xit"),
            CreateToolStripMenu("&Edit", "&Undo", "&Redo", "-", "Cu&t", "&Copy", "&Paste")
        ]);
    }

    private static ToolStripMenuItem CreateToolStripMenu(string text, params string[] children)
    {
        var root = new ToolStripMenuItem(text);
        foreach (var child in children)
        {
            if (child == "-")
            {
                root.DropDownItems.Add(new ToolStripSeparator());
                continue;
            }

            root.DropDownItems.Add(new ToolStripMenuItem(child));
        }

        return root;
    }

    private void WireMenuBarClicks(IEnumerable<KryptonContextMenuItemBase> items)
    {
        foreach (var item in items)
        {
            if (item is KryptonContextMenuItem menuItem)
            {
                menuItem.Click += (_, _) => klblStatus.Text = $"Clicked: {menuItem.Text}";
                WireMenuBarClicks(menuItem.Items);
                continue;
            }

            for (var i = 0; i < item.ItemChildCount; i++)
            {
                var child = item[i];
                if (child != null)
                {
                    WireMenuBarClicks(new[] { child });
                }
            }
        }
    }

    private void AddShortcutDemo()
    {
        foreach (KryptonContextMenuItemBase item in kryptonMenuBar1.Items)
        {
            if (item is not KryptonContextMenuItem fileItem
                || !fileItem.Text.Contains("File", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            foreach (KryptonContextMenuItemBase group in fileItem.Items)
            {
                for (var i = 0; i < group.ItemChildCount; i++)
                {
                    if (group[i] is KryptonContextMenuItem child
                        && child.Text.Contains("New", StringComparison.OrdinalIgnoreCase))
                    {
                        child.ShortcutKeys = Keys.Control | Keys.N;
                        return;
                    }
                }
            }
        }
    }

    private void kbtnInsertStandardItems_Click(object sender, EventArgs e)
    {
        kryptonMenuBar1.Items.Clear();
        kryptonMenuBar1.InsertStandardItems();
        WireMenuBarClicks(kryptonMenuBar1.Items);
        AddShortcutDemo();
        klblStatus.Text = "Insert Standard Items replaced the KryptonMenuBar collection.";
    }
}
