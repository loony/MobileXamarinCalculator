using System;

namespace Calculator
{
    public delegate double OperatorDelegater(double one, double two);

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Calculator();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                throw;
            }
        }

        private static void Calculator()
        {
            PrintChoseOperationToConsole();

            var calculationMethodChosen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your first number");
            var userInputNumberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            var userInputNumberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calculating...");

            CalculationMethodChosen(calculationMethodChosen, userInputNumberOne, userInputNumberTwo);

            Console.WriteLine("Restart? Press any Key on your keyboard");
            Console.ReadKey();
        }

        private static void PrintChoseOperationToConsole()
        {
            Console.WriteLine("choose operation");
            Console.WriteLine("1 = Addition");
            Console.WriteLine("2 = Subtraction");
        }

        private static void CalculationMethodChosen(double input, double userInputNumberOne, double userInputNumberTwo)
        {
            switch (input)
            {
                case 1:
                    OperatorDelegater addition = Operator.Addition;
                    Console.WriteLine(addition(userInputNumberOne, userInputNumberTwo));
                    break;
                case 2:
                    OperatorDelegater subtraction = Operator.Subtract;
                    Console.WriteLine(subtraction(userInputNumberOne, userInputNumberTwo));
                    break;
                default:
                    Console.WriteLine("Restart. It wasn't chosen 1 or 2 for input.");
                    Calculator();
                    break;
            }
        }
    }
}
