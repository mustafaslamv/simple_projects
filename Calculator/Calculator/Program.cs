using System;
using System.Data;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int calcType;
            string loopC;

            do
            {
                Console.WriteLine("Simple Calculator app\nChoose your favorite calculator style");
                Console.WriteLine("\n1) Compute Expression\t\t2) Enter 2 numbers manually\nEnter '1' or '2'\n");

                calcType = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nStarting calculator {0}\n\n", calcType);

                string calculatorType = (calcType == 1) ? "Expression" : "Manual";
                Console.WriteLine($"You've chosen the {calculatorType} calculator.\n");

                if (calcType == 2)
                {
                    NormalCalc();
                }
                else if (calcType == 1)
                {
                    ExpCalc();
                }
                else
                {
                    Console.WriteLine("Enter 1 or 2 only!");
                }

                Console.WriteLine("more calculations? Enter 'Y' to continue, any key to exit");
                loopC = Console.ReadLine().ToUpper();
                if (loopC == "y" || loopC == "Y")
                {
                    Console.Clear();
                }
            } while (loopC == "Y");
        }

        public static void NormalCalc()
        {
            string loopC = "Y";
            while (loopC == "Y")
            {
                double a = 0, b = 0;
                string op;
                double result = 0;
                try
                {
                    Console.Write("Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter valid numbers only");
                    continue;
                }
                Console.WriteLine($"\na = {a}, b = {b}\nSelect operation\n\n*\t/\t+\t-\t%");
                op = Console.ReadLine();
                switch (op)
                {
                    case "*":
                        result = a * b; break;
                    case "/":
                        result = a / b; break;
                    case "+":
                        result = a + b; break;
                    case "-":
                        result = a - b; break;
                    case "%":
                        result = a % b; break;
                    default:
                        Console.WriteLine("Available operators (*, /, +, -, %) only!");
                        continue;
                }
                Console.WriteLine($"\n{a} {op} {b} = {result}");
                Console.WriteLine("Continue this calculator? Enter 'Y' or any key to exit");
                loopC = Console.ReadLine().ToUpper();
            }
        }

        public static void ExpCalc()
        {
            Console.WriteLine("Available Operators:");
            Console.WriteLine("+, -, *, /, %");

            string loopC = "Y";
            while (loopC == "Y")
            {
                Console.WriteLine("\nEnter your math expression: ");
                string exp = Console.ReadLine();
                try
                {
                    DataTable dt = new DataTable();
                    var result = dt.Compute(exp, "");
                    Console.WriteLine($"Result of ({exp}) is ({result})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine("Continue this calculator? Enter 'Y' or any key to exit");
                loopC = Console.ReadLine().ToUpper();
            }
        }
    }
}