using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPerson
{
    public class Person
    {
        public string Name;
        public int Age;
        public Person(string myName, int myAge)
        {
            Name = myName;
            Age = myAge;
        }
    
        public static void WriteInfo(Person person)
        {
            Console.WriteLine($" Имя - {person.Name}:  возраст - {person.Age}");
        }
    }
}