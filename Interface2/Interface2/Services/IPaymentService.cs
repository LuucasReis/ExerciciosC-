using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Services
{
    public interface IPaymentService
    {
        double Payment(double amount, int months);
    }
}
