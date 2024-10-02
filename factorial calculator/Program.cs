using System.Diagnostics.CodeAnalysis;

namespace factorial_calculator
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
            Console.Write("Enter a non-negative integer: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(n);
            Console.WriteLine($"The factorial of {n} is: {factorial}");
        }
        int CalculateFactorial(int n) {
            int sum = 1;
            for (int i = 1; i <= n; i++) {
                sum = sum * i;
            }
            return sum;
        }
    }
}
