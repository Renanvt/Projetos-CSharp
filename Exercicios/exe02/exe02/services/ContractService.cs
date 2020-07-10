using exe02.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace exe02.services
{
    class ContractService
    {
        private IOnlinePaymentService onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this.onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i =1; i<= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + onlinePaymentService.PaymentFree(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
