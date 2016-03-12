using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log(Console.ReadLine());
            myLogger.Log("Second post");

            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
