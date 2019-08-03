using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager(string name, int id, int age, float pay, string ssn, int numbOfOpt) : base (name,id, age, pay, ssn)
        {
            StockOptions = numbOfOpt;
        }
        public Manager()
        {
           
        }
        public override void BonusEmp(float bonus)
        {

            base.BonusEmp(bonus);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void ShowEmp()
        {
            base.ShowEmp();
            Console.WriteLine("Number of stock : {0}\n", StockOptions);
        }
    }
   
}
