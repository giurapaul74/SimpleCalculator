using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            

            while (true)
            {
                //Console.WriteLine("Which operation would you like to do?");
                Console.WriteLine("Press 1 for Addition.");
                Console.WriteLine("Press 2 for Subtraction.");
                Console.WriteLine("Press 3 for Multiplication.");
                Console.WriteLine("Press 4 for Divide.");
                Console.WriteLine("Press 5 to quit.");

                var option = Console.ReadLine();

                if (option == "5")
                {
                    break;
                }

                Console.WriteLine("Enter first input: ");
                var input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second input: ");
                var input2 = int.Parse(Console.ReadLine());
                var result = 0;

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Addition.");
                        result = calculator.Addition(input1, input2);
                        break;
                    case "2":
                        Console.WriteLine("Subtraction.");
                        result = calculator.Subtraction(input1, input2);
                        break;
                    case "3":
                        Console.WriteLine("Multiplication.");
                        result = calculator.Multiplication(input1, input2);
                        break;
                    case "4":
                        Console.WriteLine("Division.");
                        result = calculator.Divide(input1, input2);
                        break;
                    default:
                        Console.WriteLine("Wrong input. Try again.");
                        break;
                }

                Console.WriteLine($"Your result is {result}");
                Console.WriteLine();
                Console.WriteLine("Choose your operation.");
            }

        }
    }
}
