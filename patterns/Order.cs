namespace GettingStartedTutorials.CSharp.Patterns
{
    public class Order
    {
        private readonly IOrderRepository _orderRepository;

        public Order(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Complete()
        {
            // other logic omitted
            _orderRepository.Add(this);
        }
    }
}