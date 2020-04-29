namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardGolden : ICreditCard
    {
        public CreditCardGolden(decimal creditLimit, decimal subscriptionFee)
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