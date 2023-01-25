namespace Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1.
            //int nummer = 1;
            //while (nummer <= 20)
            //{
            //    Console.WriteLine(nummer++);
            //}

            //2.
            //Console.WriteLine("Var vänlig och mata in ett tal mellan 1 - 100");

            //try
            //{
            //int nummer = int.Parse(Console.ReadLine());
            //    while (nummer <= 100)
            //    {
            //        if (nummer < 0)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(nummer++);
            //    }

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Gör om gör rätt");
            //}



            //3.
            Console.WriteLine("Var vänlig och mata in ett tal mellan 1 - 100");
            try
            {
                int nummer = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine(nummer++);
                } while (nummer < 0 && nummer! > 100);

            }
            catch (FormatException)
            {

                Console.WriteLine("Vänligen ange en siffra");
            }
            catch (OverflowException)
            {

                Console.WriteLine("Vängligen ange ett mindre tal");
            }

        }
    }
}