namespace GettingStartedTutorials.CSharp.Patterns.Adapters.ProviderAggregate
{
    internal class StwipeProvider
    {
        public StwipeProvider(string merchantKey)
        { }

        // returns false if payment is rejected
        public bool Pay(string cardNumber, string expiration, decimal amount)
        { return false; }
    }
}