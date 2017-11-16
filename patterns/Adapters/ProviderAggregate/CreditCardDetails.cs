namespace GettingStartedTutorials.CSharp.Patterns.Adapters.ProviderAggregate
{
    internal class CreditCardDetails
    {
        public CreditCardDetails(string cardNumber, string expiration)
        {
            CardNumber = cardNumber;
            Expiration = expiration;
        }

        public string CardNumber { get; private set; }
        public string Expiration { get; private set; }
    }
}