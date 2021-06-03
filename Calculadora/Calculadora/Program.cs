using System;
using CalculatorLibrary;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\r");

            Calculator calculator = new Calculator();

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Type a number:");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;

                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not a valid input. Type another: ");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Type another number:");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not a valid input. Type another: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("a - add");
                Console.WriteLine("s - subtract");
                Console.WriteLine("m - multiply");
                Console.WriteLine("d - divide");
                Console.WriteLine("Option:");

                string op = Console.ReadLine();

                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This opertion will result in a mathematical error. \n");
                    }

                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }

                catch (Exception e)
                {
                    Console.WriteLine("oh no! An exception occured trying to do the math. \n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");

                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            calculator.Finish();
            return;
        }
    }
}

    

