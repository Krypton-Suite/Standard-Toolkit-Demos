#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion

using System;

using Krypton.Toolkit;

namespace KryptonPaletteExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

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

                kryptonThemeComboBox1.Manager.GlobalPalette = kryptonPaletteCustom;

                kryptonThemeComboBox1.Manager.GlobalPaletteMode = PaletteMode.Custom;
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show(this, exc.ToString());
            }
        }

        private void kryptonThemeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = (kryptonThemeComboBox1.Text == @"Custom");
            KryptonCustomPaletteBase selectedPalette;
            if (btnExport.Enabled)
            {
                selectedPalette = kryptonPaletteCustom;
            }
            else
            {
                selectedPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
                selectedPalette.BasePaletteMode = kryptonThemeComboBox1.Manager.GlobalPaletteMode;
            }

            propertyGrid.SelectedObject = selectedPalette;
        }

    }
}
