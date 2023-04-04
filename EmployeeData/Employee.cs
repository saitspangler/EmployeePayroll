using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class Employee
    {
        // calculation  constants
        const decimal FULL_WEEK = 37.5m;
        const decimal OT_RATE = 1.5m;

        // private data
        private string name;
        private decimal hours;
        private decimal rate;

        // constuctor
        public Employee(string name, decimal hours, decimal rate)
        {
            this.name = name;
            this.hours = hours;
            this.rate = rate;
        }

        // public methods
        // keywords: override, virtual, or abstract - allow overriding
        public virtual decimal CalculatePay()
        {
            if(hours <= FULL_WEEK) // all straight time
            {
                return hours * rate;
            }
            else // with overtime
            {
                return FULL_WEEK * rate +
                    (hours - FULL_WEEK) * rate * OT_RATE;
            }
        }

        public override string ToString() // inverited from class named Object
        {
            return $"{name}: {hours}, {rate.ToString("c")} - " +
                   $"{CalculatePay().ToString("c")}";
        }

    }
}
