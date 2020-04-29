using DesignPatterns.Creational.FactoryMethod.Model;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public interface ICreditCardService
    {
        Task<CreditCardResponse> CreateCreditCard(CreditCardRequest request);
    }

    public class CreditCardService : ICreditCardService
    {
        public async Task<CreditCardResponse> CreateCreditCard(CreditCardRequest request)
        {
            CreditCardFactory cardFactory = null;
            switch (request.CardType.ToLower())
            {
                case "silver":
                    cardFactory = new CreditCardSilverFactory(50000, 10);
                    await Task.FromResult(cardFactory);
                    break;

                case "gold":
                    cardFactory = new CreditCardGoldenFactory(100000, 50);
                    await Task.FromResult(cardFactory);
                    break;

                case "platinum":
                    cardFactory = new CreditCardPlatinumFactory(500000, 100);
                    await Task.FromResult(cardFactory);
                    break;

                default:
                    break;
            }

            return new CreditCardResponse
            {
                CreditLimit = cardFactory.GetCreditCard().CreditLimit,
                SubscriptionFee = cardFactory.GetCreditCard().SubscriptionFee
            };
        }
    }
}