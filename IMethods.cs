using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDatabase
{
    public class IMethods
    {
        public static Person GetAPersonFromUser()
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();

            Person person = new Person(FirstName, LastName);

            return person;
        }

        public static void DeleteAUser(Person [] peoplearray)
        {
            Console.WriteLine("Please enter an IDNumber");
            string idNumber = Console.ReadLine();
            IEnumerable<Person> filteredArray = peoplearray.FilterArray(idNumber);
            foreach (var item in filteredArray)
            {
                Console.WriteLine("The persons first name is {0}, their last name is {1}, their unique id number is {2}", item.FirstName, item.LastName, item.ID.ToString());
            }
        }

        public static void FindAllUsers(Person [] peoplearray)
        {
            foreach (var item in peoplearray)
            {
                Console.WriteLine("The persons first name is {0}, their last name is {1}, their unique id number is {2}", item.FirstName, item.LastName, item.ID.ToString());
            }

        }

    }
}
