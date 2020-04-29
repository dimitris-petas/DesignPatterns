using DesignPatterns.Behavioral.Strategy.Model;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface  IPaymentMethod
    {
        string Code { get; }

        Task<PaymentResult> Process(PaymentRequest request);
    }
}