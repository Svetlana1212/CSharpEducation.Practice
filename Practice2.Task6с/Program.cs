using System;

namespace Practice2.Task6с
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            string str= args[0];
            
            string key = args[1];
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
            //Console.WriteLine(str);
        }
    }
}
