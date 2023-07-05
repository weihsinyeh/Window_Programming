using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74109058_W4_practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, height, start_x = -1, start_y = -1;
            string input2;
            string[] input1;
            char[,] map, output;
            List<int> result = null;
            List<List<int>> start_walker = new List<List<int>>();
            List<List<int>> end_walker = new List<List<int>>();

            Console.Write("請輸入迷宮大小(底, 高): ");
            input1 = Console.ReadLine().Split(',');
            length = Int32.Parse(input1[0].Trim());
            height = Int32.Parse(input1[1].Trim());
            map = new char[height, length];
            output = new char[height, length];
            start_walker.Insert(0, new List<int>());
            end_walker.Insert(0, new List<int>());

            Console.WriteLine("輸入迷宮地圖:");
            for (int i = 0; i < height; i++)
            {
                input2 = Console.ReadLine();
                for (int j = 0; j < length; j++)
                {
                    map[i, j] = input2[j];
                    output[i, j] = input2[j];
                    if(input2[j] == '0')
                    {
                        start_x = i;
                        start_y = j;
                        start_walker[0].Insert(0, i);
                        start_walker[0].Insert(1, j);
                        start_walker[0].Insert(2, 0);
                    }
                    if(input2[j] == 'X')
                    {
                        end_walker[0].Insert(0, i);
                        end_walker[0].Insert(1, j);
                        end_walker[0].Insert(2, 0);
                    }
                }
            }
            Console.WriteLine();

            while (true)
            {
                for(int i = 0; i < start_walker.Count; i++)
                {
                    for(int j = 0; j < end_walker.Count; j++)
                    {
                        if (start_walker[i][0] == end_walker[j][0])
                        {
                            if (start_walker[i][1] - end_walker[j][1] == 1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 1);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                            else if (start_walker[i][1] - end_walker[j][1] == -1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 3);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                        }
                        if (start_walker[i][1] == end_walker[j][1])
                        {
                            if (start_walker[i][0] - end_walker[j][0] == 1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 0);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                            else if (start_walker[i][0] - end_walker[j][0] == -1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 2);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                        }
                    }
                }

                if (start_walker.Count == 0 || end_walker.Count == 0) { break; }

                int start_len = start_walker.Count;
                for (int i = 0; i < start_len; i++)
                {
                    int x = start_walker[i][0];
                    int y = start_walker[i][1];
                    int road = 0;

                    if (x > 0)
                    {
                        if (map[x - 1, y] == ' ')
                        {
                            road++;
                            map[x - 1, y] = '-';
                            start_walker[i][2]++;
                            start_walker[i][0] = x - 1;
                            start_walker[i].Insert(start_walker[i].Count, 0);
                        }
                    }

                    if (x < height - 1)
                    {
                        if (map[x + 1, y] == ' ')
                        {
                            road++;
                            map[x + 1, y] = '-';
                            if (road == 1)
                            {
                                start_walker[i][2]++;
                                start_walker[i][0] = x + 1;
                                start_walker[i].Insert(start_walker[i].Count, 2);
                            }
                            else
                            {
                                int num = start_walker.Count;
                                start_walker.Insert(num, new List<int>(start_walker[i]));
                                start_walker[num][0] = x + 1;
                                start_walker[num][1] = y;
                                start_walker[num][start_walker[num].Count - 1] = 2;
                            }
                        }
                    }

                    if (y > 0)
                    {
                        if (map[x, y - 1] == ' ')
                        {
                            road++;
                            map[x, y - 1] = '-';
                            if (road == 1)
                            {
                                start_walker[i][2]++;
                                start_walker[i][1] = y - 1;
                                start_walker[i].Insert(start_walker[i].Count, 1);
                            }
                            else
                            {
                                int num = start_walker.Count;
                                start_walker.Insert(num, new List<int>(start_walker[i]));
                                start_walker[num][0] = x;
                                start_walker[num][1] = y - 1;
                                start_walker[num][start_walker[num].Count - 1] = 1;
                            }
                        }
                    }

                    if (y < length - 1)
                    {
                        if (map[x, y + 1] == ' ')
                        {
                            road++;
                            map[x, y + 1] = '-';
                            if (road == 1)
                            {
                                start_walker[i][2]++;
                                start_walker[i][1] = y + 1;
                                start_walker[i].Insert(start_walker[i].Count, 3);
                            }
                            else
                            {
                                int num = start_walker.Count;
                                start_walker.Insert(num, new List<int>(start_walker[i]));
                                start_walker[num][0] = x;
                                start_walker[num][1] = y + 1;
                                start_walker[num][start_walker[num].Count - 1] = 3;
                            }
                        }
                    }
                    
                    if(road == 0) { start_walker[i] = null; }
                }

                start_walker.RemoveAll(it => it == null);

                for (int i = 0; i < start_walker.Count; i++)
                {
                    for (int j = 0; j < end_walker.Count; j++)
                    {
                        if (start_walker[i][0] == end_walker[j][0])
                        {
                            if (start_walker[i][1] - end_walker[j][1] == 1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 1);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                            else if (start_walker[i][1] - end_walker[j][1] == -1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 3);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                        }
                        if (start_walker[i][1] == end_walker[j][1])
                        {
                            if (start_walker[i][0] - end_walker[j][0] == 1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 0);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                            else if (start_walker[i][0] - end_walker[j][0] == -1)
                            {
                                result = new List<int>(start_walker[i]);
                                result.Insert(result.Count, 2);
                                end_walker[j].Reverse();
                                result.AddRange(end_walker[j]);
                                start_walker.Clear();
                                end_walker.Clear();
                                break;
                            }
                        }
                    }
                }

                if (start_walker.Count == 0 || end_walker.Count == 0) { break; }

                int end_len = end_walker.Count;
                for (int i = 0; i < end_len; i++)
                {
                    int x = end_walker[i][0];
                    int y = end_walker[i][1];
                    int road = 0;

                    if (x > 0)
                    {
                        if (map[x - 1, y] == ' ')
                        {
                            road++;
                            map[x - 1, y] = '-';
                            end_walker[i][2]++;
                            end_walker[i][0] = x - 1;
                            end_walker[i].Insert(end_walker[i].Count, 2);
                        }
                    }

                    if (x < height - 1)
                    {
                        if (map[x + 1, y] == ' ')
                        {
                            road++;
                            map[x + 1, y] = '-';
                            if (road == 1)
                            {
                                end_walker[i][2]++;
                                end_walker[i][0] = x + 1;
                                end_walker[i].Insert(end_walker[i].Count, 0);
                            }
                            else
                            {
                                int num = end_walker.Count;
                                end_walker.Insert(num, new List<int>(end_walker[i]));
                                end_walker[num][0] = x + 1;
                                end_walker[num][1] = y;
                                end_walker[num][end_walker[num].Count - 1] = 0;
                            }
                        }
                    }

                    if (y > 0)
                    {
                        if (map[x, y - 1] == ' ')
                        {
                            road++;
                            map[x, y - 1] = '-';
                            if (road == 1)
                            {
                                end_walker[i][2]++;
                                end_walker[i][1] = y - 1;
                                end_walker[i].Insert(end_walker[i].Count, 3);
                            }
                            else
                            {
                                int num = end_walker.Count;
                                end_walker.Insert(num, new List<int>(end_walker[i]));
                                end_walker[num][0] = x;
                                end_walker[num][1] = y - 1;
                                end_walker[num][end_walker[num].Count - 1] = 3;
                            }
                        }
                    }

                    if (y < length - 1)
                    {
                        if (map[x, y + 1] == ' ')
                        {
                            road++;
                            map[x, y + 1] = '-';
                            if (road == 1)
                            {
                                end_walker[i][2]++;
                                end_walker[i][1] = y + 1;
                                end_walker[i].Insert(end_walker[i].Count, 1);
                            }
                            else
                            {
                                int num = end_walker.Count;
                                end_walker.Insert(num, new List<int>(end_walker[i]));
                                end_walker[num][0] = x;
                                end_walker[num][1] = y + 1;
                                end_walker[num][end_walker[num].Count - 1] = 1;
                            }
                        }
                    }

                    if (road == 0) { end_walker[i] = null; }
                }

                end_walker.RemoveAll(it => it == null);
            }

            if (result == null) { Console.WriteLine("沒有路徑"); }
            else
            {
                int x = start_x;
                int y = start_y;

                for(int i = 3; i < result.Count - 4; i++)
                {
                    switch (result[i])
                    {
                        case 0:
                            x--;
                            output[x, y] = '*';
                            break;
                        case 1:
                            y--;
                            output[x, y] = '*';
                            break;
                        case 2:
                            x++;
                            output[x, y] = '*';
                            break;
                        case 3:
                            y++;
                            output[x, y] = '*';
                            break;
                    }
                }

                Console.WriteLine("Output:");
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(output[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(result[2] + result[result.Count - 3]);
            }

            Console.ReadKey();
        }

    }
}
