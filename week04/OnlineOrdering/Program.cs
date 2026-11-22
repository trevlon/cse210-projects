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

        Order orderList = new Order(customer, product, "US-UV-T12345", "EN-AH-N19875");
        Order orderList2 = new Order(customer, product2, "US-UV-T12345", "EN-AH-N19875");
        orderList.DisplayAll();
        Console.WriteLine();
        orderList2.DisplayAll();
        Console.WriteLine();

        // Customer 2
        Product product3 = new Product("Giant Water Filter", "9843", 1200.25, 8);
        Product product4 = new Product("Ergonomic Office Chairs", "2512", 800.00, 20);

        Address address1 = new Address("18th Street", "Seattle", "Washingthon", "USA");

        Customer customer1 = new Customer("James Smith", address1);

        Order orderList3 = new Order(customer1, product3, "US-PK-G23976", "US-NB-A54782");
        Order orderList4 = new Order(customer1, product4, "US-PK-G23976", "US-NB-A54782");
        orderList3.DisplayAll();
        Console.WriteLine();
        orderList4.DisplayAll();

    }
}