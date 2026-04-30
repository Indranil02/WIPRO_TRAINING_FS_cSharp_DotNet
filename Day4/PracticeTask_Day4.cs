using System;
using System.Collections.Generic;

class Customer // customer class to store customer details
{
    public int Id;
    public string Name;
}

class Order   // order class to store order details
{
    public int Id, CustomerId;
    public string Category;
    public decimal Amount;
}

class Program
{
    static List<Order> orders = new List<Order>();   // list to store all orders
    static Dictionary<int, Customer> customers = new Dictionary<int, Customer>();   // dictionary to map id to object

    static int ReadInt(string msg)
    {
        int x;
        Console.Write(msg);
        while (!int.TryParse(Console.ReadLine(), out x))
            Console.Write("Invalid! " + msg);
        return x;
    }

    static decimal ReadAmount(string msg)
    {
        decimal x;
        Console.Write(msg);
        while (!decimal.TryParse(Console.ReadLine(), out x))
            Console.Write("Invalid! " + msg);
        return x;
    }

    static void AddCustomer()    //add a new customer
    {
        int id = ReadInt("Customer ID: ");
        Console.Write("Name: ");
        customers[id] = new Customer { Id = id, Name = Console.ReadLine() };
        Console.WriteLine("Customer added!");
    }

    static void AddOrder()     // add a new order
    {
        int id = ReadInt("Order ID: ");
        int cid = ReadInt("Customer ID: ");

        if (!customers.ContainsKey(cid))
        {
            Console.WriteLine("Customer not found!");
            return;
        }

        Console.Write("Category: ");
        string cat = Console.ReadLine();
        decimal amt = ReadAmount("Amount: ");

        orders.Add(new Order { Id = id, CustomerId = cid, Category = cat, Amount = amt });

        Console.WriteLine("Order added!");
        ShowSummary();
    }

    static void ShowOrders()   // display all orders
    {
        foreach (var o in orders)
        {
            Console.WriteLine($"Order:{o.Id}, Customer:{customers[o.CustomerId].Name}, Amt:{o.Amount}");
        }
    }

    static void ShowSummary()
    {
        decimal total = 0;
        foreach (var o in orders) total += o.Amount;

        Console.WriteLine("\n--- SUMMARY ---");
        Console.WriteLine("Customers: " + customers.Count);
        Console.WriteLine("Orders: " + orders.Count);
        Console.WriteLine("Revenue: " + total);
        Console.WriteLine("----------------\n");
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Add Customer 2.Add Order 3.Show Orders 4.Exit");
            int ch = ReadInt("Choice: ");

            switch (ch)
            {
                case 1: AddCustomer(); break;
                case 2: AddOrder(); break;
                case 3: ShowOrders(); break;
                case 4: return;
            }
        }
    }
}
