namespace Delegater01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action carAction = Accelerate;
            carAction();

            carAction = Decelerate;
            carAction();

        }
            static void Accelerate()
            {
            Console.WriteLine("Vrooooooooooom!");
            }

            static void Decelerate()
            {
            Console.WriteLine("-150 000");
            }
    }
}