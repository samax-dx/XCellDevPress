using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace XCellDevPress
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onSheetA_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e)
        {
            var docB = SheetB.Document.Worksheets[0];
            var cellB = docB[e.Cell.RowIndex, e.Cell.ColumnIndex];
            cellB.SetValue(e.Value.ToObject());
        }

        private void onMainWindow_Shown(object sender, EventArgs e)
        {
            MainConsole.Text = JsonSerializer.Serialize(new { id = "a13sde", name = "shabbir" });
        }
    }
}
