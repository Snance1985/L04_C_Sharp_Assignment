class Program
{
     void Main()
    {
        try
        {
            int num1, num2;

            Console.WriteLine("Enter the first number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Your Option (1-4):\n" +
                "1. Add\n" +
                "2. Multiply\n" +
                "3. Odd / Even\n" +
                "4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addNumbers(num1, num2);
                    break;
                case 2:
                    multiplyNumbers(num1, num2);
                    break;
                case 3:
                    oddOrEven(num1, num2);
                    break;
                default:
                    Console.WriteLine("Exiting the program.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input. The number is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    void addNumbers(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);
    }

    void multiplyNumbers(int num1, int num2)
    {
        int product = num1 * num2;
        Console.WriteLine("The product of {0} and {1} is {2}.", num1, num2, product);
    }

    static void oddOrEven(int num1, int num2)
    {
        string num1Type = num1 % 2 == 0 ? "even" : "odd";
        string num2Type = num2 % 2 == 0 ? "even" : "odd";

        Console.WriteLine("The first number ({0}) is {1}.", num1, num1Type);
        Console.WriteLine("The second number ({0}) is {1}.", num2, num2Type);
    }
}