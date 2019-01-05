namespace OrdersApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public Order(int id,decimal amount)
        {
            Id=id;
            Amount=amount;
        }
    }
}