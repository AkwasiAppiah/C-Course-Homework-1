using System;
using System.Collections.Generic;

namespace PersonDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE PERSON DATABASE");
            Console.WriteLine("Do you want to enter a User Yes(Y) or No (x)? ");
            string input = Console.ReadLine();

            var people = new List<Person>();

            while(input != "x")
            {
                Person person = IMethods.GetAPersonFromUser();
                people.Add(person);
                Console.WriteLine("Take note of this unique ID number {0}", person.ID);

                Console.WriteLine("Do you want to enter another person? Yes(Y) or No (x)?");
                input = Console.ReadLine();

                
            }

            Console.WriteLine("Do you need to update the databse? D for delete or F for find or x to exit");

            string userinput = Console.ReadLine();
            do
            {
                Person[] peopleArray = people.ToArray();
                switch (userinput)
                {
                    case "D":
                        IMethods.DeleteAUser(peopleArray);
                        Console.WriteLine("Do you need to update the databse? D for delete or F for find or x to exit");
                        userinput = Console.ReadLine();
                        break;
                    case "F":
                        IMethods.FindAllUsers(peopleArray);
                        Console.WriteLine("Do you need to update the databse? D for delete or F for find or x to exit");
                        userinput = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Enter a valid case");
                        userinput = Console.ReadLine();
                        break;
                }
            } while (userinput != "x");
            Console.WriteLine("Thanks for entering data");

        }
    }
}
