namespace DiverseDemo
{
    internal class Program
    {
        const string filePath = @"C:\Users\haris\Downloads\Test\namnsdagar.txt";

        static void Main(string[] args)
        {
            //Ternary demo
            int x;
            int y = 10;

            //if (y < 10)
            //{
            //    x = 1;
            //    else
            //    {
            //        x = 2;
            //    }
            //}

            x = y < 10 ? 1 : 2; //Ternary expression
            string name = "Haris";

            string str = name.Length > 5 ? "Långt namn" : "Kort namn";
            //Console.WriteLine(str);

            if (name.Length > 5)
                str = "Långt namn";
            else
                str = "Kort namn";

            int antalParkeradeBilar = 3;
            //string message = $"Det finns {antalParkeradeBilar} parkerad bil i garaget.";
            //message = $"Det finns {antalParkeradeBilar} parkerade bilar i garaget.";

            string message = $"Det finns {antalParkeradeBilar} {(antalParkeradeBilar == 1 ? "parkerad bil" : "parkerade bilar")} i garaget.";
            //Console.WriteLine(message);
            message = message.Trim(); //Use the intellisense!!!


            //Split demo
            string[] words = message.Split(' ');
            //Console.WriteLine($"Strängen innehåller {words.Length} ord.");


            //File I/O
            string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine(fileContent);

            string[] lines = File.ReadAllLines(filePath);
            List<NameDay> nameDays = new List<NameDay>();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                NameDay nameDay = new NameDay();
                string[] data = line.Split(';');
                nameDay.Name = data[1];
                nameDay.Date = DateTime.Parse(data[0]);
                nameDays.Add(nameDay);
            }

            foreach (NameDay item in nameDays)
            {
                Console.WriteLine($"{item.Name} {item.Date}");
            }


        }
    }
}