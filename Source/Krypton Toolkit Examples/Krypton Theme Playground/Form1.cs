using System;

using Krypton.Toolkit;

namespace KryptonThemePlayground
{
    public partial class Form1 : KryptonForm
    {
        private KryptonManager _manager = new KryptonManager();

        public Form1()
        {
            InitializeComponent();

            ThemeManager.PropagateThemeSelector(kcmbTheme);
            kcmbTheme.Text = ThemeManager.ReturnPaletteModeManagerAsString(_manager.GlobalPaletteMode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kcmbTheme_SelectedValueChanged(object sender, EventArgs e)
        {
            ThemeManager.SetTheme(kcmbTheme.Text, _manager);
        }
    }
}
