using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

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

        else if(Operation == "multiply")
        {
            int sum = Number1*Number2;
            Console.WriteLine($"Answer is {sum} ({Number1}x{Number2}={sum})"); 
        }

        else
        {
            int sum = Number1-Number2;
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
        int totalIncome = customerEarning * 50;

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


    public static int CalculateCakePrice(int sliceCount)
    {
        int calculatePrice = sliceCount * 40;

        if(sliceCount >= 6 )
        {
            calculatePrice = calculatePrice - 30;
            Console.WriteLine($"Price is {calculatePrice}");
        }

        else
        {
            Console.WriteLine($"Price is {calculatePrice}");
        }

        return calculatePrice;
    }

    public static int ProcessOrder(int basePrice, int tipAmount)
    {
        int totalSum = basePrice + tipAmount;

        if(tipAmount == 0 )
        {
            Console.WriteLine($"No tips, sorry");
            Console.WriteLine($"Total earning {totalSum}");
        }

        else
        {
            Console.WriteLine($"Your tip is {tipAmount}");
            Console.WriteLine($"Total earning {totalSum}");
        }

        return totalSum;
    }

    public static int MergeDessers(int item1Level, int item2Level)
    {
        if(item1Level == item2Level)
        {
            Console.WriteLine($"Successfully merged!");
            return item1Level + 1;
        }

        else
        {
            Console.WriteLine($"It cant be merged, different levels");
            return 0;
        }


    }

    public static string CheckGeceMood(int playTimeInMinutes)
    {
        if(playTimeInMinutes< 15)
        {
            Console.WriteLine($"Gece is unhappy, she is trying to enter the kitchen");
            return "angry";
        }

        else
        {
            Console.WriteLine($"Gece is happy! she is sleeping");
            return "happy";    
        }
    }

    public class Program
    {
        public static void Main()
        {
            string geceninDurumu = CheckGeceMood(30); 
            Console.WriteLine($"Sistemden gelen durum raporu: {geceninDurumu}");
        }

        public static string CheckGeceMood(int playTimeInMinutes)
        {
            if(playTimeInMinutes < 15)
            {
                Console.WriteLine("Gece is unhappy, she is trying to enter the kitchen");
                return "angry";
            }
            else
            {
                Console.WriteLine("Gece is happy! she is sleeping");
                return "happy";
            }
        }
        public static void BananaBread(int breadCount)
        {
            for(int i = 1; i <= breadCount; i++)
            {
                Console.WriteLine($"BananaBread {i} is going to the oven...");
            }

            Console.WriteLine("All banana breads are in the cooking stage");
            
        }

        public static void ServeCoffee(int coffeeStock)
        {
        while(coffeeStock > 0)
        {
            Console.WriteLine($"Coffee service is closed! Current stock is: {coffeeStock}");
            coffeeStock--;       
        }     

        Console.WriteLine(">Coffee is finished, brewing a new one...");
        } 

        public static void ShowMenu(string[] Desserts)
        {
           for (int i= 0; i< Desserts.Length; i++)
           {
              Console.WriteLine($"Dessert {i}: {Desserts[i]}");  
           } 
        }

        public class Visitor
        {
            public string name;
            public string gender;

            public virtual void IntroduceYourself()
            {
                Console.WriteLine($"Hi, I am {name} and I am a {gender}!");
            }
        }
        public class VIPVisitor : Visitor
        {
          public int extraTip = 50;

        }

        public class CatVisitor : Visitor
        {
            public override void IntroduceYourself()
            {
                Console.WriteLine($"Meow! I am {name}");
            }
        }


        public class Program
        {
            public static void Main()
            {
                VIPVisitor first = new VIPVisitor();
                CatVisitor second = new CatVisitor();

                first.name = "Gokce";
                first.gender = "Girl";
                second.name = "Gece";
                second.gender = "girl cat";

                first.IntroduceYourself();
                second.IntroduceYourself();

            }
        }

        public class EnergyLevel
        {
            private int energy = 50;

            public void SpentEnergy(int amount)
            {
                if(energy >= amount)
                {
                    energy -= amount;
                    Console.WriteLine($"New energy Level is {energy}");
                }

                else
                {
                    Console.WriteLine($"Not enough emergy! Your energy level is {energy}");
                }

            }
        }

        public class FeedingMachine
        {
            public void SpecialFeeding(int amount)
            {
                Console.WriteLine($"{amount} food given to gece");
            }
        }

        public class Program
        {
            public static void Main()
            {
                FeedingMachine machine = new FeedingMachine();

                machine.SpecialFeeding(3);

                machine.SpecialFeeding(5);
            }
        }

        public class CoffeMachine
        {
            public void SpecialCoffee(string customerName, string cofffeSpecialty)
            {
                Console.WriteLine($"Order is ready {customerName}, take your {cofffeSpecialty}");
            }

            public static void Main()
            {
                CoffeMachine order = new CoffeMachine();
                order.SpecialCoffee("Gokce", "caramel machiato");
                
            }
        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Welcome to DOT1002, {name}!");
        }

        public static void Main()
        {
            GreetUser("Freeman");
        }

        public static double CalculateArea(double radius , double pivalue= 3.14)
        {
            return pivalue * radius * radius;   
        }

        public static void Main()
        {
            double area = CalculateArea(5);
            Console.WriteLine($"Area: {area}");
        }

        public static bool IsValidPassword(string password)
        {
            if(password.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            bool result = IsValidPassword("123456");
            Console.WriteLine($"Is Password Valid? {result}");
        }

        public static bool MergeDeserts(int playerLevel, int LevelNeeded)
        {
            if(playerLevel >= LevelNeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            bool result = MergeDeserts(5, 8);
            Console.WriteLine($"Operation is {result}");
        }



}
        








}




