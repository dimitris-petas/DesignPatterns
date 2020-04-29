namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardPlatinum : ICreditCard
    {
        public CreditCardPlatinum(decimal creditLimit, decimal subscriptionFee)
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