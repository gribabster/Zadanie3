using System;
using static System.Console;
using static System.Convert;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1 - 1  \n2 - 2  \n3 - 3  \n");
            int a = ToInt32(ReadLine());
            if (a == 1)
            {
                int[] rod = new int[5] { 6, 3, -7, 2, -3 };
                int b = rod[0];
                int ind = 0;
                for (int i = 0; i < rod.Length; i++)
                {
                    if (Math.Abs(rod[i]) < b)
                    {
                        b = Math.Abs(rod[i]);
                        ind = i;
                    }
                }
                WriteLine($"Min chislo: {b} Index: {ind}");
            }
            else if (a == 2)
            {
                int[] rod = new int[10] { 3, 5, 3, 44, 21, 44, 4, 4, 8, -7 };
                string result = "";
                int count = 0;

                for (int i = 0; i < rod.Length; i++)
                {
                    for (int j = 0; j < rod.Length; j++)
                    {
                        if (rod[i] == rod[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1) result = result + rod[i] + "; ";
                    count = 0;
                }
                WriteLine("Edinstvennie elementy: " + result);
            }
            else if (a == 3)
            {
                int[] rod = new int[10];
                Random rand = new Random();
                WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    rod[i] = rand.Next(-10, 10);
                    Write(rod[i] + " ");
                }
                Write("\nPologitelnie elementy: ");
                for (int i = 0; i < 10; i++)
                {
                    if (rod[i] < 0)
                    {
                        rod[i] = 0;
                    }
                    else Write(rod[i] + " ");
                }
            }
        }
    }
}