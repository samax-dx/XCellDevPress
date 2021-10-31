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

        private void onMainWindow_Load(object sender, EventArgs e)
        {
            var components = MainNav.Nodes.Add("Components");
            var product = components.Nodes.Add("Product");
            product.Nodes.Add("Search");
            product.Nodes.Add("List");
            product.Nodes.Add("Edit");
            MainNav.AfterSelect += (snd, ev) => {
                if (ev.Node.Text == "Product" || ev.Node.Parent.Text == "Product") openCode("Product");
            };
            var category = components.Nodes.Add("Category");
            category.Nodes.Add("Search");
            category.Nodes.Add("List");
            category.Nodes.Add("Edit");
            MainNav.AfterSelect += (snd, ev) => {
                if (ev.Node.Text == "Category" || ev.Node.Parent.Text == "Category") openCode("Category");
            };
            MainNav.ExpandAll();
        }

        private void openCode(string fileName)
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
