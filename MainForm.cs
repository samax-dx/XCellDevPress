using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Reflection;
using System.Diagnostics;
using Flurl.Http;
using XCellDevPress.helpers;

namespace XCellDevPress
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task<IDictionary<string, object>> Evaluate(object evalData)
        {
            var response = await "http://localhost:3005/eval".PostJsonAsync(evalData);
            return await response.GetJsonAsync<IDictionary<string, object>>();
        }

        private void SetCellValue(DevExpress.XtraSpreadsheet.SpreadsheetControl control, int x, int y, object value)
        {
            var worksheet = control.Document.Worksheets[0];
            worksheet[x, y].SetValue(value);
        }

        private object GetEvalData(string startCellRef)
        {
            var cellRange = SheetA.Document.Worksheets[0]
                .Range
                .Parse(string.Join(":", Enumerable.Repeat(startCellRef.Substring(0, 1), 2)));

            var callData = cellRange
                .TakeWhile(cell => !cell.Value.IsEmpty)
                .Select(cell => cell.Value.TextValue)
                .ToArray();

            var methods = callData.Skip(1).ToArray();

            return new { methods = callData.Skip(1).ToArray(), data = callData.ElementAt(0) };
        }

        private void SetEvalData(string startCellRef, IDictionary<string, object> data)
        {
            var startCell = SheetA.Document.Worksheets[0].Cells[startCellRef].ExitRight();
            data.forEach((item, i) => startCell.ExitDown(i).SetValue(item.Value));
        }

        private async void SheetA_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e)
        {
            SetCellValue(SheetB, e.Cell.RowIndex, e.Cell.ColumnIndex, e.Cell.Value.TextValue); // ignore this line
            if (e.Cell.ColumnIndex > 0) return; // ignore this line

            var startCellRef = "A1";

            var result = await Evaluate(GetEvalData(startCellRef));
            SetEvalData(startCellRef, result);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var components = MainNav.Nodes.Add("Components");
            var product = components.Nodes.Add("Product");
            product.Nodes.Add("Search");
            product.Nodes.Add("List");
            product.Nodes.Add("Edit");
            MainNav.AfterSelect += (snd, ev) => {
                if (ev.Node.Text == "Product" || ev.Node.Parent.Text == "Product") OpenCode("Product");
            };
            var category = components.Nodes.Add("Category");
            category.Nodes.Add("Search");
            category.Nodes.Add("List");
            category.Nodes.Add("Edit");
            MainNav.AfterSelect += (snd, ev) => {
                if (ev.Node.Text == "Category" || ev.Node.Parent.Text == "Category") OpenCode("Category");
            };
            MainNav.ExpandAll();
        }

        private void OpenCode(string fileName)
        {
            var executablePath = Path.GetDirectoryName(Application.ExecutablePath);

            var process = new Process();
            process.StartInfo.FileName = "code";
            process.StartInfo.Arguments = String.Format("{0}/{1}.js", executablePath, fileName);
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
        }
    }
}
