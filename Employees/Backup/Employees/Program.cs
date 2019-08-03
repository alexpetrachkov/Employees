using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.ID = 787979;
            fred.Pay = 30000;
            fred.SalesNumber = 479;
            Manager mike = new Manager("Mike", 34, 54,60000, "234-54-544", 435);
            //Console.WriteLine("Mike's SSN: {0}, benefit : {1}", mike.SoscialSecurityNomber, mike.GetBenefitCost()); 
            Manager john = new Manager();
            mike.ShowEmp();
            double b = 8/2*(2+2);
            Console.WriteLine("{0}",b);                  
        }
    }
}
