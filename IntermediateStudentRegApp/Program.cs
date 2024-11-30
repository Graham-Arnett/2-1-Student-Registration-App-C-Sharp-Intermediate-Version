using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace IntermediateStudentRegApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration App");
            string repeat;
            do
            {
                Console.Write("\nEnter your first name: ");
                string firstName = Console.ReadLine();
                Console.Write("\nEnter your last name: ");
                string lastName = Console.ReadLine();

                Console.Write("\nEnter the year you were born: ");
                string birthYear = Console.ReadLine();
                Console.Write("\nWould you like security question 1, 2, or 3: ");
                int choice = int.Parse(Console.ReadLine());
                string answer;
                switch (choice)
                {
                    case 1:
                        Console.Write("What was the name of your favorite childhood pet? ");
                        answer = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("What was the name of your childhood friend? ");
                        answer = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("What is your favorite flavor of icecream? ");
                        answer = Console.ReadLine();
                        break;
                }
                Console.Write("\nPlease enter your desired username: ");
                string userName = Console.ReadLine();
                string password = lastName + birthYear;
             
                Console.WriteLine($"\nAll set!\nWelcome {firstName}!\nLets review the information:\n" +
                    $"Your username is: {userName}\nYour full name is {firstName} {lastName}\n" +
                    $"Your date of birth is {birthYear}");
                Console.Write("\nWould you like to go again? (y/n): ");
                repeat = Console.ReadLine().ToLower();
            }while(repeat == "y");
            
        }
    }
}
