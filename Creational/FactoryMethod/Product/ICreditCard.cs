namespace DesignPatterns.Creational.FactoryMethod
{
    public interface ICreditCard
    {
        decimal CreditLimit { get; set; }

        decimal SubscriptionFee { get; set; }

        void CheckOutstandingBalance();
    }
}