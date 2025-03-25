using System;

class Program
{
    static void Main(string[] args)
    {
        //Initializing the products for customer1
        Product product1 = new Product("Laptop", 1410, 1450.99, 15);
        Product product2 = new Product("Smartphone", 2830, 599.99, 20);
        Product product3 = new Product("Headphones", 3330, 149.99, 15);

        //Initializing the products for customer2
        Product product4 = new Product("Tablet", 4532, 299.99, 150);
        Product product5 = new Product("Smartwatch", 5021, 199.99, 80);
        Product product6 = new Product("Camera", 6340, 450.00, 60);
        Product product7 = new Product("Bluetooth Speaker", 7070, 79.99, 120);

        //Creating the lists of products for each Order
        List<Product> productsOrder1 = new List<Product> { product1, product2, product3 };
        List<Product> productsOrder2 = new List<Product>{product4,product5,product6,product7};

        //Creating the 2 addresses, (one for each Customer)
        Address address1 = new Address("123 Main Street", "Provo", "UT", "USA");
        Address address2 = new Address("2139 Auburn Ave", "Dayton", "OH", "USA");

        //Creating the two Customers, (one for each order)
        Customer customer1 = new Customer("Emmanuel Johnson", address1);
        Customer customer2 = new Customer("Peter Smith", address2);

        //Initializing the two orders
        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsOrder2, customer2);

        //Create a list to store the two orders
        List<Order> orders = new List<Order>{order1,order2};

        foreach (Order order in orders)
        {
            order.GetPackingLabel();
            order.GetShippingLabel();
            order.CalcTotalPrice();
            Console.WriteLine("");
        }


    }
}