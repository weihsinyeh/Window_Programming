//F74109016 資訊系113 葉惟欣 Practice 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayfrom, monthfrom;
            try
            {
                Console.Write("1月1日星期幾(1-7):");
                dayfrom = int.Parse(Console.ReadLine());   // weekday 是開始日期的星期幾
                if (!((dayfrom >= 1) && (dayfrom <= 7)))
                {
                    Console.Write("超出範圍");
                    Console.ReadKey();
                    return;
                }
                Console.Write("從幾月開始(1-12):");
                monthfrom = int.Parse(Console.ReadLine()); // monthfrom 開始的月份
                if (!((monthfrom >= 1) && (monthfrom <= 12)))
                {
                    Console.Write("超出範圍");
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
            for (int i = 1; i <= 12; i++)
            {
                if (i >= monthfrom)          //只有在i>=輸入月份時才會列印出英文的月份
                {
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("January");
                            break;
                        case 2:
                            Console.WriteLine("Feburary");
                            break;
                        case 3:
                            Console.WriteLine("March");
                            break;
                        case 4:
                            Console.WriteLine("April");
                            break;
                        case 5:
                            Console.WriteLine("May");
                            break;
                        case 6:
                            Console.WriteLine("June");
                            break;
                        case 7:
                            Console.WriteLine("July");
                            break;
                        case 8:
                            Console.WriteLine("Auguest");
                            break;
                        case 9:
                            Console.WriteLine("September");
                            break;
                        case 10:
                            Console.WriteLine("Octorber");
                            break;
                        case 11:
                            Console.WriteLine("November");
                            break;
                        case 12:
                            Console.WriteLine("December");
                            break;
                    }
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");   //每次輸入月份後都要印出星期列
                }
                int month_days, counter_day = 1, date = 1; //一個月有幾天// 現在數到禮拜幾了//現在是i月的幾號
                if ((i == 1) || (i == 3) || (i == 5) || (i == 7) || (i == 8) || (i == 10) || (i == 12))
                {
                    month_days = 31;
                }
                else if (i == 2)
                {
                    month_days = 28;
                }
                else
                {
                    month_days = 30;
                }
                bool firstweek = true;                 //第一個禮拜先開始，所以就直接射程true
                while (date <= month_days)
                {
                    if ((firstweek == true) && (counter_day < dayfrom))   //如果是第一個禮拜且還未到開始的星期就印空白
                    {
                        if (i >= monthfrom)  //當i大於開始的月份就開始顯示月曆，回圈從一月開始跑是為了要算出接下來的日子，但不會印出來開始月份以前的月曆
                        {
                            Console.Write("    ");
                        }
                        counter_day++;
                    }
                    if ((counter_day >= dayfrom) || (firstweek == false)) //如果已經到開始的星期就印當天的日期，又或是不是第一個禮拜就都要印了
                    {
                        if (i >= monthfrom)
                        {
                            Console.Write("{0,3} ", date);
                        }
                        counter_day++;
                        date++;
                    }
                    if (counter_day == 8)      //當已經數到星期日 ，上面if的body裡面有counter++，但此時已經超過一個禮拜的星期數量，所以重新設為星期一。
                    {
                        counter_day = 1;
                        firstweek = false;
                        if (i >= monthfrom)    //換行只在月份大於開始月份時才會出現。
                        {
                            Console.WriteLine();
                        }
                    }
                }
                if (i >= monthfrom) //每個月間都要有空白的一行。
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                dayfrom = counter_day; //將每個月開始的日期做更新
            }
            Console.ReadKey();
        }
    }
}
