using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入x值");
            int x = int.Parse(Console.ReadLine());
            int sum = 0, i = 0;
            while (sum <= x)
                sum += ++i;
            Console.WriteLine("1~" + i + "的和大於" + x);
            Console.WriteLine("請輸入quit來退出程式");
            while (Console.ReadLine() != "quit") ;
        }
    }
}