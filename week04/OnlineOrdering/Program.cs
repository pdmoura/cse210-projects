using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Initializing the products for customer1   //cliente 1
        Product product1 = new Product("Laptop", 1410, 1450.99, 15);
        Product product2 = new Product("Smartphone", 2830, 599.99, 20);
        Product product3 = new Product("Headphones", 3330, 149.99, 15);

        //Initializing the products for customer2
        Product product4 = new Product("Tablet", 4532, 299.99, 150);
        Product product5 = new Product("Apple Smartwatch", 5021, 199.99, 80);
        Product product6 = new Product("CANON Camera", 6340, 450.00, 60);

        //Initializing the products for customer3        
        Product product7 = new Product("C270 HD WEBCAM", 0772, 194.59, 55);
        Product product8 = new Product("USB Samsung Charger", 0980, 23.65, 345);
        Product product9 = new Product("Iphone 15", 0002, 879.99, 1000);

        //Creating the lists of products for each Order
        List<Product> productsOrder1 = new List<Product> { product1, product2, product3 }; //cliente 1
        List<Product> productsOrder2 = new List<Product> { product4, product5, product6 };
        List<Product> productsOrder3 = new List<Product> { product7, product8, product9 };

        //Creating the 3 addresses, (one for each Customer)
        Address address1 = new Address("123 Main Street", "Provo", "UT", "USA");  //cliente 1
        Address address2 = new Address("2139 Auburn Ave", "Dayton", "OH", "USA");
        Address address3 = new Address("16388 Shibu Lane", "Shibuya", "Tokyo", "Japan");


        //Creating the three Customers, (one for each order)
        Customer customer1 = new Customer("Emmanuel Johnson", address1); //cliente 1
        Customer customer2 = new Customer("Peter Smith", address2);
        Customer customer3 = new Customer("Peter Smith", address3);

        //Initializing the two orders
        Order order1 = new Order(productsOrder1, customer1); //cliente 1
        Order order2 = new Order(productsOrder2, customer2);
        Order order3 = new Order(productsOrder3, customer3);

        //Create a list to store the two orders
        List<Order> orders = new List<Order> { order1, order2, order3 };

        int i = 1; //counter to display the order number
        foreach (Order order in orders)
        {
            Console.WriteLine("\n" + new string('-', 40) + "\n");
            Console.WriteLine($"Order N° {i}");
            order.GetPackingLabel();
            order.GetShippingLabel();
            Console.WriteLine($"Total Cost of the order: {order.CalcTotalPrice():F2}");
            i++;
        }


    }
}