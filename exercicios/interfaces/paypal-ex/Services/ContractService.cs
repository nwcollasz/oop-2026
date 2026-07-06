using paypal_ex.Entities;
using System;

namespace paypal_ex.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int installments)
        {
            double division = contract.TotalValue / installments;

            for (int i = 1; i <= installments; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updatedDivision = division + _onlinePaymentService.Interest(division, i);
                double fullQuota = updatedDivision + _onlinePaymentService.PaymentFee(updatedDivision);

                contract.Installments.Add(new Installments(dueDate, fullQuota));
            }
        }
    }   
}