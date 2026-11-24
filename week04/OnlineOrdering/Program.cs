using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        // Customer 1
        Product product = new Product("Keyboard", "1234", 25.25, 2);
        Product product2 = new Product("Laptop", "5432", 450.00, 5);
        // Console.WriteLine(product.DisplayProduct());
        // Console.WriteLine(product.GetTotalCost());

        Address address = new Address("Pole 9 Street", "Port of Spain", "Arima", "England");
        // Console.WriteLine(address.DisplayAddress());
          
        Customer customer = new Customer("Jerry Flin", address);
        // Console.WriteLine(customer.DisplayCustomer());

        List<Product> productList = new List<Product>();
        productList.Add(product);
        productList.Add(product2);
    
        // Order orderList = new Order(customer, productList, "US-UV-T12345", "EN-AH-N19875");
        Order orderList = new Order(customer, productList);
        orderList.DisplayAll();
        Console.WriteLine();
        Console.WriteLine(orderList.PackingLabel());
        Console.WriteLine(orderList.ShippingLabel());

        // Customer 2
        Product product3 = new Product("Giant Water Filter", "9843", 1200.25, 8);
        Product product4 = new Product("Ergonomic Office Chairs", "2512", 800.00, 20);

        Address address2 = new Address("18th Street", "Seattle", "Washingthon", "USA");

        Customer customer2 = new Customer("James Smith", address2);

        List<Product> productList2 = new List<Product>();
        productList2.Add(product3);
        productList2.Add(product4);

        Order orderList2 = new Order(customer2, productList2);
        orderList2.DisplayAll();
        Console.WriteLine();
        Console.WriteLine(orderList2.PackingLabel());
        Console.WriteLine(orderList2.ShippingLabel());
    }
}