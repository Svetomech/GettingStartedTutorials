namespace GettingStartedTutorials.CSharp.Patterns.Adapters.ProviderAggregate
{
    internal class PaySalProvider
    {
        // throws exception if payment is rejected
        public void ProcessPayment(string merchantId, CreditCardDetails cardInfo, 
                                   decimal amount)
        { }
    }
}