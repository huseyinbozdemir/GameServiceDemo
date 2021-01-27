using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class Person : Entity
    {
        public Person()
        {

        }
        public Person(string id, string name, string lname, int year)
        {
            IdentificationNumber = id;
            Name = name;
            LastName = lname;
            YearOfBith = year;
        }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBith { get; set; }
    }
}
