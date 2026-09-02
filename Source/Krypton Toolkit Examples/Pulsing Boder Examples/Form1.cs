using System;

using Krypton.Toolkit;

namespace PulsingBorderExamples;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private void kbtnKryptonManagerProperties_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kryptonManager1;
    }

    private void ktxtAnimatedGlow_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = ktxtAnimatedGlow;
    }

    private void ktxtStaticGlow_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = ktxtStaticGlow;
    }

    private void kmtxtPhone_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kmtxtPhone;
    }

    private void kcmbGlow_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kcmbGlow;
    }

    private void krtbGlow_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = krtbGlow;
    }

    private void knudQuantity_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = knudQuantity;
    }

    private void kdudPriority_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kdudPriority;
    }

    private void kdtpDue_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kdtpDue;
    }

    private void kcalcBudget_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kcalcBudget;
    }

    private void kbtnGlow_Click(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kbtnGlow;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        kryptonPropertyGrid1.SelectedObject = kryptonManager1;
    }
}
