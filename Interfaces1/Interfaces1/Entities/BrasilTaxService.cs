using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1.Entities
{
    public class BrasilTaxService : ITaxService
    {
        protected double Percent1 = 0.2; { get; private set; }
        protected double Percent2 = 0.15; {get; private set;}

        public double Tax(double amount)
        {
            if(amount <= 100.0)
            { 
                return amount * Percent1;
            }
            else
            {
                return amount * Percent2;
            }
        }
    }
}
