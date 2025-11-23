#region BSD License
/*
 *
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 * © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 *
 * New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 * Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
 *
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonDataGridViewExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.BorderStyle = BorderStyle.Fixed3D;
            foreach (DataGridViewColumn column in kryptonDataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            // Create richer test data for display
            dtTestData.Rows.Clear();

            var rand = new Random();
            var titles = new[] { "Mr", "Mrs", "Miss", "Ms" };
            var statuses = new[] { "Single", "Married", "Divorced", "Separated" };
            var firstNames = new[] { "Mark", "Mary", "Mandy", "Mercy", "Michael", "Marge", "Alex", "Jordan", "Taylor", "Sam", "Chris", "Pat", "Morgan", "Jamie", "Robin", "Avery", "Casey", "Drew", "Elliot", "Harper", "Riley", "Quinn", "Skyler", "Cameron", "Logan", "Parker", "Reese", "Rowan", "Sage", "Dakota" };
            var lastNames = new[] { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Wright" };

            for (int i = 0; i < 500; i++)
            {
                DateTime date = DateTime.Now.Date.AddDays(rand.Next(-365, 366));
                string title = titles[rand.Next(titles.Length)];
                string first = firstNames[rand.Next(firstNames.Length)];
                string last = lastNames[rand.Next(lastNames.Length)];
                string name = $"{first} {last}";

                // Add some multi-line and long-text variations
                if (i % 50 == 0)
                {
                    name = $"{first}\r\nSingle\r\nMarried";
                }
                else if (i % 33 == 0)
                {
                    name = $"{first} has a really long name normally, and this should wrap around the cell to demonstrate multiline behavior";
                }

                string phone = $"({rand.Next(1, 100):00}) {rand.Next(0, 10000):0000}-{rand.Next(0, 10000):0000}";
                string status = statuses[rand.Next(statuses.Length)];
                int age = rand.Next(18, 90);
                bool flag = rand.Next(2) == 0;

                dtTestData.Rows.Add(date, title, name, phone, status, age, "Press!", flag);
            }

            // Show selected data grid properties in the property grid
            propertyGrid.SelectedObject = new KryptonDataGridViewProxy(kryptonDataGridView1);
        }

        private void rbStyleList_CheckedChanged(object sender, EventArgs e) => kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.List;

        private void rbStyleSheet_CheckedChanged(object sender, EventArgs e) => kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.Sheet;

        private void rbStyleCustom_CheckedChanged(object sender, EventArgs e) => kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.Custom1;

        private void buttonRandomCellColors_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < kryptonDataGridView1.ColumnCount; j++)
                {
                    Color foreColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    Color backColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                    kryptonDataGridView1.Rows[i].Cells[j].Style.BackColor = foreColor;
                    kryptonDataGridView1.Rows[i].Cells[j].Style.ForeColor = backColor;
                }
            }
        }

        private void buttonClearCellColors_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < kryptonDataGridView1.ColumnCount; j++)
                {
                    kryptonDataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Empty;
                    kryptonDataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Empty;
                }
            }
        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            using var dlg = new Form2();
            dlg.ShowDialog(this);
        }

        private void kryptonDataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            // intentionally empty
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || kryptonDataGridView1.Columns[e.ColumnIndex] != colButton)
            {
                return;
            }

            var row = kryptonDataGridView1.Rows[e.RowIndex];

            static string Format(object? value) => value is null or DBNull ? string.Empty : (Convert.ToString(value) ?? string.Empty);

            string dateText = row.Cells[colDateTime.Index].Value is DateTime dt ? dt.ToShortDateString() : Format(row.Cells[colDateTime.Index].Value);
            string title = Format(row.Cells[colComboBox.Index].Value);
            string name = Format(row.Cells[colTextBox.Index].Value);
            string phone = Format(row.Cells[colMaskedTextBox.Index].Value);
            string status = Format(row.Cells[colDomainUpDown.Index].Value);
            string ageText = Format(row.Cells[colNumericUpDown.Index].Value);
            string flagText = row.Cells[colCheckBox.Index].Value is bool b ? (b ? "Yes" : "No") : (string.IsNullOrWhiteSpace(Format(row.Cells[colCheckBox.Index].Value)) ? "No" : Format(row.Cells[colCheckBox.Index].Value));

            string mainInstruction = string.IsNullOrWhiteSpace(name)
                ? "Person Details"
                : $"{title} {name}".Trim();

            string content =
                $"Date: {dateText}\r\n" +
                $"Phone: {phone}\r\n" +
                $"Status: {status}\r\n" +
                $"Age: {ageText}\r\n" +
                $"Subscribed: {flagText}";

            using (var dialog = new KryptonTaskDialog())
            {
                dialog.WindowTitle = "Info Card";
                dialog.MainInstruction = mainInstruction;
                dialog.Content = content;
                dialog.Icon = KryptonMessageBoxIcon.Information;
                dialog.CommonButtons = TaskDialogButtons.OK;
                dialog.ShowDialog(this);
            }
        }
    }

    public class KryptonDataGridViewProxy
    {
        private KryptonDataGridView _grid;

        public KryptonDataGridViewProxy(KryptonDataGridView grid) => _grid = grid;

        [Category("Appearance")]
        [Description("The height, in pixels, of the column headers row.")]
        public int ColumnHeadersHeight
        {
            get => _grid.ColumnHeadersHeight;
            set => _grid.ColumnHeadersHeight = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether the column headers row is displayed.")]
        public bool ColumnHeadersVisible
        {
            get => _grid.ColumnHeadersVisible;
            set => _grid.ColumnHeadersVisible = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether the column that contains row headers is displayed.")]
        public bool RowHeadersVisible
        {
            get => _grid.RowHeadersVisible;
            set => _grid.RowHeadersVisible = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether to show cell errors.")]
        public bool ShowCellErrors
        {
            get => _grid.ShowCellErrors;
            set => _grid.ShowCellErrors = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether or not ToolTips will show when the mouse pointer pauses on a cell.")]
        public bool ShowCellToolTips
        {
            get => _grid.ShowCellToolTips;
            set => _grid.ShowCellToolTips = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether or not the editing glyph is visible in the row header of the cell being edited.")]
        public bool ShowEditingIcon
        {
            get => _grid.ShowEditingIcon;
            set => _grid.ShowEditingIcon = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether row headers will display error glyphs for each row that contains a data entry error.")]
        public bool ShowRowErrors
        {
            get => _grid.ShowRowErrors;
            set => _grid.ShowRowErrors = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the option to add rows is displayed to the user.")]
        public bool AllowUserToAddRows
        {
            get => _grid.AllowUserToAddRows;
            set => _grid.AllowUserToAddRows = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the user is allowed to delete rows from the DataGridView.")]
        public bool AllowUserToDeleteRows
        {
            get => _grid.AllowUserToDeleteRows;
            set => _grid.AllowUserToDeleteRows = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether manual column repositioning is enabled.")]
        public bool AllowUserToOrderColumns
        {
            get => _grid.AllowUserToOrderColumns;
            set => _grid.AllowUserToOrderColumns = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether users can resize columns.")]
        public bool AllowUserToResizeColumns
        {
            get => _grid.AllowUserToResizeColumns;
            set => _grid.AllowUserToResizeColumns = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether users can resize rows.")]
        public bool AllowUserToResizeRows
        {
            get => _grid.AllowUserToResizeRows;
            set => _grid.AllowUserToResizeRows = value;
        }

        [Category("Behavior")]
        [Description("Determines the behavior for adjusting the column headers height.")]
        public DataGridViewColumnHeadersHeightSizeMode ColumnHeadersHeightSizeMode
        {
            get => _grid.ColumnHeadersHeightSizeMode;
            set => _grid.ColumnHeadersHeightSizeMode = value;
        }

        [Category("Behavior")]
        [Description("Identifies the mode that determines the cell editing is started.")]
        public DataGridViewEditMode EditMode
        {
            get => _grid.EditMode;
            set => _grid.EditMode = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the user is allowed to selected more than one cell, row or column of hte DataGridView at a time.")]
        public bool MultiSelect
        {
            get => _grid.MultiSelect;
            set => _grid.MultiSelect = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the user can edit the cells of the DataGridView control.")]
        public bool ReadOnly
        {
            get => _grid.ReadOnly;
            set => _grid.ReadOnly = value;
        }

        [Category("Behavior")]
        [Description("Determine the behavior for adjusting the row headers width.")]
        public DataGridViewRowHeadersWidthSizeMode RowHeadersWidthSizeMode
        {
            get => _grid.RowHeadersWidthSizeMode;
            set => _grid.RowHeadersWidthSizeMode = value;
        }

        [Category("Behavior")]
        [Description("Indicates how the cells of the DataGridView can be selected.")]
        public DataGridViewSelectionMode SelectionMode
        {
            get => _grid.SelectionMode;
            set => _grid.SelectionMode = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the TAB key moves the focus to the next control in the tab order rather than moving focus to the next cell in the control.")]
        public bool StandardTab
        {
            get => _grid.StandardTab;
            set => _grid.StandardTab = value;
        }

        [Category("Layout")]
        [Description("Determines the auto size mode for the visible columns.")]
        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode
        {
            get => _grid.AutoSizeColumnsMode;
            set => _grid.AutoSizeColumnsMode = value;
        }

        [Category("Layout")]
        [Description("Determines the auto size mode for the visible rows.")]
        public DataGridViewAutoSizeRowsMode AutoSizeRowsMode
        {
            get => _grid.AutoSizeRowsMode;
            set => _grid.AutoSizeRowsMode = value;
        }

        [Category("Layout")]
        [Description("The width, in pixels, of the column that contains the row headers.")]
        public int RowHeadersWidth
        {
            get => _grid.RowHeadersWidth;
            set => _grid.RowHeadersWidth = value;
        }

        [Category("Layout")]
        [Description("The type of scrollbars to display.")]
        public ScrollBars ScrollBars
        {
            get => _grid.ScrollBars;
            set => _grid.ScrollBars = value;
        }

        [Category("Visuals")]
        [Description("Determine if the outer borders of the grid cells are drawn.")]
        public bool HideOuterBorders
        {
            get => _grid.HideOuterBorders;
            set => _grid.HideOuterBorders = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common data grid view appearance that other states can override.")]
        public PaletteDataGridViewRedirect StateCommon => _grid.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled data grid view appearance.")]
        public PaletteDataGridViewAll StateDisabled => _grid.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal data grid view appearance.")]
        public PaletteDataGridViewAll StateNormal => _grid.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining tracking data grid view appearance.")]
        public PaletteDataGridViewHeaders StateTracking => _grid.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed data grid view appearance.")]
        public PaletteDataGridViewHeaders StatePressed => _grid.StatePressed;

        [Category("Visuals")]
        [Description("Overrides for defining selected data grid view appearance.")]
        public PaletteDataGridViewCells StateSelected => _grid.StateSelected;

        [Category("Visuals")]
        [Description("Set of grid styles.")]
        public DataGridViewStyles GridStyles => _grid.GridStyles;

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        public PaletteMode PaletteMode
        {
            get => _grid.PaletteMode;
            set => _grid.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _grid.Size;
            set => _grid.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _grid.Location;
            set => _grid.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _grid.Enabled;
            set => _grid.Enabled = value;
        }
    }
}
