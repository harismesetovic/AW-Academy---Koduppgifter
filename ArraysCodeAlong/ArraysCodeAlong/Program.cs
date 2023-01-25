namespace ArraysCodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'd', 'b', 'a', 'e', 'c' };
            PrintCharArray(letters);
            //Sort(letters);
            NestedSort(letters);
            PrintCharArray(letters);
        }

        private static void NestedSort(char[] letters)
        {
            for (int i = 0; i < letters.Length - 1; i++)
            {
                int indexOfMinimumValue = i;

                for (int j = i + 1; j < letters.Length; j++)
                {
                    if (letters[j] < letters[indexOfMinimumValue])
                        indexOfMinimumValue= j;
                }

                if (i != indexOfMinimumValue)
                {
                    char temp = letters[i];
                    letters[i] = letters[indexOfMinimumValue];
                    letters[indexOfMinimumValue] = temp;
                }
            }
        }

        private static void PrintCharArray(char[] letters)
        {
            foreach (char letter in letters)
            {
                Console.WriteLine($"{letter} ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");
        }

        private static void Sort(char[] letters)
        {
            for (int index = 0;index < letters.Length -1; index++) 
            {
                int indexOfMinimumValue = GetIndexOfMinimumValue(letters, index);
                SwapChars(letters, index, indexOfMinimumValue);
            }
            
        }

        private static void SwapChars(char[] letters, int i, int indexOfMinimumValue)
        {
            char temp = letters[indexOfMinimumValue];
            letters[indexOfMinimumValue] = letters[i];
            letters[i] = temp;
        }

        private static int GetIndexOfMinimumValue(char[] letters, int startIndex)
        {
            int minIndex = startIndex; //Assume the minimum value is at index minIndex

            for (int i = startIndex + 1; i < letters.Length; i++)
            {
                if (letters[i] < letters[minIndex])
                {
                    minIndex= i;
                }
            }
            return minIndex;
        }
    }
}