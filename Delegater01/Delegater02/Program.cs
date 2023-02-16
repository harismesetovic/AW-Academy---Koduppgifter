namespace Delegater02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> isT = PrintIt;
            isT("abc", true);
        }
            static void PrintIt(string abc, bool isTrue)
            {
            if (isTrue)
                Console.WriteLine(abc.ToUpper());
            else
                Console.WriteLine(abc.ToLower());
            }
    }
}