using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
   public class TableRow
    {
        private List<TableCell> _cells;
        //Constructor
        public TableRow(TableCell cell)
        {
            _cells = new List<TableCell> { cell };
        }

        public override string ToString()
        {
            return string.Format("<tr>{0}</tr>", _cells);
        }
        public void AddCell(TableCell cell)
        {
            _cells.Add(cell);
        }
    }
}
