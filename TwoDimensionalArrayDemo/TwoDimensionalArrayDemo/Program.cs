namespace TwoDimensionalArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = new int[3]; One dimensional array
            int[,] chessBoard = new int[8, 8]; //Two dimensional array 
            InitializeTwoDimArray(chessBoard);
            DisplayTwoDimArray(chessBoard);
        }

        private static void DisplayTwoDimArray(int[,] chessBoard)
        {
            for (int y = 0; y < chessBoard.GetLength(1); y++)
            {
                for (int x = 0; x < chessBoard.GetLength(0); x++)
                {
                    Console.Write($"{chessBoard[x, y].ToString().PadLeft(2)} ");
                }
            }
        }

        private static void InitializeTwoDimArray(int[,] ints)
        {
            int count = 0;

            for (int y = 0; y < ints.GetLength(1); y++)
            {
                for (int x = 0; x < ints.GetLength(0); x++)
                {
                    //Console.Write($"{count++.ToString().PadLeft(2)} ");
                    ints[x, y] = count++;
                }

            }
        }
    }
}