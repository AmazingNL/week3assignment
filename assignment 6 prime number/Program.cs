namespace assignment_6_prime_number
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
            Console.WriteLine("Enter a positive integer greater than 1: ");
            int number = int.Parse(Console.ReadLine());
            //bool prime = IsPrime(number);
            if (IsPrime(number)) {
                Console.WriteLine($"{number} is prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not prime number");
            }

        }
        bool IsPrime(int number) { 
            for (int i = number; i % 2 != 0 || i % 2 == 0; )
            {
                return true;
            }
            return false;
        }
    }
}
