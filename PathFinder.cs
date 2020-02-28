using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class PathFinder
    {
        readonly static int B = 4;

        public void WarshallAlgo(int[,] vs) {
            int[,] matrix = new int[B, B];
            for (int i = 0; i < B; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    matrix[i, j] = vs[i, j];
                }
            }
            for (int i = 0; i < B; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    for (int k = 0; k < B; k++)
                    {
                        matrix[j, k] = (matrix[j, k] != 0) || ((matrix[i, k] != 0) && (matrix[j, i] != 0)) ? 1 : 0;
                    }
                }
            }

            matrixPrinter(matrix);
        }
        public void matrixPrinter(int[,] vs) {
            Console.WriteLine("this matrix below shows the minimum distance");
            for (int i = 0; i < B; ++i)
            {
                for (int j = 0; j < B; ++j)
                {
                    if (vs[i, j] == 99999)
                    {
                        Console.Write("∞\t");
                    }
                    else
                    {
                        Console.Write(vs[i, j] + "\t");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
