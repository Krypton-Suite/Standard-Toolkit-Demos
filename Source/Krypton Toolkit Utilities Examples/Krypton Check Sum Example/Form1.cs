using System;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonCheckSumExample;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private void kbtnComputeFileCheckSum_Click(object sender, EventArgs e) => KryptonComputeFileCheckSum.Show(this);

    private void kbtnVerifyFileCheckSum_Click(object sender, EventArgs e) => KryptonVerifyFileCheckSum.Show(this);

    private void kbtnCancel_Click(object sender, EventArgs e) => Close();
}
