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
            string str1 = "";
            int [] ary = { 111,222,333,444,555,666};
            Console.Write("Original array:");
            foreach(int num in ary)
            {
                str1 += num.ToString() + " ";
            }
            Console.WriteLine("{0}", str1);
            int temp;
            temp = ary[0];
            for(int i = 0; i <= ary.Length - 2; i++)
            {
                ary[i] = ary[i + 1];
            }
            ary[ary.Length - 1] = temp;
        }
    }
}
