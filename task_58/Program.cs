//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

namespace App_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = new string[4] {"Введите количество строк",
                                           "Введите количество столбцов",
                                           "Введите максимальное значение случайных значений массива",
                                           "Введите минимальное значение случайных значений массива"
                                          };
            
            int[] param = new int[item.Length]; 
            
            for (int i = 0; i < item.Length; i++)
			{
                 Console.Write($"{item[i]}: ");
                 param[i] = Convert.ToInt32(Console.ReadLine());
			}

            int[,] array_1 = GetAdd2DArray(param);
            int[,] array_2 = GetAdd2DArray(param);

            Print2DArray(array_1);
            Print2DArray(array_2);
            
            Console.WriteLine($"Рассчитаем произведение двух матриц");
            Print2DArray(Сomposition2DArray(array_1,array_2));


        }
        static int[,] GetAdd2DArray( params int[] param )
        {
            int[,] array = new int[param[0], param[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(param[3], param[2]);
                }
            }

            return array;
        }
        static void Print2DArray(int[,] array)
        {   
            Console.WriteLine($"Выведем массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"  {array[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Сomposition2DArray( int[,] array_1, int[,] array_2 )
        {   
            int[,] composition = new int[array_1.GetLength(0), array_1.GetLength(1)];
            
            if (array_1.GetLength(0) == array_1.GetLength(0))
	        {
                for (int i = 0; i < array_1.GetLength(0); i++)
                {   
                    for (int j = 0; j < array_1.GetLength(1); j++)  
                    {
                        composition[i,j] = array_1[i,j] * array_2[i,j];
                    }
                }
	        }

            return composition;
        }
    }
}