using System.Formats.Asn1;

namespace Uppgift_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] grid = CreateEmptyGrid();
            int[] targetCoords = RandomTarget();
            while (true)
            {
                DisplayGrid(grid);
                int[] inputCoordinates = GetUserCoordinates();
                if (inputCoordinates[0] == targetCoords[0] && inputCoordinates[1] == targetCoords[1])
                {
                    Console.WriteLine("The shot was successful!");
                    Console.Write("Do you want to play again? Y/N: ");
                    ConsoleKey choice = Console.ReadKey(true).Key;
                    if (choice == ConsoleKey.Y)
                    {
                        Console.Clear();
                        CreateEmptyGrid();
                        RandomTarget();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    grid[inputCoordinates[0] - 1, inputCoordinates[1] - 1] = '*';
                    Console.WriteLine("You missed!");
                }
            }
        }

        private static int[] GetUserCoordinates()
        {
            Console.WriteLine($"Enter the 'x' (1 - 4) coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the 'y' (1 - 4) coordinate: ");
            int y = int.Parse(Console.ReadLine());
            Console.Clear();
            return new int[] {x, y};
        }

        private static void DisplayGrid(char[,] grid)
        {
            Console.WriteLine("  1 2 3 4");
            Console.WriteLine(" ---------");
            for (int r = 0; r < grid.GetLength(0); r++)
            {
                Console.Write((r + 1) + "|");
                for (int c = 0; c < grid.GetLength(1); c++)
                {
                    Console.Write(grid[r, c] + "|");
                }
                Console.WriteLine();
                Console.WriteLine(" ---------");
            }
        }

        private static int[] RandomTarget()
        {
            Random rand = new Random();
            int targetX = rand.Next(1, 5);
            int targetY = rand.Next(1, 5);
            return new int[] {targetX, targetY};
        }

        private static char[,] CreateEmptyGrid()
        {
            char[,] grid = new char[4, 4];

            for (int r = 0; r < grid.GetLength(0); r++)
            {
                for (int c = 0; c < grid.GetLength(1); c++)
                {
                    grid[r, c] = '~';
                }
            }
            return grid;
        }
    }
}
