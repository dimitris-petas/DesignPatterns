using DesignPatterns.Behavioral.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface IPaymentService
    {
        Task<PaymentResult> Pay(PaymentRequest request);
    }

    public class PaymentService : IPaymentService
    {
        private readonly IEnumerable<IPaymentMethod> _paymentMethods;

        //We inject a collection of Strategies interfaces because we are going to
        //search in the list with collection match with the given code
        public PaymentService(IEnumerable<IPaymentMethod> paymentMethods)
        {
            _paymentMethods = paymentMethods;
        }

        public async Task<PaymentResult> Pay(PaymentRequest request)
        {
            //Find in the IEnumerable<IPaymentMethod> witch implementation
            //we are going to use with the given strategy code
            var paymentMethod = _paymentMethods.FirstOrDefault(pm => pm.Code == request.SelectedPaymentMethod);

            //Check the response if is not null .Otherwise throw an exception.
            if (paymentMethod == null)
            {
                throw new ArgumentException("Payment method not found", request.SelectedPaymentMethod);
            }

            //Excecute the method of the respective implementation
            return await paymentMethod.Process(request);
        }
    }
}