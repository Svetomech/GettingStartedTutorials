namespace GettingStartedTutorials.CSharp.Patterns
{
    public partial class PaySalProvider
    {
        // throws exception if payment is rejected
        public void ProcessPayment(string merchantId, CreditCardDetails cardInfo, 
                                   decimal amount)
        { }
    }
}