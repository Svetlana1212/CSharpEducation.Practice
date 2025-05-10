using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[,] createAnArray(int n)
{

    int[,] myArr = new int[n, n];
    Random ran = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            myArr[i, j] = ran.Next(1, 15);
            //Console.Write("{0}\t", myArr[i, j]);
        }
        //Console.WriteLine();
    }
    return myArr;
}
void arrayOutput(int[,] Array)
{
    foreach (int i in Enumerable.Range(0, Array.GetLength(0)))
    {
        foreach (int j in Enumerable.Range(0, Array.GetLength(1)))
        {
            Console.Write(Array[i, j]);
        }
        Console.WriteLine();
    }
    
}
int num = 5;
int[,] newArray = createAnArray(num);
arrayOutput(createAnArray(num));
