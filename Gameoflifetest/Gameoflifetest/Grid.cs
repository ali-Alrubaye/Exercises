using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameoflifetest
{
    class Grid
    {
        private bool[,] _cells;
        private bool[,] _snapshot;
       private int _width, _height;

        public Grid(int width, int height)
        {
            _width = width;
            _height = height;
            _cells = new bool[width, height];
            _snapshot= new bool[width, height];

            Random myrandom = new Random();

            //init cell in a random way
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var nextValue = myrandom.Next(10);
                    if (nextValue < 5)
                        _cells[x, y] = true;
                    else
                        _cells[x, y] = false;
                    
                }
            }
            
        }
        public void output()
        {
            Console.Clear();

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    if (_cells[x, y] == true)
                        Console.BackgroundColor = ConsoleColor.Green;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");

                }
            }
        }
        public void GotoNextGeneration()
        {
            
            // copy values from _cell to _snapshot
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                   _snapshot[x, y] = _cells[x, y];
                }
            }
            for (int x = 0; x < _width; x++)
            {
                
                for (int y = 0; y < _height; y++)
                {
                    // copy values from _cell to _snapshot


                    var myNeighbours = CountNeighbour(x, y);
                    //set
                    if (myNeighbours < 2)
                        _cells[x, y] = false;
                    else if ((myNeighbours == 2 || myNeighbours == 3) && _cells[x, y] == true)
                        _cells[x, y] = true;
                    else if (myNeighbours > 3)
                        _cells[x, y] = false;
                    else if (myNeighbours == 3 && _cells[x, y] == false)
                        _cells[x, y] = true;
                }
            }
        }
        public int CountNeighbour (int x, int y)
        {
            var result = 0;
           if ((x>0 && y >0) && _snapshot[x - 1, y - 1] == true) result++;

            if ((y>0) && _snapshot[x , y - 1] == true) result++;
            if ((x < _width-1 && y> 0) && _snapshot[x + 1, y - 1] == true) result++;

            if ((x>0 ) && _snapshot[x - 1, y ] == true) result++;
            if ((x < _width-1) && _snapshot[x + 1, y ] == true) result++;

            if ((x>0&& y< _height-1) && _snapshot[x - 1, y + 1] == true) result++;
            if ((y<_height-1)&& _snapshot[x, y +1] == true) result++;
            if ((x< _width-1&& y< _height-1)&& _snapshot[x + 1, y + 1] == true) result++;

            return result;
        }

    }
}
