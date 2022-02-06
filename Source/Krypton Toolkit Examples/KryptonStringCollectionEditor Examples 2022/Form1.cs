using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonStringCollectionEditorExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            KryptonStringCollectionEditor collectionEditor = new KryptonStringCollectionEditor(ktxtHeaderText.Text,
                ktxtCancelButtonText.Text, ktxtCueText.Text, ktxOKButtonText.Text, kcbUseRichTextBox.Checked,
                ktxtHelpMessageBoxTitleText.Text, ktxtHelpMessageBoxText.Text);

            if (collectionEditor.ShowDialog() == DialogResult.OK)
            {
                KryptonMessageBox.Show($"Result:\n{collectionEditor.ReturnContentText()}", "Result", MessageBoxButtons.OK,
                    KryptonMessageBoxIcon.INFORMATION);
            }
        }
    }
}
