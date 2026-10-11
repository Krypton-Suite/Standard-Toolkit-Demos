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
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonRtlExamples;

public partial class Form1 : KryptonForm
{
    private KryptonCheckBox? _chkRtl;
    private KryptonContextMenu? _rtlContextMenu;

    public Form1()
    {
        InitializeComponent();
        BuildGallery();
    }

    private void BuildGallery()
    {
        var instructions = new KryptonLabel
        {
            Dock = DockStyle.Top,
            AutoSize = false,
            Height = 56,
            Values =
            {
                Text = "Issue #2379 — Toggle RightToLeft + RightToLeftLayout. Spin buttons, lists, " +
                       "splitters, group/header captions, checkbox glyphs, context menus, PropertyGrid, " +
                       "and TaskDialog columns follow the two-flag contract. Caption text stays readable."
            }
        };

        var options = new KryptonPanel
        {
            Dock = DockStyle.Top,
            Height = 40
        };
        _chkRtl = new KryptonCheckBox
        {
            Text = "RightToLeft + RightToLeftLayout",
            Location = new Point(12, 10),
            AutoSize = true
        };
        _chkRtl.CheckedChanged += (_, _) => SetDualRtl(_chkRtl.Checked);
        options.Controls.Add(_chkRtl);

        var split = new KryptonSplitContainer
        {
            Dock = DockStyle.Fill,
            SplitterDistance = 280
        };

        var flow = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            AutoScroll = true,
            Padding = new Padding(8)
        };
        flow.Controls.Add(new KryptonCheckBox { Text = "CheckBox", AutoSize = true });
        flow.Controls.Add(new KryptonRadioButton { Text = "RadioButton", AutoSize = true, Checked = true });
        flow.Controls.Add(new KryptonNumericUpDown { Value = 7, Width = 140 });
        var domain = new KryptonDomainUpDown { Width = 140 };
        domain.Items.Add("One");
        domain.Items.Add("Two");
        domain.SelectedIndex = 0;
        flow.Controls.Add(domain);
        flow.Controls.Add(new KryptonComboBox { Width = 180, Text = "ComboBox" });
        flow.Controls.Add(new KryptonTextBox { Width = 180, Text = "TextBox" });
        var list = new KryptonListBox { Width = 180, Height = 80 };
        list.Items.Add("List one");
        list.Items.Add("List two");
        flow.Controls.Add(list);
        var checkedList = new KryptonCheckedListBox { Width = 180, Height = 70 };
        checkedList.Items.Add("Checked one");
        checkedList.Items.Add("Checked two");
        flow.Controls.Add(checkedList);

        _rtlContextMenu = new KryptonContextMenu();
        var menuItems = new KryptonContextMenuItems();
        menuItems.Items.Add(new KryptonContextMenuItem("Item one"));
        var subItem = new KryptonContextMenuItem("Submenu");
        subItem.Items.Add(new KryptonContextMenuItem("Child item"));
        menuItems.Items.Add(subItem);
        _rtlContextMenu.Items.Add(menuItems);
        var menuButton = new KryptonButton { Text = "Context menu", Width = 180 };
        menuButton.Click += (_, _) => _rtlContextMenu!.Show(menuButton);
        flow.Controls.Add(menuButton);
        flow.Controls.Add(new KryptonPropertyGrid
        {
            Width = 180,
            Height = 88,
            SelectedObject = menuButton
        });
        var taskDialogButton = new KryptonButton { Text = "TaskDialog", Width = 180 };
        taskDialogButton.Click += (_, _) => ShowRtlTaskDialog();
        flow.Controls.Add(taskDialogButton);

        split.Panel1.Controls.Add(flow);

        var group = new KryptonGroupBox
        {
            Dock = DockStyle.Fill,
            Values = { Heading = "GroupBox" }
        };
        group.Panel.Controls.Add(new KryptonRichTextBox
        {
            Dock = DockStyle.Fill,
            Text = "Rich text sample for RTL reading order."
        });
        var header = new KryptonHeaderGroup
        {
            Dock = DockStyle.Top,
            Height = 72
        };
        header.ValuesPrimary.Heading = "HeaderGroup";
        split.Panel2.Controls.Add(group);
        split.Panel2.Controls.Add(header);

        Controls.Add(split);
        Controls.Add(options);
        Controls.Add(instructions);
    }

    private void SetDualRtl(bool enabled)
    {
        RightToLeft = enabled ? RightToLeft.Yes : RightToLeft.No;
        RightToLeftLayout = enabled;
        ApplyDualRtl(this, enabled);
        PerformLayout();
        Refresh();
    }

    private void ShowRtlTaskDialog()
    {
        using var taskDialog = new KryptonTaskDialog();
        taskDialog.Heading.Text = "RTL TaskDialog";
        taskDialog.Heading.IconType = KryptonTaskDialogIconType.ShieldInformation;
        taskDialog.Heading.Visible = true;
        taskDialog.Content.Text = "Heading icon, content, and footer follow both RTL flags from this owner form.";
        taskDialog.Content.Visible = true;
        taskDialog.FooterBar.CommonButtons.Buttons = KryptonTaskDialogCommonButtonTypes.OK;
        taskDialog.FooterBar.Visible = true;
        taskDialog.ShowDialog(this);
    }

    private static void ApplyDualRtl(Control parent, bool enabled)
    {
        foreach (Control child in parent.Controls)
        {
            child.RightToLeft = enabled ? RightToLeft.Yes : RightToLeft.No;
            if (child is VisualControlBase visual)
            {
                visual.RightToLeftLayout = enabled;
            }
            else if (child is VisualPanel panel)
            {
                panel.RightToLeftLayout = enabled;
            }

            ApplyDualRtl(child, enabled);
        }
    }
}
