using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入要階乘的值x");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1, i = 1;
            while (i <= x)
                factorial *= i++;
            Console.WriteLine("1~" + x + "的階乘為" + factorial);
        }
    }
}