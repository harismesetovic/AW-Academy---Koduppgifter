namespace DemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo= new DemoClass();
            demo.PublicMethod();
            DemoClass.StaticMethod();
            demo.NonStaticMethod();

            var rounded = Math.Round(3.123456);

            Car myCar = new Car();
            myCar.LicenseNumber = "KRJ137";

            Car yourCar = new Car();
            yourCar.LicenseNumber = "ABC123";

            Static_NonStatic.StaticMethod();
            Static_NonStatic static_NonStatic = new Static_NonStatic();
            static_NonStatic.NonStaticMethod();
        }
    }
}