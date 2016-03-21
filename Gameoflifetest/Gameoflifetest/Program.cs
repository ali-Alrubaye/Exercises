using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameoflifetest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Grid myGrid = new Grid(7, 9);

            while (running)
            {
                myGrid.output();
                myGrid.GotoNextGeneration();
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    running = false;
            }
            
            Console.ReadKey();
        }
    }
}
