using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{
    internal class TaxCalculate
    {
        public static decimal CalculateTax(decimal salary)
        {
            if (salary <= 540000) return salary * 0.05m;
            else if (salary <= 1210000) return 540000 * 0.05m + (salary - 540000) * 0.12m;
            else if (salary <= 2420000) return 540000 * 0.05m + 670000 * 0.12m + (salary - 1210000) * 0.2m;
            else if (salary <= 4530000) return 540000 * 0.05m + 670000 * 0.12m + 1210000 * 0.2m + (salary - 2420000) * 0.3m;
            else if (salary <= 10310000) return 540000 * 0.05m + 670000 * 0.12m + 1210000 * 0.2m + 2110000 * 0.3m + (salary - 4530000) * 0.4m;
            else return 540000 * 0.05m + 670000 * 0.12m + 1210000 * 0.2m + 2110000 * 0.3m + 5780000 * 0.4m + (salary - 10310000) * 0.5m;
        }
    }
}
