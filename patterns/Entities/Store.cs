using GettingStartedTutorials.CSharp.Patterns.Interfaces;

namespace GettingStartedTutorials.CSharp.Patterns.Entities
{
    public class Store
    {
        private readonly IPaymentProcessorAdapterFactory _factory;

        public Store(IPaymentProcessorAdapterFactory factory)
        {
            _factory = factory;
        }

        public string Name { get; set; }
        public string PaymentProvider { get; set; }
        public string MerchantId { get; set; }

        public void ProcessCard(string cardNumber, string expiration,
                                decimal amount)
        {
            var adapter = _factory.Create(PaymentProvider);

            adapter.ProcessPayment(MerchantId, cardNumber, expiration, amount);
        }
    }
}