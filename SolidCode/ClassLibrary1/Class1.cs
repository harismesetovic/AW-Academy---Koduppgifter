namespace ClassLibrary1
{
    public class Class1
    {
        public static int AddOne(int i)
        {
            return ++i;
        }

        public static string CleanUp(string message)
        {
            message = message.Trim();
            return $"{message.ToUpper().Substring(0, 1)}{message.ToLower().Substring(1)}";
        }
    }
}