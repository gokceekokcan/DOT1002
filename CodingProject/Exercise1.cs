public class Exercise1
{
    public static void PrintUsersName()
    {
        Console.WriteLine("What is your name?");
        string username = Console.ReadLine();
        Console.WriteLine($"Hello {username}");
    }

    public static void PrintAddResult()
    {
        Console.WriteLine("Write First Number");
        int first = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Write second number");
        int second = Convert.ToInt16(Console.ReadLine());
        int sum = first+second;
        Console.WriteLine(sum);

    }

    public static void PrintOperationResult()
    {
        Console.WriteLine("Write First Number");
        int First = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Write Second Number");
        int Second = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Select an operation");
        string operation = Console.ReadLine();

        int result = 0;
        if(operation == "add")
        {
            result = First + Second;
        }
        else if (operation == "multiply")
        {
            result = First * Second;
        }
        else if (operation == "subtract")
        {
            result = First - Second;
        }
        Console.WriteLine($"Answer Is {result}");

    }


}
