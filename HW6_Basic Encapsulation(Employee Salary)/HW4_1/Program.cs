using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee user = new Employee();
            Console.WriteLine("請輸入底薪:");
            int basePay = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入獎金");
            int bonus = int.Parse(Console.ReadLine());

            user.basePay = basePay;
            user.bonus = bonus;
            Console.WriteLine("您的底薪是" + user.basePay.ToString());
            Console.WriteLine("您的獎金是" + user.bonus.ToString());
            Console.WriteLine("您的薪水是" + user.salary.ToString());
        }
    }
}