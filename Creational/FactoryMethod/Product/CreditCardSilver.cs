namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardSilver : ICreditCard
    {
        public CreditCardSilver(decimal creditLimit, decimal subscriptionFee)
        {
            this.CreditLimit = creditLimit;
            this.SubscriptionFee = subscriptionFee;
        }

        public decimal CreditLimit { get; set; }

        public decimal SubscriptionFee { get; set; }

        public void CheckOutstandingBalance()
        {
            throw new System.NotImplementedException();
        }
    }
}