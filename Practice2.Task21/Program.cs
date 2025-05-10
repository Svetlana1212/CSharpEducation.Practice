namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра 'Угадай число'");
            Console.WriteLine();
            string game;
            do
            {
                Console.WriteLine("Введите число от 1 до 100 и нажмите Enter: ");
                int userImput = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                int rand = random.Next(1, 100);
                if (rand == userImput)
                {
                    Console.WriteLine("Поздравляем, вы угадали число");
                }
                else
                {
                    Console.WriteLine($"К сожалению вы ошиблись, загаданное число {rand}");
                }
                Console.WriteLine("Хотите сыграть снова?(Да/Нет)");
                game=(string)Console.ReadLine();
            } while (game=="Да"||game=="да");
        }
    }
}
