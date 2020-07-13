// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2018 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-Toolkit-Suite-NET-Core)
//  Version 5.550.0  www.ComponentFactory.com
// *****************************************************************************

using ComponentFactory.Krypton.Toolkit;

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
