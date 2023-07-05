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
            int [] ary = new int[] {111,222,333,444,555,666};
            Console.Write("Original array:");
            foreach (int num in ary)
            {
                str1 += num.ToString() + " ";
            }
            Console.WriteLine("{0}", str1);
            //Array left shift
            int temp;
            temp = ary[0];
            for(int i = 0; i <= ary.Length - 2; i++) //6-2=4, 0~4
            {
                ary[i] = ary[i + 1];  //ary[0] = ary[1] =222;
            }
            ary[ary.Length - 1] = temp; //ary[6-1=5] =temp =111;
            str1 = "";
            Console.Write("Array left shift: ");
            foreach(int num in ary)
            {
                str1 += num.ToString() + " ";
            }
            Console.WriteLine("{0}", str1);
            //Array right shift
            Console.Write("Array right shift:");
            temp = ary[ary.Length - 1];
        }
    }
}
