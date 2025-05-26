using static System.Formats.Asn1.AsnWriter;

namespace Practice3.Task2
{
    internal class Program
    {
        class Student
        {
            public string Name;
            public int Age;
            public double score;
            public double Score
            {
                get => score;
                set
                {
                    if (value >= 0 && value <= 5)
                    {
                        score = value;
                    }
                    else
                    {
                        score = 0;
                        
                    }
                    ;
                }
            }
            public void Write()
            {
                Console.WriteLine($"Студент {Name} - {Age} лет, средний бал {score}");
            }
        }
        static void Main(string[] args)
        {
            Student Sveta = new Student();
            Sveta.Name = "Света";
            Sveta.Age = 46;
            Sveta.Score = 4.5;
            Sveta.Write();
            Student Max = new Student();
            Max.Name = "Максим";
            Max.Age = 26;
            Max.Score = 10;
            Max.Write();

        }
    }
}
