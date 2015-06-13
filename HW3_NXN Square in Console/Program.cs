using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入x的值:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                if (i != 0)
                    Console.Write("\n");
                for (int j = 0; j < x; j++)
                    Console.Write("*");
            }
        }
    }
}