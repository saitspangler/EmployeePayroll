using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class PermanentEmployee : Employee  // inherits from employee
    {
        // add more private data
        private decimal rrspPct; // percent as decimal, e.g. 0.1m for 10%

        // constructor
        public PermanentEmployee(string name, decimal hours, decimal rate,
            decimal rrspPct): base(name, hours, rate) // pass data to base class constr.
        {
            this.rrspPct  = rrspPct;// only initialize own data
        }

        // public methods

        // add new method
        public decimal CalculateRRSP()
        {
            decimal basePay = base.CalculatePay();
            return basePay * rrspPct;
        }
        // overridden methods
        // iverride CalculatePay() from base class
        public override decimal CalculatePay()
        {
            decimal basePay = base.CalculatePay(); // call CalculatePay() from the base class
            decimal rrsp = CalculateRRSP();
            return basePay - rrsp;
        }

        // override inherited ToString() method
        public override string ToString()
        {
            return base.ToString() + ", " + rrspPct.ToString("p") + 
                   $" RRSP deducted: {CalculateRRSP().ToString("c")}";
        }
    }
}
