using System.ComponentModel.Design;

namespace week3assignment
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
            Console.Write("Enter a positive interger: ");
            int n = int.Parse(Console.ReadLine());

            int sum = CalculateSum(n);

            Console.WriteLine($"The sum of natural numbers from 1 to {n} is {sum}");
        }

        int CalculateSum(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++) { 
                sum += i;
            }
            return sum;
        }
    }
}
