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
        public override void BonusEmp(float bonus)
        {
            int saleBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                saleBonus = 10;
            else
            { if (SalesNumber > 100 && SalesNumber <= 200)
                    saleBonus = 15;
                else saleBonus = 20;
            }
            base.BonusEmp(bonus*saleBonus);

        }
        public sealed override void ShowEmp()
        {
            base.ShowEmp();
            Console.WriteLine("Sales Number: {0}\n", SalesNumber);
        }
    }
}
