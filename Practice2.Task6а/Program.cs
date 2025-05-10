using System;

namespace Practice2.Task6a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Привет мир";
            char key = 'и';
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
                //Console.WriteLine(counter);

            }
            var percentages = (counter*Math.Pow(length,-1))*100;//77* Math.Pow(10,-1);
            Console.WriteLine($"Символ '{key}' составляет {percentages} % строки '{str}'");
        }
    }
}
