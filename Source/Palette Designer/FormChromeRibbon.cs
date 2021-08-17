#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion

using Krypton.Toolkit;

namespace PaletteDesigner
{
    public partial class FormChromeRibbon : KryptonForm
    {
        #region Identity
        public FormChromeRibbon()
        {
            InitializeComponent();
        }
        #endregion

        #region Public
        public KryptonPalette OverridePalette
        {
            set
            {
                Palette = value;
                kryptonPanel1.Palette = value;
                kryptonRibbon1.Palette = value;
            }
        }
        #endregion
    }
}
