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
            int dayfrom, monthfrom;
            try
            {
                Console.Write("1月1日星期幾(1~7):");
                dayfrom = int.Parse(Console.ReadLine());
                if (dayfrom > 7 || dayfrom < 1)
                {
                    Console.WriteLine("超出範圍");
                    return;
                }
                Console.Write("從幾月開始(1-12):");
                monthfrom = int.Parse(Console.ReadLine());
                if (monthfrom > 12 || monthfrom < 1)
                {
                    Console.WriteLine("超出範圍");
                    return;
                }
            }
            catch{
                Console.WriteLine("請輸入範圍內的整數");
                return;
            }
            for(int i = 1; i < 13; i++)
            {
                int day_of_month=0;
                switch (i)
                {
                    case 1:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("January");
                        }
                        break;
                    case 2:
                        day_of_month = 28;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("Feburary");
                        }
                        break;
                    case 3:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("March");
                        }
                        break;
                    case 4:
                        day_of_month = 30;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("April");
                        }
                        break;
                    case 5:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("May");
                        }
                        break;
                    case 6:
                        day_of_month = 30;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("June");
                        }
                        break;
                    case 7:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("July");
                        }
                        break;
                    case 8:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("August");
                        }
                        break;
                    case 9:
                        day_of_month = 30;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("September");
                        }
                        break;
                    case 10:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("October");
                        }
                        break;
                    case 11:
                        day_of_month = 30;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("November");
                        }
                        break;
                    case 12:
                        day_of_month = 31;
                        if (i >= monthfrom)
                        {
                            Console.WriteLine("December");
                        }
                        break;
                }
                bool first_week = true;
                int date = 1;
                if (i >= monthfrom)
                {
                    Console.WriteLine("Mon Tue Wed Thu Fro Sat Sun");
                }
                while(date<=day_of_month)
                {
                    for (int j = 1; j <= 7; j++)
                    {
                        if (j < dayfrom && first_week == true)
                        {
                            if (i >= monthfrom)
                            {
                                Console.Write("    ");
                            }
                        }
                        else
                        {
                            if (i >= monthfrom)
                            {
                                Console.Write("{0,3} ", date);
                            }
                            date++;
                            dayfrom++;
                            if (dayfrom == 8)
                            {
                                dayfrom = 1;
                            }
                            if (date > day_of_month)
                            {
                                break;
                            }
                        }
                    }
                    first_week = false;
                    if (i >= monthfrom){
                        Console.WriteLine();
                    }
                }
                if (i >= monthfrom)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
