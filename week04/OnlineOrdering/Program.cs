using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Customer 1

        // Customer object
        Customer customerName = new Customer("Jerry Flin");

        // Address object
        Address address = new Address("Pole 9 Street", "Port of Spain", "Arima", "England");
         
        // Order object
        Order customerOrder = new Order("US-UV-T12345", "EN-AH-N19875");

        // Products object
        Products productInfo = new Products("Keyboard", 1234, 25.25, 2, 35);
        Products productInfo2 = new Products("Laptop", 5432, 450.00, 5, 35);

        // Adding products to products list
        List<Products> allProducts = new List<Products>();
        allProducts.Add(productInfo);
        allProducts.Add(productInfo2);
        
        // Adding address to address list
        List<Address> customerAddress = new List<Address>();
        customerAddress.Add(address);
        
        // Adding order to order list
        List<Order> labels = new List<Order>();
        labels.Add(customerOrder);

        // Adding customer to customer list
        List<Customer> firstCustomer = new List<Customer>();
        firstCustomer.Add(customerName);

        foreach(Products products in allProducts)
        {
            foreach(Customer customer in firstCustomer)
            {
                customer.GetCustomerName();
            }

             foreach(Address addressOne in customerAddress)
             {
                address.GetFullAddress();
             
             }

             foreach(Order order in labels)
            {
                Console.WriteLine(order.PackingLabel());
                Console.WriteLine(order.ShippingLabel());
            }

             Console.WriteLine(products.Display());
             Console.WriteLine($"Quantity Ordered: {products.DisplayQuantity()}");
             Console.WriteLine($"Price for 1: {products.DisplayPrice()}");
             products.ShippingFee();
             Console.WriteLine($"Total Price: {products.DisplayTotalCost()}");
             Console.WriteLine();
        }

        //Customer 2

        // Customer object
        Customer customerName2 = new Customer("James Smith");
        
        // Address object
        Address address2 = new Address("18th Street", "Seattle", "Washingthon", "USA");

        // Order object
        Order customerOrder2 = new Order("US-PK-G23976", "CA-NB-A54782");

        // Products object
        Products productInfo3 = new Products("Giant Water Filter", 9843, 1200.25, 8, 5);
        Products productInfo4 = new Products("Ergonomic Office Chairs", 2512, 800.00, 20, 5);

        // Adding products to products list
        List<Products> allProducts2 = new List<Products>();
        allProducts2.Add(productInfo3);
        allProducts2.Add(productInfo4);
        
        // Adding address to address list
        List<Address> customerAddress2 = new List<Address>();
        customerAddress2.Add(address2);
        
        // Adding order to order list
        List<Order> labels2 = new List<Order>();
        labels2.Add(customerOrder2);

        // Adding customer to customer list
        List<Customer> secondCustomer = new List<Customer>();
        secondCustomer.Add(customerName2);

        foreach(Products products2 in allProducts2)
        {
            foreach(Customer customer2 in secondCustomer)
            {
                customer2.GetCustomerName();
            }
             foreach(Address location in customerAddress2)
             {
                location.GetFullAddress();
                break;
             }

             foreach(Order order2 in labels2)
            {
                Console.WriteLine(order2.PackingLabel());
                Console.WriteLine(order2.ShippingLabel());
            }

             Console.WriteLine(products2.Display());
             Console.WriteLine($"Quantity Ordered: {products2.DisplayQuantity()}");
             Console.WriteLine($"Price for 1: {products2.DisplayPrice()}");
             products2.ShippingFee();
             Console.WriteLine($"Total Price: {products2.DisplayTotalCost()}");
             Console.WriteLine();
        }
        
    }
}