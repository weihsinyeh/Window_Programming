//F74109016 葉惟欣 資訊系113 Practice_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct landmine_location //一個紀錄地雷位置的struct
        {
            public int col, row;
        }
        static void Main(string[] args)
        {
            int map_size, landmine_number;
            try
            {
                Console.Write("地圖大小(1~10):");
                map_size = int.Parse(Console.ReadLine());
                if (!((map_size < 11) && (map_size > 0)))
                {
                    Console.Write("超出範圍");
                    Console.ReadKey();
                    return;
                }
                Console.Write("地雷數量(1~10):");
                landmine_number = int.Parse(Console.ReadLine());
                if (!((landmine_number < 11) && (landmine_number > 0)))
                {
                    Console.Write("超出範圍");
                    Console.ReadKey();
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }
            int[,] map = new int[(map_size + 2), (map_size + 2)];  //將地圖範圍設比實際大兩個row與兩個col
            landmine_location[] array = new landmine_location[landmine_number]; //存放地雷位置的陣列
            for (int i = 0; i < landmine_number; i++)  //輸入地雷位置
            {
                Console.Write("第 {0} 個地雷的位置(以空白區隔):", i);
                string input = Console.ReadLine();
                string[] inputnum = input.Split(' '); //輸入兩個以空白區隔的整數
                try
                {
                    //使用者輸入的位置比程式先前假設的地圖少一個row與col ，如此一來當地雷放置在使用者預想的地圖邊邊角角時，周圍位置的數量仍可以加一，而不會超出界線
                    array[i].row = int.Parse(inputnum[0]) + 1;  
                    array[i].col = int.Parse(inputnum[1]) + 1;
                    if (!(((array[i].row - 1) < map_size) && ((array[i].row - 1) > -1))) //但判斷有無超出界線仍是以使用者輸入的為主。
                    {
                        Console.Write("超出範圍");
                        Console.ReadKey();
                        return;
                    }
                    if (!(((array[i].col - 1) < map_size) && ((array[i].col - 1) > -1)))
                    {
                        Console.Write("超出範圍");
                        Console.ReadKey();
                        return;
                    }
                }
                catch (FormatException)
                {
                    Console.Write("請輸入兩個以空白區隔的整數");
                    Console.ReadKey();
                    return;
                }
                map[(array[i].col) - 1, (array[i].row) - 1]++;  //地雷的西北
                map[array[i].col, (array[i].row) - 1]++;        //地雷的北
                map[(array[i].col) + 1, (array[i].row) - 1]++;  //地雷的東北
                map[(array[i].col) - 1, array[i].row]++;        //地雷的西
                map[(array[i].col) + 1, array[i].row]++;        //地雷的東
                map[(array[i].col) - 1, (array[i].row) + 1]++;  //地雷的西南
                map[array[i].col, (array[i].row) + 1]++;        //地雷的南
                map[(array[i].col) + 1, (array[i].row) + 1]++;  //地雷的東南
            }
            Console.Write("---");                           //分隔線
            Console.WriteLine("");                          //換行
            for (int i = 0; i < map_size; i++)
            {
                for (int j = 0; j < map_size; j++)
                {
                    bool isempty = false;
                    for (int k = 0; k < landmine_number; k++)
                    {
                        if ((i == (array[k].col - 1)) && (j == (array[k].row - 1))) //當迴圈到陣列位置就印X
                        {
                            Console.Write("X");
                            isempty = true;
                        }
                    }
                    if (isempty == false)                //如果不是放地雷的位置就印出附近有幾個地雷。
                    {
                        Console.Write(map[i + 1, j + 1]); //最後印出的位置要加一個row與col才會是程式先前預設的地圖
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
