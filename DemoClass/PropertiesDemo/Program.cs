namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit banana = new Fruit();
            Console.Write("Ange frukten vikt: ");
            double weight = double.Parse(Console.ReadLine());
            
            if(weight <0.1 || weight >0.5)
                Console.WriteLine("Wtf?!");
            else
            {
                banana.SetWeight(weight);
                Console.WriteLine($"Fruktens vikt är {banana.GetWeight()} kg");
            }



            //    banana.SetWeight(double.Parse(Console.ReadLine()));
            //catch (ArgumentOutOfRangeException)


        }
    }
}