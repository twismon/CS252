using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入九九乘法表大小(1~9):");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i * j < 10)
                        Console.Write(i + "*" + j + "= " + i * j + '\0');
                    else
                        Console.Write(i + "*" + j + "=" + i * j + '\0');
                }
                Console.WriteLine();
            }
        }
    }
}