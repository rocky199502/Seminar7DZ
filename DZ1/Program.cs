using System;
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
namespace DZ1
{
    class Program
    {
        static double[,] RandArray(int M, int N)
        {
            double[,] array = new double[M,N];
            Random rand = new Random();
            for (int i = 0; i<M ; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    array[i,j]= rand.Next(-99,99)/10.0;
                }
            }
            return array;
        }
        static void OutArray(double[,] array, int M, int N)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Сформированный массив:");
            for (int i = 0; i<M ; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    Console.Write(String.Format("{0,7}",array[i,j]));
              
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк:"); 
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:"); 
            int N = int.Parse(Console.ReadLine());
            double [,] array = RandArray(M,N);
            OutArray(array,M,N);
        }
    }
}
