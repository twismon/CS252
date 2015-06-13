using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入月份:");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("這是春天");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("這是夏天");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("這是秋天");
                    break;

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("這是冬天");
                    break;
            }
        }
    }
}