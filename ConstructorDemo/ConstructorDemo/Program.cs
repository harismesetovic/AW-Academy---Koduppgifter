namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit pear = new Fruit("Williams", 0.25);
            Console.WriteLine(pear.Weight);

            Garden garden= new Garden("Bergianska");
            Console.WriteLine($"The name of your garden is {garden.GardenName}");
        }
    }
}