using System;

namespace Практическая_работа_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] mas = new int[10];
            int[,] ms1 = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms1.GetLength(1); j++)
                {
                    ms1[i, j] = rand.Next(10);
                    Console.Write($"{ms[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Задание 2");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    mas[j] = ms1[j, i];
                }
                Array.Sort(mas);
                for (int u = 0; u < 9; u++)
                {
                    ms1[u, i] = mas[u];
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(ms1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
    }
