namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Alt 1: Named method
            FileFinder.Find(folderPath, MyTextFilter);
            Console.WriteLine();

            // Alt 2: Lambda anonymous method
            FileFinder.Find(folderPath, f => Path.GetExtension(f).ToLower() == ".txt");
        }

        static bool MyTextFilter(string filePath)
        {
            return Path.GetExtension(filePath).ToLower() == ".txt";
        }
    }
}