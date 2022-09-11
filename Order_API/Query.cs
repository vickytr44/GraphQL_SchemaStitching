namespace Order_API
{
    public class Query 
    {
        public List<OrderType> GetOrder([Service] OrderRepository orderRepository)
        {
            return orderRepository.GetOrder();
        }
        
        public List<OrderType> GetOrderBy([Service] OrderRepository orderRepository,string name)
        {
            return orderRepository.GetOrderBy(name);
        }

    }
}
