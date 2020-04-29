namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardPlatinumFactory : CreditCardFactory
    {
        private readonly decimal _creditLimit;
        private readonly decimal _subscriptionFee;

        public CreditCardPlatinumFactory(decimal creditLimit, decimal subscriptionFee)
        {
            _creditLimit = creditLimit;
            _subscriptionFee = subscriptionFee;
        }

        public override ICreditCard GetCreditCard()
        {
            return new CreditCardPlatinum(_creditLimit, _subscriptionFee);
        }
    }
}