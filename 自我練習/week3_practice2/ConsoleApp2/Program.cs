using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        struct landmine_location
        {
            public int row, col;
        }
        static void Main(string[] args)
        {
            int lamp_num, map_size;
            try
            {
                Console.Write("地圖大小(1-10):");
                map_size = int.Parse(Console.ReadLine());
                if (map_size < 1 || map_size > 10)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    return;
                }
                Console.Write("地雷數量(1-10):");
                lamp_num = int.Parse(Console.ReadLine());
                if (lamp_num < 1 || lamp_num > 10)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    return;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }
            int[,] map = new int[map_size + 2, map_size + 2];
            for(int i = 0; i < map_size + 2; i++)
            {
                for(int j = 0; j < map_size + 2; j++)
                {
                    map[i, j] = 0;
                }
            }
            landmine_location[] array_location = new landmine_location[lamp_num];
            for(int i = 0; i < lamp_num; i++)
            {
                Console.Write("第 {0} 個地雷的位置(以空白區隔):", i);
                string input = Console.ReadLine();
                string[] inputnum = input.Split(' ');
                try{
                    array_location[i].col = int.Parse(inputnum[0])+1;
                    array_location[i].row = int.Parse(inputnum[1])+1;
                    if (int.Parse(inputnum[0]) > map_size||int.Parse(inputnum[1]) > map_size|| int.Parse(inputnum[0]) < 0 || int.Parse(inputnum[1]) <0)
                    {
                        Console.Write("地雷位置超出範圍");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        map[array_location[i].row -1 , array_location[i].col-1]++;
                        map[array_location[i].row - 1, array_location[i].col]++;
                        map[array_location[i].row - 1, array_location[i].col+1]++;
                        map[array_location[i].row, array_location[i].col-1]++;
                        map[array_location[i].row, array_location[i].col+1]++;
                        map[array_location[i].row + 1, array_location[i].col -1 ]++;
                        map[array_location[i].row + 1, array_location[i].col]++;
                        map[array_location[i].row + 1, array_location[i].col +1 ]++;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("請輸入範圍內的整數");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("---");
            for (int i = 1; i < map_size + 1; i++)
            {
                for (int j = 1; j < map_size + 1; j++)
                {
                    bool exist = false;
                    for (int k = 0; k < lamp_num; k++)
                    {
                        if (array_location[k].row == i && array_location[k].col == j)
                        {
                            Console.Write("X");
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                    {
                        Console.Write("{0}", map[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return;
        }
    }
}
