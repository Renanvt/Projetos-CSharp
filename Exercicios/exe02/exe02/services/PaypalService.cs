using System;
using System.Collections.Generic;
using System.Text;

namespace exe02.services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02; //Taxa de pagamento
        private const double MonthlyInterest = 0.01; //Juro simples
        public double PaymentFree(double amount)
        {
            return amount * FeePercentage;
        }
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
