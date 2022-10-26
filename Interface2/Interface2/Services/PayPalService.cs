using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Services
{
    public class PayPalService : IPaymentService
    {
        public double Payment(double amount, int months)
        {
            double p_valor = amount + (amount * 0.01) * months;
            return p_valor+= p_valor * 0.02;
        }
    }
}
