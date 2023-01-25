namespace Uppgift8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] namn = new string[5];

            //Console.WriteLine("Vänligen mata in 5 namn: \n");
            //for (int i = 0; i < namn.Length; i++)
            //{
            //    namn[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Ange vilket index du vill byta ut (Mellan 0 - 4): ");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ange nytt namn: ");
            //string nyttNamn = Console.ReadLine();
            //namn[index] = nyttNamn;

            //for (int i = namn.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(namn[i]);
            //}


            Console.WriteLine("Hur många mätningar har gjorts?");
            int antal = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] weather = new int[antal];
            Console.WriteLine("Hur ser mätdatan ut på de angivna mätningarna?");

            for (int i = 0; i < weather.Length; i++)
            {
                weather[i] = int.Parse(Console.ReadLine());
                
            }
            Console.Clear();
            int sum = weather.Sum();
            for (int i = 0; i < weather.Length; i++)
            {
                Console.WriteLine(weather[i]);
            }
            Console.WriteLine($"Medeltemperaturen är {sum / weather.Length}");

        }
    }
}