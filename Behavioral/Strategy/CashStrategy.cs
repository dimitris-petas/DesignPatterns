using DesignPatterns.Behavioral.Strategy.Model;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy

{
    public class CashStrategy : IPaymentMethod
    {
        public string Code => "Cash";

        public async Task<PaymentResult> Process(PaymentRequest request)
        {
            var res = new PaymentResult { PaidWith = Code };

            return await Task.FromResult(res).ConfigureAwait(false);
        }
    }
}