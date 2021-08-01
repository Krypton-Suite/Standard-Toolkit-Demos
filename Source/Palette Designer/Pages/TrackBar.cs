using System.Windows.Forms;

using Krypton.Toolkit;

namespace PaletteDesigner.Pages
{
    public partial class TrackBar : UserControl
    {
        private readonly KryptonTrackBar[] tBars;
        public TrackBar()
        {
            InitializeComponent();

            tBars = new[]
            {
                kryptonTrackBar1,
                kryptonTrackBar5,
                kryptonTrackBar2,
                kryptonTrackBar6,
                kryptonTrackBar3,
                kryptonTrackBar7,
                kryptonTrackBar4,
                kryptonTrackBar8,
                kryptonTrackBar9,
                kryptonTrackBar10,
                kryptonTrackBar11,
                kryptonTrackBar12,
                kryptonTrackBar13,
                kryptonTrackBar14,
                kryptonTrackBar15,
                kryptonTrackBar16

            };
            // TrackBar fixed states
            kryptonTrackBar1.SetFixedState(PaletteState.Normal);
            kryptonTrackBar5.SetFixedState(PaletteState.Normal);
            kryptonTrackBar15.SetFixedState(PaletteState.Normal);
            kryptonTrackBar16.SetFixedState(PaletteState.Normal);

            kryptonTrackBar2.SetFixedState(PaletteState.Tracking);
            kryptonTrackBar6.SetFixedState(PaletteState.Tracking);
            kryptonTrackBar13.SetFixedState(PaletteState.Tracking);
            kryptonTrackBar14.SetFixedState(PaletteState.Tracking);

            kryptonTrackBar3.SetFixedState(PaletteState.Pressed);
            kryptonTrackBar7.SetFixedState(PaletteState.Pressed);
            kryptonTrackBar11.SetFixedState(PaletteState.Pressed);
            kryptonTrackBar12.SetFixedState(PaletteState.Pressed);

            kryptonTrackBar4.SetFixedState(PaletteState.Disabled);
            kryptonTrackBar8.SetFixedState(PaletteState.Disabled);
            kryptonTrackBar9.SetFixedState(PaletteState.Disabled);
            kryptonTrackBar10.SetFixedState(PaletteState.Disabled);
        }

        public void ApplyPalette(KryptonPalette palette)
        {
            foreach (var bar in tBars)
            {
                bar.Palette = palette;
            }

        }
    }
}
