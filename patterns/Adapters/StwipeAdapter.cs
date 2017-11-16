using GettingStartedTutorials.CSharp.Patterns.Adapters.ProviderAggregate;
using GettingStartedTutorials.CSharp.Patterns.Interfaces;

namespace GettingStartedTutorials.CSharp.Patterns.Adapters
{
    public class StwipeAdapter : IPaymentProcessorAdapter
    {
        public bool ProcessPayment(string merchantId, string cardNumber,
                                   string expiration, decimal amount)
        {
            var provider = new StwipeProvider(merchantId);
            return provider.Pay(cardNumber, expiration, amount);
        }
    }
}