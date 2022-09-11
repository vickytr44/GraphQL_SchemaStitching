namespace Order_API
{
    public class OrderRepository
    {
        private readonly List<OrderType> _order;

        public OrderRepository()
        {
            _order = new OrderType[]
            {
                new OrderType(1,Convert.ToDateTime("2022-01-01"), 1000,"Ava",new List<string> (){ "Watch","Laptop","Mobile"}),
                new OrderType(2,Convert.ToDateTime("2022-01-01"), 150,"Jeeva",new List<string> (){"Mobile"}),
                new OrderType(3,Convert.ToDateTime("2022-02-01"), 50,"Ava",new List<string> (){ "Perfume"}),
                new OrderType(4,Convert.ToDateTime("2022-03-01"), 1100,"Ava",new List<string> (){ "Sheo","Shirt"}),
                new OrderType(5,Convert.ToDateTime("2022-03-01"), 200,"Ava",new List<string> (){ "Jean"})
            }.ToList();
        }

        public List<OrderType> GetOrder() => _order;
        public List<OrderType> GetOrderBy(string name) => _order.Where(x => x.CustomerName == name).ToList();
    }
}
