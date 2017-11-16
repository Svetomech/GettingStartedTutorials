using GettingStartedTutorials.CSharp.Patterns.Adapters.ProviderAggregate;
using GettingStartedTutorials.CSharp.Patterns.Exceptions;
using GettingStartedTutorials.CSharp.Patterns.Interfaces;

namespace GettingStartedTutorials.CSharp.Patterns.Adapters
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