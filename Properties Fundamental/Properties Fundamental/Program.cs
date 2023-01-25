namespace Properties_Fundamental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car[] carArray = new Car[100];

            while (true)
            {
                Console.WriteLine("Do you want to add a new car?: Y/N");
                ConsoleKey choice = Console.ReadKey(true).Key;
                if (choice == ConsoleKey.Y)
                    AddCar(carArray);
                else
                    break;
            }
            Console.WriteLine();
            PrintAllCars(carArray);

            //myCar.SetLicenseNumber("ABC123");
            //myCar.SetColor("Green");

            //Console.WriteLine($"The car has the license number '{myCar.GetLicenseNumber()}' and the color of the car is '{myCar.GetColor()}'.");

            //myCar.LicenseNumber = "abc123";
            //Console.WriteLine($"License number: {myCar.LicenseNumber}");
            //myCar.Color = "green".ToLower();
            //Console.WriteLine($"Color: {myCar.Color}");

        }

        private static void PrintAllCars(Car[] carArray)
        {
            foreach (var item in carArray)
            {
                if (item != null)
                {
                    Console.WriteLine($"License: {item.LicenseNumber}, Color: {item.Color}");
                }
            }
        }

        private static Car[] AddCar(Car[] _carArray)
        {
            Console.WriteLine();
            Console.Write("Input the license number of the car (3 letters followed by 3 numbers): ");
            string inputLicense = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Input the color of the car (Only red, green, blue & yellow available): ");
            string inputColor = Console.ReadLine();

            Car newCar = new Car();
            newCar.LicenseNumber = inputLicense;
            newCar.Color = inputColor;
            int nextIndex = Array.IndexOf(_carArray, null); //Letar efter nästa lediga plats

            _carArray[nextIndex] = newCar;

            return _carArray;
        }
    }
}