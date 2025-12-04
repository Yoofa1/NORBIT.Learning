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

            DisplayItemsInfo(items);
        }

        /// <summary>
        /// Выводит объекты и их значения в консоль.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="indent"></param>
        static void DisplayItemsInfo(List<IOrderProcessingSystem> items, string indent = "|| ")
        {
            foreach (var item in items)
            {
                switch (item)
                {
                    case Customer customer:
                        Console.WriteLine("=================");
                        Console.WriteLine($"{indent}Customer:");
                        Console.WriteLine($"{indent}  ID: {customer.Id}");
                        Console.WriteLine($"{indent}  Name: {customer.Name}");
                        Console.WriteLine($"{indent}  Balance: {customer.Balance}");
                        if (customer.Items?.Count > 0)
                        {
                            Console.WriteLine($"{indent}  Orders:");
                            DisplayItemsInfo(customer.Items, indent + " ");
                        }
                        break;

                    case Order order:
                        Console.WriteLine("=================");
                        Console.WriteLine($"{indent}Order:");
                        Console.WriteLine($"{indent}  ID: {order.Id}");
                        Console.WriteLine($"{indent}  Date: {order.OrderDate}");
                        if (order.Items?.Count > 0)
                        {
                            Console.WriteLine($"{indent}  Payments:");
                            DisplayItemsInfo(order.Items, indent + " ");
                        }
                        break;

                    case Payment payment:
                        Console.WriteLine("=================");
                        Console.WriteLine($"{indent}Payment:");
                        Console.WriteLine($"{indent}  ID: {payment.Id}");
                        Console.WriteLine($"{indent}  Type: {payment.PaymentType}");
                        Console.WriteLine($"{indent}  Date: {payment.PaymentDate}");
                        if (payment.Items?.Count > 0)
                        {
                            Console.WriteLine($"{indent}  Carts:");
                            DisplayItemsInfo(payment.Items, indent + " ");
                        }
                        break;

                    case Cart cart:
                        Console.WriteLine("=================");
                        Console.WriteLine($"{indent}Cart:");
                        Console.WriteLine($"{indent}  ID: {cart.Id}");
                        if (cart.Items?.Count > 0)
                        {
                            Console.WriteLine($"{indent}  Products:");
                            DisplayItemsInfo(cart.Items, indent + " ");
                        }
                        break;

                    case Product product:
                        Console.WriteLine("=================");
                        Console.WriteLine($"{indent}Product:");
                        Console.WriteLine($"{indent}  ID: {product.Id}");
                        Console.WriteLine($"{indent}  Name: {product.Name}");
                        Console.WriteLine($"{indent}  Price: {product.Price}");
                        Console.WriteLine("+-+-+-+-+-+-+-+-+");

                        break;
                }
                Console.WriteLine();
            }
        }
    }

    /// <summary>
    /// Класс ПОЛЬЗОВАТЕЛЬ со следующими атрибутами:
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
    /// Класс ТОВАР со следующими атрибутами:
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
    /// Класс КОРЗИНА со следующими атрибутами:
    /// - CartID
    /// </summary>
    public class Cart : IOrderProcessingSystem
    {
        public int Id { get; set; }
        public List<IOrderProcessingSystem> Items { get; set; }
    }

    /// <summary>
    /// Класс ОПЛАТА со следующими атрибутами:
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
    /// Класс ЗАКАЗ со следующими атрибутами:
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