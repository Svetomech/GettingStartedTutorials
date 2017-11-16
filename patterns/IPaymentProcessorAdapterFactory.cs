namespace GettingStartedTutorials.CSharp.Patterns
{
    public interface IPaymentProcessorAdapterFactory
    {
        IPaymentProcessorAdapter Create(string providerName);
    }
}