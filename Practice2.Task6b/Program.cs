using System;

namespace Practice2.Task6b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку и нажмите Enter:");
            string str=Console.ReadLine();
            Console.WriteLine("Введите символ и нажмите Enter:");
            string key = Console.ReadLine();
            int length = str.Length;
            string simvol = key.ToString();
            string Simvol = simvol.ToUpper();
            int counter = 0;
            for (int i=0; i<length; i++)
            {
                if (str[i].ToString()==Simvol || str[i].ToString()==simvol)
                {
                    counter++;
                }
                

            }
            var percentages = (counter*Math.Pow(length,-1))*100;
            Console.WriteLine($"Символ '{key}' составляет {percentages} % строки '{str}'");
        }
    }
}
