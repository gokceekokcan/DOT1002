using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

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

    public void DepthCheck()
    {
        int depth = 55;
        int Oxygen = 15;

        if(depth > 50 || Oxygen < 10)
        {
            Console.WriteLine($"emergency!!!");
        }

        else if (depth > 30 && Oxygen < 20)
        {
            Console.WriteLine($"Danger!Low oxygen in deep water");
        }

        else
        {
            Console.WriteLine($"Depth is safe, Enjoy the diving");
        }
    }

    public void AskName()
    {
        Console.WriteLine("What is your Name?");
        string Name = Console.ReadLine();

        Console.WriteLine($"Hello {Name}");
    }

    public void Exuation()
    {
        Console.WriteLine(" Enter first number: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter second number: ");
        int Number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Number1 + Number2);

    }

    public void Example()
    {
        Console.WriteLine(" Enter first number: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter second number: ");
        int Number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter operation: ");
        string Operation = Console.ReadLine();

        if(Operation == "add")
        {
            int sum =Number1+Number2;
            Console.WriteLine($"Answer is {sum} ({Number1}+{Number2}={sum})");
        }

        elseif(Operation == "multiply");
        {
            int sum == Number1*Number2;
            Console.WriteLine($"Answer is {sum} ({Number1}x{Number2}={sum})"); 
        }

        else
        {
            int sum == Number1-Number2;
            Console.WriteLine($"Answer is {Number1}-{Number2}={sum}");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Welcome to DOT1002 {name}");
    }

    public void CalculateIncome(int customerCount)
    {
        int totalIncome = customerCount * 50;

        if(totalIncome >= 500)
        {
            Console.WriteLine($"Amazing! your total earning is {totalIncome} TL");
        }

        else
        {
            Console.WriteLine($"Not a perfect day, your total earning is {totalIncome}");
        }

    }

    public static int CalculateEarnings(int customerEarning)
    {
        int totalIncome = customerEarning * 50

        if(totalIncome >= 500)
        {
            Console.WriteLine($"Amazing! your total earning is {totalIncome} TL");
        }
        
        else
        {
            Console.WriteLine($"Not a perfect day, your total earning is {totalIncome} TL");
        }

        return totalIncome;
    
    }


    




}

