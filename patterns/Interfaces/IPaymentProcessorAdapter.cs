namespace GettingStartedTutorials.CSharp.Patterns.Interfaces
{
    public interface IPaymentProcessorAdapter
    {
        // returns false if payment is rejected
        bool ProcessPayment(string merchantId, string cardNumber,
                            string expiration, decimal amount);
    }
}