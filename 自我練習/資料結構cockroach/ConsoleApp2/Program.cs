using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            try
            {
                Console.Write("請問room的列值為多少:(2<row<=40)\n");
                row = int.Parse(Console.ReadLine());
                if (!((2 < row) && (row <= 40)))
                {
                    Console.Write("輸入已超出邊界");
                    Console.ReadKey();
                    return;
                }
                Console.Write("請問room的行值為多少:(2<=col<=20)\n");
                col = int.Parse(Console.ReadLine());
                if (!((2 <= col) && (col <= 20)))
                {
                    Console.Write("輸入已超出邊界");
                    Console.ReadKey();
                    return;
                }
            }
            catch (FormatException)
            {
                Console.Write("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }
            int[] Position = new int[2];
            try
            {
                Console.Write("開始的起點為(請以空格分開列與行)的座標:");
                string input = Console.ReadLine();
                string[] inputnum = input.Split(' ');
                Position[0] = int.Parse(inputnum[0]);
                if (!((0 <= Position[0]) && (Position[0] <= col))){
                    Console.Write("請輸入範圍內的座標");
                    Console.ReadKey();
                    return;
                }
                Position[1] = int.Parse(inputnum[1]);
                if (!((0 <= Position[0]) && (Position[0] <= row))){
                    Console.Write("請輸入範圍內的座標");
                    Console.ReadKey();
                    return;
                }
            }
            catch(FormatException)
            {
                Console.Write("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }
            find_path(Position, row, col);
            Console.ReadKey();
        }
        static void find_path(int [] Position,int row,int col)
        {
            int [] imove = {-1, 0, 1, 1,  1,  0, -1, -1};
            int [] jmove = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[,] room = new int[row+2, col+2];     //房間的大小先給他設超過row 跟 col 
            room[Position[0]++, Position[1]++]++;
            bool full;
            int counter = 0;
            do{   //還有還未走到的位置
                Random myObject = new Random();
                int row_test, col_test,randnum;
                do
                {
                    randnum = myObject.Next(0, 7);
                    row_test = Position[0]+imove[randnum];
                    col_test = Position[1]+jmove[randnum];
                } while ((Position[0] == 0) || (Position[0] == row + 1) || (Position[1] == 0) || (Position[1] == col + 1)); //Posistion為邊界時會做
                Position[0] += imove[randnum];
                Position[1] += jmove[randnum];
                Console.Write("{0} {1}\n",Position[0]-1, Position[1]-1); 
                counter++;
                full = true;
                for(int i = 1; i < row+1; i++)
                {
                    for(int j = 1; j < col+1; j++)
                    {
                        if (room[i,j] == 0)
                        {
                            full = false;
                        }
                    }
                }
            }while (full == false) && (counter <= 50000);
            for (int i = 1; i < row+1; i++)
            {
                for (int j = 1; j < col+1; j++)
                {
                    Console.Write("{0} ", room[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
