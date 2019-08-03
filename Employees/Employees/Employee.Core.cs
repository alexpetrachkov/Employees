using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    /*abstract*/ partial class Employee
    {
        protected string EmpName;
        protected int EmpID;
        protected int EmpAge;
        protected float EmpPay;
        protected string EmpSSN;
        protected BenefitPackage EmpBenefit = new BenefitPackage(); //содержит объект  BenefitPackege

        // Отктывает доступ к некоторому поведению, связанному со льготами
        public double GetBenefitCost()
        {
            return EmpBenefit.ComputePayDeduction();
        }
        // Открывает доступ к объекту через спец. свойство
        public BenefitPackage Benefits 
       {
           get { return EmpBenefit; }

           set {EmpBenefit = value;} 
        }

        public Employee()
        {

        }
        public Employee(string name, int id, float pay)
            : this(name, id, 0, pay)
        {

        }
        public Employee(string name, int id, int age, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }
        public Employee(string name, int id, int age, float pay, string ssn): this (name,id,age,pay)
        {
            EmpSSN = ssn;
        }
    }
}
