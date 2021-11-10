using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;

namespace XCellDevPress.helpers
{
    public static class XSpreadsheedUtil
    {
        private static Cell ExitToCell(Cell cell, int x, int y)
        {
            var row = cell.RowIndex;
            var col = cell.ColumnIndex;
            return cell.Worksheet.Cells[row + x, col + y];
        }
        public static Cell ExitUp(this Cell c, int offset = 1)
        {
            return ExitToCell(c, -offset, 0);
        }
        public static Cell ExitDown(this Cell c, int offset = 1)
        {
            return ExitToCell(c, +offset, 0);
        }
        public static Cell ExitLeft(this Cell c, int offset = 1)
        {
            return ExitToCell(c, 0, -offset);
        }
        public static Cell ExitRight(this Cell c, int offset = 1)
        {
            return ExitToCell(c, 0, +offset);
        }
    }
}
