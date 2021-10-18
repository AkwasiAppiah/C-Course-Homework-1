using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDatabase
{
    public static class MyExtensions
    {
        public static IEnumerable<Person> FilterArray(this IEnumerable<Person> array , string userInput)
        {
            Guid idNumber = Guid.Parse(userInput);

            IEnumerable <Person> filterdArray = array.Where((Person) => Person.ID != idNumber);

            return filterdArray;
        }
    }
}
