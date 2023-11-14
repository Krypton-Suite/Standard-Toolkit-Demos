// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2021. All rights reserved.
// *****************************************************************************

using Krypton.Toolkit;

namespace KryptonWebBrowserExample
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.DocumentText = @"<div contenteditable=""true"">Standard Form WebBrowser.<br/> This is in Editable mode</div>";
            webBrowser2.DocumentText = @"<div contenteditable=""true"">Krypton WebBrowser.<br/> This is in Editable mode with a Krypton context menu</div>";

            ThemeManager.PropagateThemeSelector(kcmbTheme);
            kcmbTheme.Text = ThemeManager.ReturnPaletteModeAsString(kryptonManager1.GlobalPaletteMode);
        }

        private void KcmbTheme_SelectedValueChanged(object sender, System.EventArgs e) => ThemeManager.SetTheme(kcmbTheme.Text, kryptonManager1);
    }
}
