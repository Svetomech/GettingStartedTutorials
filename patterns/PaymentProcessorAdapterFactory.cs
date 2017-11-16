namespace GettingStartedTutorials.CSharp.Patterns
{
    public class PaymentProcessorAdapterFactory : IPaymentProcessorAdapterFactory
    {
        public IPaymentProcessorAdapter Create(string providerName)
        {
            switch (providerName)
            {
                case nameof(Provider.Stwipe):
                    return new StwipeAdapter();
                case nameof(Provider.PaySal):
                    return new PaySalAdapter();
                default:
                    throw new InvalidPaymentProviderException(providerName);
            }
        }
    }
}