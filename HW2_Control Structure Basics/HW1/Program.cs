using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("剪刀=1 , 石頭=2, 布=3，請出拳");
            string 用戶 = Console.ReadLine();
            Random random = new Random();
            string 電腦 = (random.Next(0, 3) + 1).ToString();

            Console.WriteLine("電腦出: {0}", 電腦);
            if (用戶 == 電腦)
                Console.WriteLine("平手!");
            else if ((用戶 == "1" && 電腦 == "3") || (用戶 == "2" && 電腦 == "1") || (用戶 == "3" && 電腦 == "2"))
                Console.WriteLine("你贏了!");
            else if ((用戶 == "1" && 電腦 == "2") || (用戶 == "2" && 電腦 == "3") || (用戶 == "3" && 電腦 == "1"))
                Console.WriteLine("你輸了!");
        }
    }
}