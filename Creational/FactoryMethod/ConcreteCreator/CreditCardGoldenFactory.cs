namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardGoldenFactory : CreditCardFactory
    {
        private readonly decimal _creditLimit;
        private readonly decimal _subscriptionFee;

        public CreditCardGoldenFactory(decimal creditLimit, decimal subscriptionFee)
        {
            _creditLimit = creditLimit;
            _subscriptionFee = subscriptionFee;
        }

        public override ICreditCard GetCreditCard()
        {
            return new CreditCardGolden(_creditLimit, _subscriptionFee);
        }
    }
}