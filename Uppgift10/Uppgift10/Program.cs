using System.Formats.Asn1;

namespace Uppgift_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of rows to use: ");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns to use: ");
            int numberOfColumns = Convert.ToInt32(Console.ReadLine());

            char[,] grid = new char[numberOfRows, numberOfColumns];

            Random rand = new Random();
            int targetX = rand.Next(0, numberOfRows);
            int targetY = rand.Next(0, numberOfColumns);

            while (true)
            {
                for (int r = 0; r < grid.GetLength(0); r++)
                {
                    for (int c = 0; c < grid.GetLength(1); c++)
                    {
                        Console.Write(grid[r, c] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Enter the 'x' (0 - {numberOfRows}) coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the 'y' (0 - {numberOfColumns}) coordinate: ");
                int y = int.Parse(Console.ReadLine());


                if (x == targetX && y == targetY)
                {
                    Console.WriteLine("The shot was successful!");
                    break;
                }
                else
                {
                    grid[x, y] = '*';
                    Console.WriteLine("You missed!");
                }
            }
        }
    }
}
