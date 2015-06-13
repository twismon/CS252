using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入x的值");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i = i + 2)
                sum += i;
            Console.WriteLine("1~" + x + "之間的奇數和為" + sum);
        }
    }
}