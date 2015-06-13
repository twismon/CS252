using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Name, Gender;
            Console.WriteLine("請您輸入姓名:");
            Name = Console.ReadLine();
            Console.WriteLine("請您輸入性別, 男或女?");
            Gender = Console.ReadLine();
            Console.WriteLine("{0}您好!!", Name);
            Console.WriteLine("我猜{0}您一定是{1}生", Name, Gender);
        }
    }
}