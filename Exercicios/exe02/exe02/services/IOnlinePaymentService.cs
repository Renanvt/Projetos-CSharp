using System;
using System.Collections.Generic;
using System.Text;

namespace exe02.services
{
    interface IOnlinePaymentService
    {
        double PaymentFree(double amount);//Taxa por pagamento
        double Interest(double amount, int months); //Juros
    }
}
