namespace Order_API
{
    public class OrderType
    {
        public OrderType(long orderNumber, DateTime orderDate, double totalAmount, string? customerName, List<string>? productName)
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            CustomerName = customerName;
            ProductName = productName;
        }

        public long OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public String?  CustomerName { get; set; }
        public List<String>? ProductName { get; set; }
    }
}
