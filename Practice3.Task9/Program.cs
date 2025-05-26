namespace Practice3.Task9
{
    internal class Program
    {
        class Student
        {
            public string Name;
            public int Age;
            public Student(string myName, int myAge) 
            { 
                Name = myName;
                Age = myAge;
            }
            
        }
        static void Confidentiality(Student student)
        {
            student.Name = "Аноним";
        }
        static void Main(string[] args)
        {
            Student student = new Student("Иван", 26);
            Confidentiality(student);
            Console.WriteLine(student.Name);
        }
    }
}
