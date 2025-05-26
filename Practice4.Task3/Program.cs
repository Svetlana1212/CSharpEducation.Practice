using ClassLibraryPerson;

namespace Practice4.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Egor = new Person("Егор",32);
            Person.WriteInfo(Egor);
            
        }
    }
}
