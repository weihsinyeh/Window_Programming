using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct table{
            int row;
            int col;
            int val;
        }
        static void Main(string[] args)
        {                   //row,col,val
            int [,] array = {{ 6, 6, 8 },
                             { 0, 0,15},
                             {0,3,22 },
                             {0,5,-15 },
                             {1,1,11},
                             {1,2,3},
                             {2,3,-6 },
                             {4,0,91 },
                             {5,2,28}};
            int[,] array2 = FastTranspose (array);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0;j< array.GetLength(1); j++)
                {
                    Console.Write("{0} ",array2[i,j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        static int[,] FastTranspose(int[,] array)
        {
            int term_number = array[0, 2];
            int col_Max = array[0, 1];
            int[] row_Term = new int[col_Max];
            int[] start_Position = new int[col_Max];
            int array2_col, array2_row;
            for (int x = 0; x < array.Rank; x++)
            {
                if (x == 0) {
                    array2_col = array.GetLength(x);
                }
                if (x == 1)
                {
                    array2_row = array.GetLength(x);
                }
            }
            int [,] array2 = new int[9,3];
            for (int i = 1; i <= term_number; i++)
            {
                row_Term[array[i, 1]]++;
            }
            start_Position[0] = 1;
            for (int i = 1; i < col_Max; i++) //從第一列開始，因為第0列是存 有幾行 幾列 與 有多少非零值
            {
                start_Position[i] = start_Position[i - 1] + row_Term[i - 1];
            }
            Console.Write("row_Term[i]  start_Position[i]\n");
            for (int i = 0; i < col_Max; i++)
            {
                Console.Write("{0,5} {1,5} {2,5}\n",i  ,row_Term[i], start_Position[i]);
            }
            array2[0, 0] = array[0, 1];
            array2[0, 1] = array[0, 0];
            array2[0, 2] = array[0, 2];
            for(int i = 1; i <= term_number; i++)
            {
                array2[start_Position[array[i, 1]], 0] = array[i, 1];
                array2[start_Position[array[i, 1]], 1] = array[i, 0];
                array2[start_Position[array[i, 1]], 2] = array[i, 2];
                start_Position[array[i, 1]]++;
            }
            return array2;
        }
    }
}
