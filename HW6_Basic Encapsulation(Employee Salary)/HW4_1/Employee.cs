using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    internal class Employee
    {
        private int encapBasePay;
        private int encapBonus;

        //Properties to access encapsulated objects
        public int basePay
        {
            set
            {
                if (value < 0)
                    this.encapBasePay = 0;
                else
                    this.encapBasePay = value;
            }

            get
            {
                return this.encapBasePay;
            }
        }

        public int bonus
        {
            get { return this.encapBonus; }
            set { this.encapBonus = value; }
        }

        public int salary
        {
            get { return this.encapBasePay + this.encapBonus; }
        }
    }
}