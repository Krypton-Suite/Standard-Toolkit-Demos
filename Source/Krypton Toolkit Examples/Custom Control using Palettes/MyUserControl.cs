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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace CustomControlUsingPalettes
{
    public class MyUserControl : UserControl
    {
        private bool _mouseOver;
        private bool _mouseDown;
        private PaletteBase? _palette;

        public MyUserControl()
        {
            // To remove flicker we use double buffering for drawing
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            // Cache the current global palette setting
            _palette = KryptonManager.CurrentGlobalPalette;

            // Hook into palette events
            if (_palette != null)
            {
                _palette.PalettePaint += OnPalettePaint;
            }

            // We want to be notified whenever the global palette changes
            KryptonManager.GlobalPaletteChanged += OnGlobalPaletteChanged;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Unhook from the palette events
                if (_palette != null)
                {
                    _palette.PalettePaint -= OnPalettePaint;
                    _palette = null;
                }

                // Unhook from the static events, otherwise we cannot be garbage collected
                KryptonManager.GlobalPaletteChanged -= OnGlobalPaletteChanged;
            }

            base.Dispose(disposing);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _mouseOver = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _mouseDown = (e.Button == MouseButtons.Left);
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _mouseDown = _mouseDown && (e.Button != MouseButtons.Left);
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _mouseOver = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_palette != null)
            {
                // Save the original state, so any changes we make are easy to undo
                GraphicsState state = e.Graphics.Save();

                // We want the inner part of the control to act like a button, so 
                // we need to find the correct palette state based on if the mouse 
                // is over the control and currently being pressed down or not.
                PaletteState buttonState = GetButtonState();

                /////////////////////////////////////////////////////
                // Get the various palette details needed to draw //
                // our fish in the various states we implement    //
                /////////////////////////////////////////////////////

                // Get the two colors and angle used to draw the control background
                Color backColor1 = _palette.GetBackColor1(PaletteBackStyle.PanelAlternate, Enabled ? PaletteState.Normal : PaletteState.Disabled);
                Color backColor2 = _palette.GetBackColor2(PaletteBackStyle.PanelAlternate, Enabled ? PaletteState.Normal : PaletteState.Disabled);
                float backColorAngle = _palette.GetBackColorAngle(PaletteBackStyle.PanelAlternate, Enabled ? PaletteState.Normal : PaletteState.Disabled);

                // Get the two colors and angle used to draw the fish area background
                Color fillColor1 = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, buttonState);
                Color fillColor2 = _palette.GetBackColor2(PaletteBackStyle.ButtonStandalone, buttonState);
                float fillColorAngle = _palette.GetBackColorAngle(PaletteBackStyle.ButtonStandalone, buttonState);

                // Get the color used to draw the fish border
                Color borderColor = _palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, buttonState);

                // Get the color and font used to draw the text
                Color textColor = _palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, buttonState);
                Font textFont = _palette.GetContentShortTextFont(PaletteContentStyle.ButtonStandalone, buttonState);

                /////////////////////////////////////////////////////
                // Perform actual drawing using the palette values //
                /////////////////////////////////////////////////////

                // Populate a graphics path to describe the shape we want to draw
                using (GraphicsPath path = CreateFishPath())
                {
                    // We want to anti alias the drawing for nice smooth curves
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // Fill the entire background in the control background color
                    using (var backBrush = new LinearGradientBrush(ClientRectangle, backColor1, backColor2, backColorAngle))
                    {
                        e.Graphics.FillRectangle(backBrush, e.ClipRectangle);
                    }

                    // Fill the entire fish background using a gradient
                    using (var fillBrush = new LinearGradientBrush(ClientRectangle, fillColor1, fillColor2, fillColorAngle))
                    {
                        e.Graphics.FillPath(fillBrush, path);
                    }

                    // Draw the fish border using a single color
                    using (var borderPen = new Pen(borderColor))
                    {
                        e.Graphics.DrawPath(borderPen, path);
                    }

                    // Draw the text in about the center of the control
                    using (var textBrush = new SolidBrush(textColor))
                    {
                        e.Graphics.DrawString("Click me!", textFont, textBrush, Width / 2 - 10, Height / 2 - 5);
                    }
                }

                // Put graphics back into original state before returning
                e.Graphics.Restore(state);
            }

            base.OnPaint(e);
        }

        // Find the correct state when getting button values
        private PaletteState GetButtonState() =>
            !Enabled
                ? PaletteState.Disabled
                : _mouseOver
                    ? _mouseDown
                        ? PaletteState.Pressed
                        : PaletteState.Tracking
                    : PaletteState.Normal;

        private GraphicsPath CreateFishPath()
        {
            // The bounding box for the fish is slightly smaller than the client area
            Rectangle fishRect = ClientRectangle;
            fishRect.Inflate(-5, -5);

            // Find some lengths
            int w3 = Width / 3;
            int w6 = Width / 6;
            int h2 = Height / 2;
            int h4 = Height / 4;

            var fishPath = new GraphicsPath();

            // Create the tail of the fish
            fishPath.AddLine(fishRect.Left + w6, fishRect.Bottom - h4, fishRect.Left, fishRect.Bottom);
            fishPath.AddLine(fishRect.Left, fishRect.Bottom, fishRect.Left, fishRect.Top);
            fishPath.AddLine(fishRect.Left, fishRect.Top, fishRect.Left + w6, fishRect.Top + h4);

            // Create the curving body of the fish
            fishPath.AddCurve(new Point[]{ new Point(fishRect.Left + w6, fishRect.Top + h4),
                                           new Point(fishRect.Right - w3, fishRect.Top),
                                           new Point(fishRect.Right, fishRect.Top + h2),
                                           new Point(fishRect.Right - w3, fishRect.Bottom),
                                           new Point(fishRect.Left + w6, fishRect.Bottom - h4)}, 0.8f);

            return fishPath;
        }

        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            // Unhook events from old palette
            if (_palette != null)
            {
                _palette.PalettePaint -= OnPalettePaint;
            }

            // Cache the new PaletteBase that is the global palette
            _palette = KryptonManager.CurrentGlobalPalette;

            // Hook into events for the new palette
            if (_palette != null)
            {
                _palette.PalettePaint += OnPalettePaint;
            }

            // Change of palette means we should repaint to show any changes
            Invalidate();
        }

        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e) =>
            // Palette indicates we might need to repaint, so lets do it
            Invalidate();
    }
}
