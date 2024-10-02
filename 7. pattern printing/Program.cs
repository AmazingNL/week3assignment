namespace _7._pattern_printing
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
            Console.WriteLine("Enter Dimension size: ");
            int dimensionSize = int.Parse(Console.ReadLine());
            PrintSquare(dimensionSize);
        }
        void PrintSquare(int dimensionSize)
        {
            for (int i = 0; i < dimensionSize; i++)
            {
                for (int j = 0; j < dimensionSize; j++)
                {
                    if (i == 0 || i == dimensionSize - 1 || j == 0 || j == dimensionSize - 1)
                    {
                        Console.Write("x");
                    }
                    else { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
