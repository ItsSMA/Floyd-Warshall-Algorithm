using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 1, 0, 1},
                {0, 1, 1, 0},
                {0, 0, 1, 1},
                {0, 0, 0, 1}
            };

            PathFinder obj = new PathFinder();

            // THis is were the magic happens
            obj.WarshallAlgo(matrix);
        }
    }
}

