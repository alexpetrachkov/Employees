using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson()
        {

        }
        public SalesPerson(string name, int id, int age, float pay, string ssn, int numbOfSales) : base (name,id, age, pay, ssn)
        {
            SalesNumber = numbOfSales;
        }
    }
}
