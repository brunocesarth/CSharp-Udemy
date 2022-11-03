using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo_086.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
