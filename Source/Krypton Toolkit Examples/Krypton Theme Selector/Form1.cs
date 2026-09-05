// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2022 - 2024. All rights reserved.
// *****************************************************************************

using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonThemeSelector;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
        ClientSize = new Size(640, 520);
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = true;
        var listView = new KryptonThemeListView
        {
            Dock = DockStyle.Bottom,
            Height = 340
        };
        var hoverHint = new KryptonLabel
        {
            Dock = DockStyle.Top,
            AutoSize = false,
            Height = 28,
            Text = @"Hover a theme in the list view for a live preview. Click to apply. Leave the list to restore the last clicked theme."
        };
        kryptonPanel1.Controls.Add(listView);
        kryptonPanel1.Controls.Add(hoverHint);
        listView.BringToFront();
    }

    private void kbtnUseListBox_Click(object sender, System.EventArgs e)
    {
        var themeBrowserData = new KryptonThemeBrowserData() {
            ShowImportButton = true,
            ShowSilentOption = true,
            StartIndex = 0,
            StartPosition = FormStartPosition.CenterScreen,
            WindowTitle = string.Empty
        };

        KryptonThemeBrowser.Show(themeBrowserData);
    }
}