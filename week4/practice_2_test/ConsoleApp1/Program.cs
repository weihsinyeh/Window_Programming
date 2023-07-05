using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int index = 0, counter = 0;    //紀錄現在到陣列第幾個index,counter紀錄多少個格子數了
        static int now_row, now_col,start_row, start_col;
        static int[] next_row = { 0, -1, 1, 0};
        static int[] next_col = { 1, 0, 0, -1};
        public struct position
        {
            public int row, col;
        }
        public struct fork
        {
            public int row, col, pass_num; //叉路經過的次數
        }
        static fork [] fork_position = new fork[1];
        static void Main(string[] args)
        {
            int row, col;
            Console.Write("請輸入迷宮大小(底,高):");
            string input = Console.ReadLine();
            string[] inputnum = input.Split(','); //輸入兩個以空白區隔的整數
            try
            {
                col = int.Parse(inputnum[0]);
                row = int.Parse(inputnum[1]);

                Console.WriteLine("輸入迷宮地圖:");
                string[] input_row = new string[row];
                char[,] array = new char[row + 2, col + 2];
                for (int i = 0; i < row; i++)
                {
                    input_row[i] = Console.ReadLine();
                }

                for (int i = 1; i < row + 1; i++)
                {
                    for (int j = 1; j < col + 1; j++)
                    {
                        array[i, j] = char.Parse(input_row[i - 1].Substring(j - 1, 1));
                    }
                    Console.WriteLine("");
                }
                for (int i = 0; i < row + 2; i++)
                {
                    for (int j = 0; j < col + 2; j++)
                    {
                        if ((i == 0) || (i == row + 1) || (j == 0) || (j == col + 1))
                        {
                            array[i, j] = '1';
                        }
                    }
                }
                for (int i = 0; i < row + 2; i++)
                {
                    for (int j = 0; j < col + 2; j++)
                    {
                        if ((i == 0) || (i == row + 1) || (j == 0) || (j == col + 1))
                        {
                            Console.Write("{0}",array[i, j]);
                        }
                        Console.WriteLine("");
                    }
                }
                position [] start_position = search_start(array);
                position[] array_position = search_path(array, start_position, 0);
                Console.WriteLine("\nOutPut:");
                for (int i = 1; i < row + 1; i++)
                {
                    for (int j = 1; j < col + 1; j++)
                    {
                        if (array[i, j] == '2')
                        {
                            array[i, j] = ' ';
                        }
                        Console.Write("{0}", array[i, j]);
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
        static position [] search_start(char[,] array)
        {
            position [] start_position = new position[1];
            int i=0, j=0;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == '0')
                    {
                        break;
                    }
                }
            }
            start_position[0].row = i;
            start_position[0].col = j;
            return start_position;
        }

        static position[] search_path (char[,] array,position [] array_position,int direction)
        {
            counter = 0;
            bool move = false,find = false;
            while (find == false||move==true) 
            {
                for (int i = direction; i < 4; i++)
                {
                    position test;
                    test.row = array_position[array_position.Length - 1].row + next_row[i];
                    test.col = array_position[array_position.Length - 1].col + next_col[i];
                    //走路為空格的時候，且不走回頭路

                        if ((array[test.row, test.col] == ' '))//深度優先
                        {
                            Array.Resize(ref array_position, array_position.Length + 1);  //重新新增大小
                            index++;                                                      //紀錄現在在陣列第幾個index
                            array_position[index].row = test.row; //新位置為前面那個位置+新方向
                            array_position[index].col = test.col;
                            array[array_position[index].row, array_position[index].col] = '*'; //移動的位址
                            move = true;                                                  //有移動
                            counter++;          //紀錄現在走經多少格子數量了(防止根本沒有路徑到終點))
                            if (array[array_position[index].row, array_position[index].col] == 'X')  //找到終點了
                            {
                                find = true;
                                return array_position;
                            }
                            for(int k = 1; k < array.GetLength(0) - 1; k++)
                            {
                                for (int j = 1; j < array.GetLength(1) - 1; j++)
                                {
                                    Console.Write("{0}", array[k, j]);
                                }
                                Console.WriteLine("");
                            }
                            break;
                        }

                    if (find == false)
                    {
                        move = false;
                    }
                }
                //走到死路了要往回走，且刪除路徑中的最後一個值
                if (move == false)
                {

                        counter--; //紀錄現在走經多少格子數量了
                        array[array_position[index].row, array_position[index].col] = '1';
                        index--;
                        for (int i = 1; i < array.GetLength(0) - 1; i++)
                        {
                            for (int j = 1; j < array.GetLength(1) - 1; j++)
                            {
                                Console.Write("{0}", array[i, j]);
                            }
                            Console.WriteLine("");
                        }

                }
                move = false;
                if (counter == 0) //比較叉路
                {
                    Console.Write("HI");
                    int [] arraysize_compare = new int [4]; //叉路的四個方向
                    if(array_position[index].row == start_row&& array_position[index].col == start_col)        //如果又回到起點 就break;
                    {
                        break;
                    }
                    fork_position[fork_position.Length].row = array_position[index].row; //新增叉路大小
                    fork_position[fork_position.Length].col = array_position[index].col;
                    fork_position[fork_position.Length].pass_num++;
                    if (array[array_position[index].row - 1, array_position[index].col] == ' ')
                    {
                        arraysize_compare[0] = search_path(array, array_position, 0).Length;
                    }
                    if (array[fork_position[fork_position.Length].row, fork_position[fork_position.Length].col+1] == ' ')
                    {
                        arraysize_compare[1] = search_path(array, array_position, 1).Length; ;
                    }
                    if (array[fork_position[fork_position.Length+1].row, fork_position[fork_position.Length].col] == ' ')
                    {
                        arraysize_compare[1] = search_path(array, array_position, 2).Length; 
                    }
                    if (array[fork_position[fork_position.Length].row, fork_position[fork_position.Length].col - 1] == ' ')
                    {
                        arraysize_compare[1] = search_path(array, array_position, 3).Length;
                    }
                    int bestpath = compare_length(arraysize_compare); // 比較4條路的大小找出最佳路徑
                    Array.Resize(ref fork_position, fork_position.Length + arraysize_compare[bestpath]);
                    break;
                }
            }
            return array_position;
        }
        static int compare_length(int [] arraysize_compare)
        {
            int max = 0;
            for(int i =1; i<arraysize_compare.Length;i++)
            {
                if (arraysize_compare[i] > arraysize_compare[max])
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
