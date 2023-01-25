namespace Uppgift12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> contactList = new List<Person>();

            contactList.Add(new Person { FirstName = "Haris", PhoneNumber = "070-1234567", Email = "haris@test.com" });

            while (true)
            {
                WelcomeMenu();
                ConsoleKey choice = GetMenuChoice();
                switch (choice)
                {
                    case ConsoleKey.A:
                        AddPerson(contactList);
                        break;
                    case ConsoleKey.R:
                        RemovePerson(contactList);
                        break;
                    case ConsoleKey.V:
                        ShowList(contactList);
                        break;
                    case ConsoleKey.E:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Input is not recognized, please see the options above");
                        break;
                        Console.Clear();
                        break;
                }
            }

        }

        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Press any key to exit...");
        }

        private static ConsoleKey GetMenuChoice()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.Clear();
            return cki.Key;
        }

        private static void WelcomeMenu()
        {
            Console.WriteLine("Welcome to the contact list!");
            Console.WriteLine();
            Console.WriteLine("To add a person press 'A'");
            Console.WriteLine("To remove a person press 'R'");
            Console.WriteLine("To view the contact list press 'V'");
            Console.WriteLine("To exit, press 'E'");
            Console.Write("Input: ");
        }

        private static void ShowList(List<Person> contactList)
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("Name: " + contact.FirstName);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);
                Console.WriteLine("------------------------");
            }
        }

        private static void RemovePerson(List<Person> contactList)
        {
            Console.Clear();
            ShowList(contactList);
            Console.WriteLine("Fill the form below to remove person from the contact list.");
            Console.Write("Enter the name of the person you want removed: ");
            string firstName = Console.ReadLine();
            Console.Clear();
            Person removePerson = contactList.Find(x => x.FirstName == firstName);

            if (removePerson != null)
            {
                contactList.Remove(removePerson);
                Console.WriteLine("The person has been removed from the contact list.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry but we could not find the person in the contact list.");
            }
        }

        private static void AddPerson(List<Person> contactList)
        {
            Console.WriteLine("Fill the form below to add a new person to the contact list.");
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter the email: ");
            string email = Console.ReadLine();
            Console.Clear();
            contactList.Add(new Person { FirstName = firstName, PhoneNumber = phoneNumber, Email = email });
            Console.WriteLine("Person has been added to the contact list, press 'V' to view!");
            Console.WriteLine();
        }
    }
}