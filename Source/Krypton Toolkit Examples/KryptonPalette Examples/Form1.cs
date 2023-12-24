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
using System.IO;
using System.Windows.Forms;

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

                kryptonThemeComboBox1.Manager.GlobalCustomPalette = kryptonPaletteCustom;
                propertyGrid.SelectedObject = kryptonPaletteCustom;

                //kryptonThemeComboBox1.Manager.GlobalPaletteMode = PaletteMode.Custom;
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
                propertyGrid.SelectedObject = kryptonThemeComboBox1.Manager.GlobalPaletteMode;
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
                    DefaultExt = @"xml",
                    Filter = @"Palette files (*.xml)|*.xml|All files (*.*)|(*.*)",
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

                kryptonThemeComboBox1.Manager.GlobalCustomPalette = kryptonPaletteCustom;
                propertyGrid.SelectedObject = new KryptonCustomPaletteBase(components);
                kryptonThemeComboBox1.Manager.GlobalPaletteMode = PaletteMode.Custom;
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show(this, exc.ToString());
            }
        }

        private void Form1_OnShown(object sender, EventArgs e) =>
            propertyGrid.SelectedObject = new KryptonCustomPaletteBase(components);

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
