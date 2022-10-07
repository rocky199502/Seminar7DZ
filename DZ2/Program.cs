using System;

namespace DZ2
{
    class Program
    {
        static int[,] RandArray(int M, int N)
        {
            int[,] array = new int[M,N];
            Random rand = new Random();
            for (int i = 0; i<M ; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    array[i,j]= rand.Next(0,9);
                }
            }
            return array;
        }
  
        static void OutArray(int[,] array, int M, int N)
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
  
  // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        static void PositionArray(int[,] array,int STR, int STB)
        {
            int value = 0;
            if ((STR<array.GetLength(0)) & (STB<array.GetLength(1)))
            {
                value = array[STR,STB]; 
                Console.WriteLine("Найденное значение: "+value);
            }
            else {Console.WriteLine("Такого элемента нет, уточните размерность массива!");} 
        }
  
  
        static void NumberArray(int[,] array,int number)
        {
            int resi = 0;
            int resj = 0;
            bool res = false;
            for (int i = 0; i<array.GetLength(0) ; i++)
            {
                for (int j = 0; j<array.GetLength(1); j++)
                    {
                        if (array[i,j]==number)
                        {
                            resi = i;
                            resj = j;
                            res = true;
                        }
                    }
                }
                if (res == true)
                {Console.WriteLine("Элемент с заданным значением имеет позицию: " +resi+" , "+resj);}
                else {Console.WriteLine("Такого значения не существует!");}
        }
  
  // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        static double[] Average(int[,] array)
        {
            double[] sum = new double[array.GetLength(1)];
            for (int i = 0; i<array.GetLength(0) ; i++)
            {
                for (int j = 0; j<array.GetLength(1); j++)
                {
                    sum[j]+= array[i,j];  
                }
            }
            for (int i=0;i<sum.Length;i++)
            {
                sum[i] = sum[i]/array.GetLength(0); 
            }
            return sum; 
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк:"); 
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:"); 
            int N = int.Parse(Console.ReadLine());
            int [,] array = RandArray(M,N);
            OutArray(array,M,N);
            Console.WriteLine("Поиск элементов. Введите строку (нумерация массива начинается с нуля):"); 
            int Str = int.Parse(Console.ReadLine());
            Console.WriteLine("Поиск элементов. Введите столбец (нумерация массива начинается с нуля):"); 
            int Stb = int.Parse(Console.ReadLine());
            PositionArray(array,Str,Stb);
            Console.WriteLine("Поиск элементов (нумерация массива начинается с нуля). Введите значение: "); 
            int number = int.Parse(Console.ReadLine());
            NumberArray(array,number);
            double[] sr = Average(array);
            Console.WriteLine("Среднее арифметическое каждого столбца:"); 
            for (int i=0;i<sr.Length;i++)
            {
                Console.Write(String.Format("{0,7}",sr[i]));
            }
        }
    }
}
