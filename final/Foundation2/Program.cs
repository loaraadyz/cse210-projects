using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("#52 E Rimando Street, Ortiz", "Naguilian", "La Union", "Philippines");
        Customer customer1 = new Customer("Bong Villa", address1);
        List<Product> productsList1 = new List<Product>();

        Product product11 = new Product("Cotton buds", "CB01", 0.2, 2);
        Product product12 = new Product("Downy", "DF07", 2, 5);
        Product product13 = new Product("Fita", "FC02", 0.3, 10);

        productsList1.Add(product11);
        productsList1.Add(product12);
        productsList1.Add(product13);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("12 Lopez Jaena", "Sagay City", "Negros Occidental", "Philippines");
        Customer customer2 = new Customer("Perlita Tayacta", address2);
        List<Product> productsList2 = new List<Product>();

        Product product21 = new Product("Bluewater", "PP11", 3.2, 2);
        Product product22 = new Product("Softdrinks", "SR17", .99, 24);
        Product product23 = new Product("Piyaya", "BB52", 1.1, 20);

        productsList2.Add(product21);
        productsList2.Add(product22);
        productsList2.Add(product23);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("147 Nash Street", "Southfield", "Michigan", "USA");
        Customer customer3 = new Customer("David Rait", address3);
        List<Product> productsList3 = new List<Product>();

        Product product31 = new Product("Wireless Mouse", "PC200", 3.5, 1);
        Product product32 = new Product("Wireless Keyboard", "PC102", 52.1, 1);

        productsList3.Add(product31);
        productsList3.Add(product32);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}