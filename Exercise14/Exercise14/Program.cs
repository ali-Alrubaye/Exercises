using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
         // Create the first row, with three cells 
         var row = new TableRow(new TableCell("First cell"));
         row.AddCell(new TableCell("Another cell"));
         row.AddCell(new TableCell("A third cell"));

            
            var table = new Table(row);
            Console.WriteLine(table);
        }
    }
}
