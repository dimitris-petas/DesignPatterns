namespace DesignPatterns.Behavioral.Strategy.Model
{
    public class PaymentRequest
    {
        public string SelectedPaymentMethod { get; set; }
        public decimal Amount { get; set; }
    }
}