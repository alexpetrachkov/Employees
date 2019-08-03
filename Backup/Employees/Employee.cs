using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
   partial class Employee
    {
       public string SoscialSecurityNomber
       {
           get { return EmpSSN; }
       }

        public string Name
        {
            get { return EmpName; }
            set 
            { if (value.Length > 15)
                Console.WriteLine("Error! Invalid name! You can try again\n");
            else EmpName = value;
            }
        }
        public int ID
        {
            get { return EmpID; }
            set {EmpID = value;}
        }
        public int Age
        {
            get { return EmpAge; }
            set 
            { if (value < 16 || value > 90)
                Console.WriteLine("Error! Invalid age! You can try again\n");
            else EmpAge = value;
            }
        }

        public float Pay
        {
            get { return EmpPay; }
            set { EmpPay = value; }
        }
        /* public void SetEmpName(string name) // Изменение значения поля имени
        {
            if (name.Length > 15)
                Console.WriteLine("Error! Invalid name! You can try again");
            else
            {
                Console.WriteLine("Name chande successful!");
                EmpName = name;
            }
        }
        public string GetEmpName()
        {
            return EmpName;
        }*/
        
        public void BonusEmp(float bonus)
        {
            Console.WriteLine("{0} give a bonus : {1}\n", Name, bonus);
            Pay += bonus;
        }
        public void ShowEmp()
        {
            Console.WriteLine("Information about : {0}", Name);
            Console.WriteLine("ID: {0}\tAge: {1}\nPay: {2}\tSSN: {3}\nBetefit : {4}\n", ID,Age, Pay, SoscialSecurityNomber, EmpBenefit.ComputePayDeduction() );
        }
    }
}
