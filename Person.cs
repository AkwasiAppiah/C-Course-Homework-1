using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDatabase
{
    public class Person
    {

        public Person(string _FirstName, string _LastName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
        }
        Guid guid = Guid.NewGuid();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ID { get { return guid; } }
    }
}
