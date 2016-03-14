using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public class Table
    {
        private List<TableRow> _rows;
        //Constructor 
        public Table(TableRow row)
        {
            _rows = new List<TableRow> { row };
        }
        //Constructor 
        //table without having to add a row directly
        public Table()
        {
            _rows = new List<TableRow>();
        }

        public void AddRow(TableRow row)
        {
            _rows.Add(row);
        }
        public override string ToString()
        { 
            return string.Format("<table border='1'>{0}</table>", GetRowData()); 
        }

        private string GetRowData()
       { 
           // Initialize an empty string (string.Empty is basically the same as "") 
           string allRows = string.Empty; 


           foreach (var tableRow in _rows) 
           { 
               allRows += tableRow.ToString(); 
           } 


           return allRows; 
       } 

}
}
