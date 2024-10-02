using System.Xml.Linq;

namespace _8._avarage_calculator
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
            Console.Write("Enter the number of element: ");
            int count = int.Parse(Console.ReadLine());;
            int sum = CalculateSum(count);
            double average = CalculateAverage(sum, count);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
        }

        int CalculateSum(int count)
        {
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return sum;
        }

        double CalculateAverage(int sum, int count) { 
            double average = sum / (double)count;
            return average;
        }

    }
}
