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
            Console.Write("請問購買金額為:");
            int buy = int.Parse(Console.ReadLine());
            Console.Write("請問您的付款金額:");
            int pay = int.Parse(Console.ReadLine());
            int return_money = pay - buy;
            if(return_money < 0)
            {
                Console.Write("你還需要付{0}", buy - pay);
                return;
            }
            else if (return_money==0)
            {
                Console.Write("不需要找零");
            }
            else
            {
                int thousand = return_money / 1000;
                int five_hundred = (return_money % 1000) / 500;
                int hundred = (return_money % 500) / 100;
                int fifty = (return_money % 100) / 50;
                int ten = (return_money % 50) / 10;
                int five = (return_money % 10) / 5;
                int one = (return_money % 5) / 1;
                Console.WriteLine("應找您\n1000元(幾張):{0}\n500元(幾張):{1}\n100元(幾張):{2}\n50元(幾塊):{3}\n10元(幾塊):{4}\n5元(幾塊):{5}\n1元(幾塊):{6}\n", thousand, five_hundred, hundred, fifty, ten, five, one);
                Console.ReadKey();
            }
        }
    }
}
