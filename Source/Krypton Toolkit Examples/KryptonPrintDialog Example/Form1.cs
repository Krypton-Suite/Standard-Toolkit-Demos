using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonFontDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        private KryptonManager _manager = new KryptonManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Palette2010Blue_CheckedChanged(object sender, EventArgs e) => _manager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;

        private void Palette2010Silver_CheckedChanged(object sender, EventArgs e) => _manager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;

        private void Palette2010Black_CheckedChanged(object sender, EventArgs e) => _manager.GlobalPaletteMode = PaletteModeManager.Office2010Black;

        private void Palette2007Blue_CheckedChanged(object sender, EventArgs e) => _manager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;

        private void PaletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => _manager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;

        private void PaletteProfessional_CheckedChanged(object sender, EventArgs e) => _manager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;

 
        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            //PrintDialog;
            var docToPrint = new System.Drawing.Printing.PrintDocument();
            docToPrint.PrintPage += DocToPrint_PrintPage;
            var kfd = new KryptonPrintDialog {
                ShowHelp = chkShowHelp.Checked,
                AllowCurrentPage = chkAllowCurrentPage.Checked,
                AllowPrintToFile = chkAllowPrintToFile.Checked,
                AllowSelection = chkAllowSelection.Checked,
                AllowSomePages = chkAllowSomePages.Checked,
                ShowNetwork = chkShowNetwork.Checked,
                //UseEXDialog = chkUseEXDialog.Checked,     <- Currently there is not a kryptonised version
                Document = docToPrint
            };
            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, @"Now call docToPrint.Print();");
            }
        }

        private void DocToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
    }
}
