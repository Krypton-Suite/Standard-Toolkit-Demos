#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonPrintPreviewDialogExample;

public partial class Form1 : KryptonForm 
{
    public Form1()
    {
        InitializeComponent();
        SetupExamples();
    }

    private void SetupExamples()
    {
        // Setup button click handlers
        btnSimpleText.Click += BtnSimpleText_Click;
        btnMultiPage.Click += BtnMultiPage_Click;
        btnThemedDocument.Click += BtnThemedDocument_Click;
        btnGraphicsDocument.Click += BtnGraphicsDocument_Click;
        btnWithCustomIcon.Click += BtnWithCustomIcon_Click;
        btnMaximizedWindow.Click += BtnMaximizedWindow_Click;
        btnAntiAliasOff.Click += BtnAntiAliasOff_Click;
        btnAntiAliasOn.Click += BtnAntiAliasOn_Click;
        btnComplexDocument.Click += BtnComplexDocument_Click;
        btnTableDocument.Click += BtnTableDocument_Click;
    }

    #region Simple Text Document

    private void BtnSimpleText_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument()  {
            DocumentName = "Simple Text Document"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            var titleFont = new Font("Arial", 18, FontStyle.Bold);
            var bodyFont = new Font("Arial", 12);
            var brush = Brushes.Black;

            // Draw title
            g.DrawString("Simple Text Document", titleFont, brush,
                marginBounds.Left, marginBounds.Top);

            // Draw body text
            float y = marginBounds.Top + 50;
            string[] lines =
            {
                "This is a simple text document demonstration.",
                "It shows basic text printing capabilities.",
                "",
                "The document uses standard fonts and colors.",
                "You can preview this document using the KryptonPrintPreviewDialog."
            };

            foreach (var line in lines)
            {
                g.DrawString(line, bodyFont, brush, marginBounds.Left, y);
                y += bodyFont.GetHeight(g) + 5;
            }

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Simple Text Document Preview"
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Multi-Page Document

    private int _currentPage = 0;
    private const int TotalPages = 5;

    private void BtnMultiPage_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Multi-Page Document"
        };

        _currentPage = 0;

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            var titleFont = new Font("Arial", 16, FontStyle.Bold);
            var bodyFont = new Font("Arial", 11);
            var brush = Brushes.Black;

            // Draw page number
            string pageText = $"Page {_currentPage + 1} of {TotalPages}";
            g.DrawString(pageText, bodyFont, brush,
                marginBounds.Right - 100, marginBounds.Top);

            // Draw title
            g.DrawString($"Document Page {_currentPage + 1}", titleFont, brush,
                marginBounds.Left, marginBounds.Top + 30);

            // Draw content
            float y = marginBounds.Top + 80;
            for (int i = 0; i < 20; i++)
            {
                g.DrawString($"This is line {i + 1} on page {_currentPage + 1}.",
                    bodyFont, brush, marginBounds.Left, y);
                y += bodyFont.GetHeight(g) + 3;
            }

            _currentPage++;
            args.HasMorePages = _currentPage < TotalPages;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Multi-Page Document Preview"
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Themed Document

    private void BtnThemedDocument_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Themed Print Document",
            PaletteMode = PaletteMode.Global,
            UsePaletteColors = true,
            TextStyle = PaletteContentStyle.LabelNormalPanel,
            BackgroundStyle = PaletteBackStyle.PanelClient
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            // Draw themed background
            var backColor = printDoc.GetBackgroundColor();
            using (var brush = new SolidBrush(backColor))
            {
                g.FillRectangle(brush, marginBounds);
            }

            // Draw themed header rectangle
            var headerRect = new Rectangle(marginBounds.Left, marginBounds.Top,
                marginBounds.Width, 80);
            printDoc.DrawThemedRectangle(g, headerRect);

            // Draw header text
            var headerText = "Themed Document Header";
            printDoc.DrawThemedText(g, headerText, null, headerRect,
                new StringFormat {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });

            // Draw content with themed colors
            var textColor = printDoc.GetTextColor();
            var font = printDoc.GetFont();
            using (var brush = new SolidBrush(textColor))
            {
                float y = marginBounds.Top + 100;
                string[] content =
                {
                    "This document uses Krypton theming.",
                    "Colors and fonts are taken from the current palette.",
                    "",
                    "The document automatically adapts to theme changes.",
                    "Try changing the global palette and preview again!"
                };

                foreach (var line in content)
                {
                    g.DrawString(line, font, brush, marginBounds.Left + 20, y);
                    y += font.GetHeight(g) + 5;
                }
            }

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Themed Document Preview"
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Graphics Document

    private void BtnGraphicsDocument_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Graphics Document"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            // Draw title
            var titleFont = new Font("Arial", 16, FontStyle.Bold);
            g.DrawString("Graphics Demonstration", titleFont, Brushes.Black,
                marginBounds.Left, marginBounds.Top);

            // Draw various shapes
            int y = marginBounds.Top + 50;

            // Rectangle
            g.DrawRectangle(Pens.Blue, marginBounds.Left, y, 150, 80);
            g.DrawString("Rectangle", new Font("Arial", 10), Brushes.Black,
                marginBounds.Left + 5, y + 5);

            // Filled ellipse
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                g.FillEllipse(brush, marginBounds.Left + 200, y, 150, 80);
            }
            g.DrawEllipse(Pens.DarkBlue, marginBounds.Left + 200, y, 150, 80);
            g.DrawString("Ellipse", new Font("Arial", 10), Brushes.Black,
                marginBounds.Left + 205, y + 5);

            y += 120;

            // Lines
            for (int i = 0; i < 5; i++)
            {
                var pen = new Pen(Color.FromArgb(50 + i * 40, 0, 0, 255), 2);
                g.DrawLine(pen, marginBounds.Left, y + i * 15,
                    marginBounds.Left + 200, y + i * 15);
                pen.Dispose();
            }
            g.DrawString("Lines", new Font("Arial", 10), Brushes.Black,
                marginBounds.Left + 5, y - 20);

            // Polygon
            Point[] points =
            {
                new Point(marginBounds.Left + 250, y),
                new Point(marginBounds.Left + 300, y + 40),
                new Point(marginBounds.Left + 250, y + 80),
                new Point(marginBounds.Left + 200, y + 40)
            };
            using (var brush = new SolidBrush(Color.LightGreen))
            {
                g.FillPolygon(brush, points);
            }
            g.DrawPolygon(Pens.DarkGreen, points);
            g.DrawString("Polygon", new Font("Arial", 10), Brushes.Black,
                marginBounds.Left + 205, y + 5);

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Graphics Document Preview"
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Custom Icon

    private void BtnWithCustomIcon_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Document with Custom Icon"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            var font = new Font("Arial", 14);
            g.DrawString("This preview dialog uses a custom icon.", font,
                Brushes.Black, marginBounds.Left, marginBounds.Top);
            g.DrawString("Check the window title bar to see the icon.", font,
                Brushes.Black, marginBounds.Left, marginBounds.Top + 40);

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Custom Icon Preview",
            Icon = SystemIcons.Information
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Window State

    private void BtnMaximizedWindow_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Maximized Window Test"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            var font = new Font("Arial", 14);
            g.DrawString("This preview dialog opens maximized.", font,
                Brushes.Black, marginBounds.Left, marginBounds.Top);
            g.DrawString("The WindowState property is set to Maximized.", font,
                Brushes.Black, marginBounds.Left, marginBounds.Top + 40);

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Maximized Preview",
            WindowState = FormWindowState.Maximized
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Anti-Aliasing

    private void BtnAntiAliasOff_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Anti-Alias Off"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            var font = new Font("Arial", 14);
            g.DrawString("Anti-aliasing is OFF", font, Brushes.Black,
                marginBounds.Left, marginBounds.Top);
            g.DrawString("Text and graphics may appear jagged.", font,
                Brushes.Black, marginBounds.Left, marginBounds.Top + 40);

            // Draw diagonal line to show aliasing
            g.DrawLine(Pens.Black, marginBounds.Left, marginBounds.Top + 80,
                marginBounds.Left + 200, marginBounds.Top + 150);

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Anti-Alias OFF Preview",
            UseAntiAlias = false
        };

        preview.ShowDialog(this);
    }

    private void BtnAntiAliasOn_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Anti-Alias On"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var font = new Font("Arial", 14);
            g.DrawString("Anti-aliasing is ON", font, Brushes.Black,
                marginBounds.Left, marginBounds.Top);
            g.DrawString("Text and graphics appear smooth.", font,
                Brushes.Black, marginBounds.Left, marginBounds.Top + 40);

            // Draw diagonal line to show smooth rendering
            g.DrawLine(Pens.Black, marginBounds.Left, marginBounds.Top + 80,
                marginBounds.Left + 200, marginBounds.Top + 150);

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Anti-Alias ON Preview",
            UseAntiAlias = true
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Complex Document

    private void BtnComplexDocument_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Complex Document"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            // Header with gradient
            var headerRect = new Rectangle(marginBounds.Left, marginBounds.Top,
                marginBounds.Width, 100);
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                headerRect, Color.LightBlue, Color.DarkBlue,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, headerRect);
            }
            g.DrawRectangle(Pens.DarkBlue, headerRect);

            var headerFont = new Font("Arial", 20, FontStyle.Bold);
            g.DrawString("Complex Document Example", headerFont, Brushes.White,
                headerRect, new StringFormat {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });

            // Content area
            int y = marginBounds.Top + 120;
            var bodyFont = new Font("Arial", 11);

            // Section 1
            var section1Font = new Font("Arial", 14, FontStyle.Bold);
            g.DrawString("Section 1: Introduction", section1Font, Brushes.DarkBlue,
                marginBounds.Left, y);
            y += 30;

            string[] section1 =
            {
                "This is a complex document that demonstrates various",
                "printing features including headers, sections, and formatting.",
                "It shows how to create professional-looking documents."
            };

            foreach (var line in section1)
            {
                g.DrawString(line, bodyFont, Brushes.Black, marginBounds.Left, y);
                y += (int)bodyFont.GetHeight(g) + 5;
            }

            y += 20;

            // Section 2 with border
            var section2Rect = new Rectangle(marginBounds.Left, y, marginBounds.Width, 100);
            g.DrawRectangle(Pens.Gray, section2Rect);
            g.DrawString("Section 2: Details", section1Font, Brushes.DarkBlue,
                marginBounds.Left + 5, y + 5);

            y += 30;
            string[] section2 =
            {
                "This section is contained within a bordered rectangle.",
                "It demonstrates how to create visually distinct sections.",
                "You can use this technique for reports and documents."
            };

            foreach (var line in section2)
            {
                g.DrawString(line, bodyFont, Brushes.Black, marginBounds.Left + 10, y);
                y += (int)bodyFont.GetHeight(g) + 5;
            }

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Complex Document Preview"
        };

        preview.ShowDialog(this);
    }

    #endregion

    #region Table Document

    private void BtnTableDocument_Click(object? sender, EventArgs e)
    {
        var printDoc = new KryptonPrintDocument {
            DocumentName = "Table Document"
        };

        printDoc.PrintPage += (s, args) => {
            var g = args.Graphics!;
            var marginBounds = args.MarginBounds;

            var titleFont = new Font("Arial", 16, FontStyle.Bold);
            g.DrawString("Sample Data Table", titleFont, Brushes.Black,
                marginBounds.Left, marginBounds.Top);

            // Table data
            string[][] tableData =
            {
                new[] { "Product", "Quantity", "Price", "Total" },
                new[] { "Widget A", "10", "$5.00", "$50.00" },
                new[] { "Widget B", "5", "$10.00", "$50.00" },
                new[] { "Widget C", "8", "$7.50", "$60.00" },
                new[] { "Total", "", "", "$160.00" }
            };

            int startY = marginBounds.Top + 50;
            int rowHeight = 30;
            int[] columnWidths = { 150, 100, 100, 100 };
            int totalWidth = columnWidths[0] + columnWidths[1] + columnWidths[2] + columnWidths[3];
            int x = marginBounds.Left;

            // Draw table
            for (int row = 0; row < tableData.Length; row++)
            {
                bool isHeader = row == 0;
                bool isTotal = row == tableData.Length - 1;
                var font = isHeader || isTotal
                    ? new Font("Arial", 11, FontStyle.Bold)
                    : new Font("Arial", 10);

                // Draw row background
                if (isHeader)
                {
                    using (var brush = new SolidBrush(Color.LightGray))
                    {
                        g.FillRectangle(brush, x, startY + row * rowHeight,
                            totalWidth, rowHeight);
                    }
                }
                else if (isTotal)
                {
                    using (var brush = new SolidBrush(Color.LightYellow))
                    {
                        g.FillRectangle(brush, x, startY + row * rowHeight,
                            totalWidth, rowHeight);
                    }
                }

                // Draw cells
                int cellX = x;
                for (int col = 0; col < tableData[row].Length; col++)
                {
                    var cellRect = new Rectangle(cellX, startY + row * rowHeight,
                        columnWidths[col], rowHeight);
                    g.DrawRectangle(Pens.Black, cellRect);

                    var format = new StringFormat {
                        Alignment = col == 0 ? StringAlignment.Near : StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    };

                    g.DrawString(tableData[row][col], font, Brushes.Black,
                        cellRect, format);
                    cellX += columnWidths[col];
                }
            }

            args.HasMorePages = false;
        };

        var preview = new KryptonPrintPreviewDialog {
            Document = printDoc,
            Text = "Table Document Preview"
        };

        preview.ShowDialog(this);
    }

    #endregion
}
