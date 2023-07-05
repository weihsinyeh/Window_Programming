using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int[] next_row = { 0, -1, 0, 1 };
        static int[] next_col = { 1, 0, -1, 0 };
        static int start_row, start_col;
        static char[,] map;
        static int map_col, map_row;
        static void start_search()
        {
            for(int i = 1; i < map_row + 2; i++)
            {
                for(int j = 1; j < map_col + 2; j++)
                {
                    if(map[i,j] == '0')
                    {
                        start_col = j;
                        start_row = i;
                        Console.WriteLine("{0},{1}", start_row.ToString(), start_col.ToString());
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            Console.Write("請輸入迷宮大小(底,高):");
            string input = Console.ReadLine();
            string[] inputnum = input.Split(',');
            map_col = int.Parse(inputnum[0]) ;
            map_row = int.Parse(inputnum[1]) ;
            map = new char[map_row + 2,map_col + 2];
            string[] temp = new string[map_row];
            Console.WriteLine("輸入迷宮地圖");
            for(int i = 0; i < map_row ; i++)
            {
                temp[i] = Console.ReadLine();
            }
            for(int i = 0; i < map_row+2; i++)
            {
                for(int j = 0; j < map_col+2; j++)
                {
                    if (i == 0 || i == map_row + 1 || j == 0 || j == map_col + 1)
                    {
                        map[i, j] = '1';
                    }
                    else
                    {
                        map[i, j ] = char.Parse(temp[i-1].Substring(j-1, 1));
                    }
                }

            }
            start_search();
            Console.WriteLine("\nOutput\n");
            string path = "";
            path = bestpath(map,start_row,start_col,path);
            display(path);
            Console.ReadKey();
        }
        static void display(string path)
        {
            if (path.Contains("@"))
            {
                Console.WriteLine("沒有合法路徑");
            }
            else
            {
                for (int i = 0; i < path.Length - 1; i++)
                {
                    int next = int.Parse(path.Substring(i, 1));
                    map[start_row + next_row[next], start_col + next_col[next]] = '*';
                    start_row = start_row + next_row[next];
                    start_col = start_col + next_col[next];
                }
                for(int i = 1; i < map_row + 1; i++)
                {
                    for(int j = 1; j < map_col + 1; j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
        static string bestpath(char [,] map_test,int _start_row,int _start_col,string path)
        {
            int direction_OK = 0,first_way=-1;
            string[] direction_path = { "", "", "", "" };
            for(int i = 0; i < 4; i++)
            {
                if (map_test[_start_row + next_row[i], _start_col + next_col[i]] == 'X')
                {
                    return "X"; //沒有路徑
                }
                else if(map_test[_start_row + next_row[i], _start_col + next_col[i]] == ' ')
                {
                    if (direction_OK == 0)
                    {
                        first_way = i;
                    }
                    direction_OK++;
                    direction_path[i] += i.ToString();
                    map_test[_start_row + next_row[i], _start_col + next_col[i]] = '*';
                    direction_path[i] += bestpath(map_test, _start_row + next_row[i], _start_col + next_col[i], direction_path[i]);
                    map_test[_start_row + next_row[i], _start_col + next_col[i]] = ' ';
                }
                else
                {
                    continue;
                }
            }
            if (direction_OK == 0)
            {
                return "                                                           @";
            }
            else
            {
                int min = first_way;
                for(int i = first_way; i < 4; i++)
                {
                    if (direction_path[i].Length <= direction_path[min].Length && direction_path[i] != "") 
                    {
                        min = i;
                    }
                }
                return direction_path[min];
            }
        }
    }
}
