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
using System.Windows.Forms;

using Krypton.Toolkit;

namespace StandardDocking
{
    public partial class ContentPropertyGrid : UserControl
    {
        public ContentPropertyGrid()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // Unhook from events so this control can be garbage collected
            KryptonManager.GlobalPaletteChanged -= OnGlobalPaletteChanged;

            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ContentPropertyGrid_Load(object sender, EventArgs e)
        {
            // Hook into global palette changes
            KryptonManager.GlobalPaletteChanged += OnGlobalPaletteChanged;

            // Set correct initial font for the property grid
            OnGlobalPaletteChanged(null, EventArgs.Empty);
        }

        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            // Use the current font from the global palette
            var palette = KryptonManager.CurrentGlobalPalette;
            Font font = palette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);
            propertyGrid1.Font = font;
        }
    }
}
