using System.Xml.Linq;

namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём объект Random для генерации случайных чисел 
            var rnd = new Random(); 
            // Создаём массив из 10 элементов 
            var array = new int[10]; 
            // Заполняем массив случайными числами 
            for (var i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1,100);  
            }
            // Выводим  массив 
            
            foreach (var num in array)
            {
                Console.Write(num + " ");
                Console.WriteLine();
            }  
            // Находим максимальный элемент и его индекс 
            int maxElement = array.Max();
            int minElement = array.Min();
            // Выводим результаты 


            Console.WriteLine($"Максимальный элемент: {maxElement}, минимальный элемент: {minElement}"); 
        }
    }
}
