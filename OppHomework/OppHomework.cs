namespace OppHomeworkOne
{
    /// <summary>
    /// * Customer
    /// - -* Order
    /// - - - -* Payment
    /// - - - - - -* Cart
    /// - - - - - - - -* Product
    /// </summary>
    internal class OppHomework
    {
        static void Main(string[] args)
        {
            var items = new List<IOrderProcessingSystem>();

            items.Add(new Customer()
            {
                Id = 1,
                Name = "Jhon",
                Balance = 1000.3f,
                Items = new List<IOrderProcessingSystem> // orders
                {
                    new Order()
                    {
                        Id = 1,
                        OrderDate = new DateTime(2025, 11, 30, 14, 20, 0),
                        Items = new List<IOrderProcessingSystem>() // payments
                        {
                            new Payment()
                            {
                                Id = 1,
                                PaymentType = "non-cash",
                                PaymentDate = new DateTime(2025, 11, 30, 14, 30, 0),
                                Items = new List<IOrderProcessingSystem>() // carts
                                {
                                    new Cart()
                                    {
                                        Id = 1,
                                        Items = new List<IOrderProcessingSystem>() // products
                                        {
                                            new Product()
                                            {
                                                Id = 1,
                                                Name = "Laptop",
                                                Price = 999.999f
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
        }
    }

    /// <summary>
    /// - CustomerID
    /// - CustomerName
    /// - Balance
    /// </summary>
    public class Customer : IOrderProcessingSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        public List<IOrderProcessingSystem> Items { get; set; }

    }

    /// <summary>
    /// - ProductID
    /// - ProductName
    /// - Price
    /// </summary>
    public class Product : IOrderProcessingSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }

    /// <summary>
    /// - CartID
    /// </summary>
    public class Cart : IOrderProcessingSystem
    {
        public int Id { get; set; }
        public List<IOrderProcessingSystem> Items { get; set; }
    }

    /// <summary>
    /// - PaymentID
    /// - PaymentType
    /// - PaymentDate
    /// </summary>
    public class Payment : IOrderProcessingSystem
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }     // by cart / non-cash
        public DateTime PaymentDate { get; set; }
        public List<IOrderProcessingSystem> Items { get; set; }

    }

    /// <summary>
    /// - OrderID
    /// - OrderDate
    /// </summary>
    public class Order : IOrderProcessingSystem
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<IOrderProcessingSystem> Items { get; set; }

    }

    public interface IOrderProcessingSystem
    {
        public int Id { get; set; }
    }
}