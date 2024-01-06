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
using System.ComponentModel;
using System.Drawing;

using Krypton.Toolkit;

namespace ApplicationMenu
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxShowRecentDocs.Checked = kryptonRibbon1.RibbonAppButton.AppButtonShowRecentDocs;
            textBoxDocsTitle.Text = kryptonRibbon1.RibbonStrings.RecentDocuments;
            textBoxMinWidth.Text = kryptonRibbon1.RibbonAppButton.AppButtonMinRecentSize.Width.ToString();
            textBoxMinHeight.Text = kryptonRibbon1.RibbonAppButton.AppButtonMinRecentSize.Height.ToString();
        }

        private void kryptonRibbon1_AppButtonMenuOpening(object sender, CancelEventArgs e)
        {
            kryptonRibbon1.RibbonAppButton.AppButtonShowRecentDocs = checkBoxShowRecentDocs.Checked;
            kryptonRibbon1.RibbonStrings.RecentDocuments = textBoxDocsTitle.Text;

            var minWidth = int.Parse(textBoxMinWidth.Text);
            var minHeight = int.Parse(textBoxMinHeight.Text);
            kryptonRibbon1.RibbonAppButton.AppButtonMinRecentSize = new Size(minWidth, minHeight);
        }

        private void button2010Blue_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = true;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue;
        }

        private void button2010Silver_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = true;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver;
        }

        private void button2010Black_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = true;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black;
        }


        private void buttonBlue_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = true;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue;
        }

        private void buttonSilver_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = true;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = true;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black;
        }

        private void button2003_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = true;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;
        }

        private void buttonSparkleBlue_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = true;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue;
        }

        private void buttonSparkleOrange_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = true;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleOrange;
        }

        private void buttonSparklePurple_Click(object sender, EventArgs e)
        {
            button2010Blue.Checked = false;
            button2010Silver.Checked = false;
            button2010Black.Checked = false;
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = true;
            buttonSystem.Checked = false;
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparklePurple;
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            buttonBlue.Checked = false;
            buttonSilver.Checked = false;
            buttonBlack.Checked = false;
            button2003.Checked = false;
            buttonSparkleBlue.Checked = false;
            buttonSparkleOrange.Checked = false;
            buttonSparklePurple.Checked = false;
            buttonSystem.Checked = true;
            kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
        }
    }
}
