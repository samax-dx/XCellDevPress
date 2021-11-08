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
using Flurl;
using Flurl.Http;
using DevExpress.XtraSpreadsheet;

namespace XCellDevPress
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task<object> Evaluate(string[] methods, object args)
        {
            var response = await "http://localhost:3005/eval".PostJsonAsync(new { methods, obj = args });
            return await response.GetJsonAsync<object>();
        }

        private void SetCellValue(SpreadsheetControl control, int x, int y, object value)
        {
            var worksheet = control.Document.Worksheets[0];
            worksheet[x, y].SetValue(value);
        }

        private async void SheetA_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e)
        {
            SetCellValue(SheetB, e.Cell.RowIndex, e.Cell.ColumnIndex, e.Value.ToObject());

            var result = await Evaluate(
                new [] { "trim", "toUpper" },
                new { nameContains = e.Value.ToString() }
            );
            SetCellValue(SheetA, e.Cell.RowIndex, e.Cell.ColumnIndex + 1, result.ToString());
            SetCellValue(SheetB, e.Cell.RowIndex, e.Cell.ColumnIndex + 1, result.ToString());
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
