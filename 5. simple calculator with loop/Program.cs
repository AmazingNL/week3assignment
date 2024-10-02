using System.ComponentModel;

namespace _5._simple_calculator_with_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            DisplayMenu();
            PerformCalculation();

        }
        int Add(int a, int b)
        {
            return a + b;
        }
        int Subtract(int a, int b)
        {
            return a - b;
        }
        int Multiply(int a, int b)
        {
            return a * b;
        }
        double Divide(int a, int b)
        {
            return a / b;
        }
        void DisplayMenu()
        {
            Console.WriteLine("Simple Calculator Menu:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
        }
        void PerformCalculation()
        {
            for (int i = 1; i <= 4; i--)
            {
                Console.Write("Enter your choice from (1-5): ");
                i = int.Parse(Console.ReadLine());
                if (i == 5) {
                    break;
                }

                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                switch (i) { 
                    case 1: Console.WriteLine(Add(a,b)); break;
                    case 2: Console.WriteLine(Subtract(a,b)); break;
                    case 3: Console.WriteLine(Multiply(a,b)); break;
                    case 4: Console.WriteLine(Divide(a,b)); break;
                    default: Console.WriteLine("Input Not valid"); break;
                }
            }
            Console.WriteLine("Calculator Exited.");
            Console.ReadKey();
        }
    }
}
