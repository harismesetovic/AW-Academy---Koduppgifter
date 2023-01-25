namespace MerryMethodsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Första = sjävla klassen, namnet = instansen
            MethodBench methodBench = new MethodBench();
            int i = 0;
            do
            {
                methodBench.FirstMethod();
                i++;
            } while (i < 3);





            methodBench.SecondMethod("C# Now and Forever!\n");

            Console.Write("Skriv in något: ");
            string input = Console.ReadLine();
            methodBench.SecondMethod(input);





            Console.WriteLine("[U] to print in upper case, otherwise lower case: ");
            ConsoleKey choice;
            choice = Console.ReadKey(true).Key;
            bool isUpperCase = false;
            if (choice == ConsoleKey.U)
                isUpperCase = true;
            methodBench.ThirdMethod(input, isUpperCase);

            Console.WriteLine("\nVill du skrika eller viska?");
            bool shout = methodBench.FourthMethod();
            methodBench.ThirdMethod(input, shout);
            methodBench.ThirdMethod(input, methodBench.FourthMethod());

        }
    }
}