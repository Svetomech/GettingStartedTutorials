namespace GettingStartedTutorials.CSharp.Patterns.Interfaces
{
    public interface IPaymentProcessorAdapterFactory
    {
        IPaymentProcessorAdapter Create(string providerName);
    }
}