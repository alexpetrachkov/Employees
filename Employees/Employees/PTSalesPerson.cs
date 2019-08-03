using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
     sealed class PTSalesPerson: SalesPerson
    {
        public PTSalesPerson(string name, int id, int age, float pay, string ssn, int numbOfSales) : base(name, id, age, pay, ssn, numbOfSales)
        {

        }
    }
}
