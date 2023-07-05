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
            Random crandom = new Random();
            int num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            num = crandom.Next(0, 2);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
