using System;
using System.Collections.Generic;

public class Cafe
{
    public void ShowOrders()
    {
        List<string> orders = new List<string>();
        orders.Add("Latte");
        orders.Add("Americano");
        orders.Add("Tea");

        foreach(string item in orders)
        {
        Console.WriteLine(item);    
        }
        
        
    }

     public void OrderList()
    {
        List<string> orders = new List<string>();
        orders.Add("Latte");
        orders.Add("Americano");
        orders.Add("Tea");

        foreach(string item in orders)
        {
        Console.WriteLine($"{item} hazırlanıyor...");    
        }
        
        
    }

    public void DiveCounter()
    {
        for(int i = 10; i <= 50; i += 10)
        {
           Console.WriteLine($"{i} . meters deep"); 
        }
    }

    public void BuyCoffee()
    {
        int money = 50;
        int coffee = 40;

        if(money >= coffee)
        {
            Console.WriteLine($"Coffee is coming");
        }

        else
        {
            Console.WriteLine($"Unfortunately");
        }
    }
}

