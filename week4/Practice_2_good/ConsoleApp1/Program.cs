using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int now_row, now_col,index = 0,counter = 0;//紀錄現在到陣列第幾個index,counter紀錄多少個格子數了
        struct position
        {
            public int row, col;
        }
        static void Main(string[] args)
        {
            int row, col;
            Console.Write("請輸入迷宮大小(底,高):");
            string input = Console.ReadLine();
            string[] inputnum = input.Split(' '); //輸入兩個以空白區隔的整數
            try
            {
                col = int.Parse(inputnum[0]);
                row = int.Parse(inputnum[1]);

                Console.WriteLine("輸入迷宮地圖:");
                string[] input_row = new string[row];
                char[,] array = new char[row+2,col+2];
                for (int i = 0; i < row; i++)
                {
                    input_row[i] = Console.ReadLine();
                }

                for (int i = 1; i < row+1; i++)
                {
                    for (int j = 1; j < col+1; j++)
                    { 
                            array[i, j] = char.Parse(input_row[i-1].Substring(j-1, 1));
                    }
                    Console.WriteLine("");
                }
                for(int i = 0; i < row + 2; i++)
                {
                    for(int j = 0; j < col + 2; j++)
                    {
                        if ((i == 0) || (i == row + 1) || (j == 0) || (j == col + 1))
                        {
                            array[i, j] = '1';
                        }
                    }
                }
                search_start(array);
                array = path(array);
                Console.WriteLine("\nOutPut:");
                for (int i = 1; i < row+1; i++)
                {
                    for (int j = 1; j < col+1; j++)
                    {
                        if (array[i, j] == '2')
                        {
                            array[i, j] = ' ';
                        }
                        Console.Write("{0}",array[i,j]);
                    }
                    Console.WriteLine("");
                }
                if (counter == 0)
                {
                    Console.Write("沒有路徑");
                }
                else
                {
                    Console.Write("{0}", index - 2);
                }
                Console.ReadKey();

            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                return;
            }
        }
        static void search_start(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == '0')
                    {
                        now_row = i;
                        now_col = j;
                    }
                }
            }
        }

        static char[,] path(char[,] array)
        {
            int direction = 4;
            int[] next_row = { 0,-1, 1, 0, 0 };
            int[] next_col = { 1, 0, 0, -1, 0 };
            position[] array_position = new position[1];
            array_position[0].row = now_row;
            array_position[0].col = now_col;
            bool move = false;
            while (array[now_row, now_col] != 'X')
            {
                for (int i = 0; i < 4; i++)
                {
                    if ((array[now_row + next_row[i], now_col + next_col[i]] == ' ')) //深度優先
                    {
                        index++;
                        now_row += next_row[i];
                        now_col += next_col[i];
                        Array.Resize(ref array_position, array_position.Length + 1);
                        array_position[index].row = now_row;
                        array_position[index].col = now_col;
                        array[now_row, now_col] = '*'; //將走到的節點設為*
                        move = true;
                        direction = i;
                        counter++; //紀錄現在走經多少格子數量了
                        break;
                    }
                    if ((array[now_row + next_row[i], now_col + next_col[i]] == 'X'))
                    {
                        index++;
                        now_row += next_row[i];
                        now_col += next_col[i];
                        Array.Resize(ref array_position, array_position.Length + 1);
                        array_position[index].row = now_row;
                        array_position[index].col = now_col;
                        move = true;
                        break;
                    }
                }
                if (move == false)
                {
                    counter--; //紀錄現在走經多少格子數量了
                    array[now_row, now_col] = '2';
                    index--;
                    Array.Resize(ref array_position, array_position.Length + 1);
                    now_row = array_position[index].row;
                    now_col = array_position[index].col;

                }
                for (int i = 1; i < array.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < array.GetLength(1) - 1; j++)
                    {
                        Console.Write("{0}", array[i, j]);
                    }
                    Console.WriteLine("");
                }
                move = false;
                if(counter == 0)
                {
                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            return array;
        }
    }
}
