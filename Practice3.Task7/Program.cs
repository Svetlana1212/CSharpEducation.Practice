namespace Practice3.Task7
{
    internal class Program
    {
        public enum Months
        {
            January, 
            February, 
            March, 
            April, 
            May , 
            June , 
            July, 
            August, 
            September, 
            October, 
            November, 
            December
        }
        static void numberOfDays(Months Month)
        {
            if (Month == Months.April || Month == Months.June || Month == Months.September || Month == Months.November)
            {
                Console.WriteLine("В месяце 30 дней");
            }
            else if (Month == Months.February)
            {
                Console.WriteLine("В месяце 28 дней");
            }
            else
            {
                Console.WriteLine("В месяце 31 день");
            }

        }
        static void Main(string[] args)
        {
            numberOfDays(Months.May);
        }
    }
}
