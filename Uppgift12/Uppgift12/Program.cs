namespace Uppgift12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> contactList = new List<Person>();

            contactList.Add(new Person { FirstName = "Haris", PhoneNumber = "070-1234567", Email = "haris@test.com", HomeAddress = "Abcvägen 55", WorkAddress = "Abcgatan 55" });
            contactList.Add(new Person { FirstName = "Albert", PhoneNumber = "070-1234567", Email = "Albert@test.com", HomeAddress = "Defvägen 55", WorkAddress = "Defgatan 55" });
            contactList.Add(new Person { FirstName = "Johan", PhoneNumber = "070-1234567", Email = "Johan@test.com", HomeAddress = "Ghivägen 55", WorkAddress = "Ghigatan 55" });

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
                    case ConsoleKey.C:
                        changeInformation(contactList);
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

        private static void changeInformation(List<Person> contactList)
        {
            Console.Clear();
            ShowList(contactList);
            Console.Write("Enter the name of the person you want to change the information of: ");
            string firstName = Console.ReadLine();
            Console.Clear();

            Person informationToChange = contactList.Find(x => x.FirstName == firstName);

            if (informationToChange != null)
            {
                Console.WriteLine("Enter the new first name: ");
                informationToChange.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the new phone number: ");
                informationToChange.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the new email: ");
                informationToChange.Email = Console.ReadLine();
                Console.WriteLine("Enter the new home address: ");
                informationToChange.HomeAddress = Console.ReadLine();
                Console.WriteLine("Enter the new work address: ");
                informationToChange.WorkAddress = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"The information about {informationToChange.FirstName} has been changed.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, but we couldn't find the person in the contact list.");
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
            Console.WriteLine("To change the information about a person press 'C'");
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
                Console.WriteLine("Home adress: " + contact.HomeAddress);
                Console.WriteLine("Work adress: " + contact.WorkAddress);
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
            Console.WriteLine("Enter the home address: ");
            string homeAddress = Console.ReadLine();
            Console.WriteLine("Enter the work address: ");
            string workAddress = Console.ReadLine();
            Console.Clear();
            contactList.Add(new Person { FirstName = firstName, PhoneNumber = phoneNumber, Email = email, HomeAddress = homeAddress, WorkAddress = workAddress });
            Console.WriteLine("Person has been added to the contact list, press 'V' to view!");
            Console.WriteLine();
        }
    }
}