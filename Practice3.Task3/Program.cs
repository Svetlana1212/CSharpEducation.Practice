using System;

namespace Practice3.Task3
{
    internal class Program
    {
        class Сalculator
        {
            
            
            public double Summ(double number1,double number2)
            {
               return number1 + number2;                        
            }
            public double Diff(double number1, double number2)
            {
                return number1 - number2;
            }
            public double Mult(double number1, double number2)
            {
                return number1 * number2;
            }
            public double Ddiv(double number1, double number2)
            {
                return number1/number2;
            }
        }
        static void Main(string[] args)
        {
            Сalculator Calc = new Сalculator();
            double number1 = 5;
            double number2 = 4.5;
            Console.WriteLine(Calc.Summ(number1,number2));
            Console.WriteLine(Calc.Diff(number1, number2));
            Console.WriteLine(Calc.Mult(number1, number2));
            Console.WriteLine(Calc.Ddiv(number1, number2));
        }
    }
}
