using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class BenefitPackage
    {
        enum BenefitPakageLevel
        { 
            Standart, Gold, Platinum
        }
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}
