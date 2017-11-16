namespace GettingStartedTutorials.CSharp.Patterns
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