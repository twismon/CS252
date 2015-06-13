using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a, b, answer = 0;            //宣告位置跟數字都對為A的變數個數，數字對但位置錯為B的變數個數

            Console.Write("請問要玩幾位數的猜數字(1~10):");
            int number = int.Parse(Console.ReadLine());
            int[] ans = new int[number];

            Random random = new Random(Guid.NewGuid().GetHashCode());   //利用New.Guid()產生雜測碼來當作亂數產生器的種子

            for (int i = 0; i < number; i++)
                ans[i] = random.Next(1, 10);

            //foreach (int temp in ans)                     //是否要印出答案，debug用
            //    Console.Write(temp.ToString());
            //Console.WriteLine();

            for (int i = 0; i < number; i++)
                answer += (int)Math.Pow(10, (number - 1 - i)) * ans[i];

            do
            {
                a = 0;
                b = 0;
                Console.WriteLine("請輸入你的猜測({0}個數字，不包含0):", number);
                string guess = Console.ReadLine();

                if (int.Parse(guess) == answer)
                    break;
                for (int i = 0; i < number; i++)
                {
                    for (int j = i; j < number; j++)

                        if (i == j && guess.Substring(i, 1) == ans[j].ToString())
                            a++;
                        else if (i != j && guess.Substring(i, 1) == ans[j].ToString())
                            b++;
                }

                Console.WriteLine("你猜錯了, 提示是{0} A {1} B", a, b);
            } while (a != 4);

            Console.WriteLine("恭喜你答對了!");
        }
    }
}