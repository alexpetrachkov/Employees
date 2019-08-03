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
    }
   
}
