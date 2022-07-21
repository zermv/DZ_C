//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
namespace App_6
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[] count = new string[2] {"строк","столбцов"};
            int[] par = new int[2];

            for (int i = 0; i < 2; i++)
			{
                 Console.Write($"Введите количество {count[i]}: ");
                 par[i] = Convert.ToInt32(Console.ReadLine());
			}

            int[,] array = GetArray(par);
            PrintArray( array );

            GetAverage( array);
            
        }

        static int[,] GetArray(params int[] par)
        {
            int[,] array = new int[par[0], par[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }

            return array;
        }

        
        static void PrintArray(int[,] array)
        {   
            Console.WriteLine("Vассив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i,j]) + " ");
                }
                Console.WriteLine();
            }
        }

        
        static void GetAverage( int[,] array)
        {   
                Console.Write("Cреднее арифметическое ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double sum = 0;
                    
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum = sum + array[i, j];
                    }
                    
                    Console.Write(sum / array.GetLength(0)+ " ");
                }       
        }
    }
}