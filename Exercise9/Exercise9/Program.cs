using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            var myLogger = new Logger();

            var store = new Employee("ali","alr","123344","dddd");
           
            Console.WriteLine(myLogger.GetAllEmployee());

         

        }
    }
}
