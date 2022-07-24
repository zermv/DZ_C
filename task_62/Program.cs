//Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

namespace App_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Введите размер массива: ");
            int param = Convert.ToInt32(Console.ReadLine());

            int[,] array = GetAdd2DArray(param);

            Print2DArray(array);

        }
        static int[,] GetAdd2DArray( int param )
        {
            int[,] array = new int[param, param];
            int number = 1;

             
            for (int i = 0; i < array.GetLength(0); i++)
            {       
                for (int j = 0; j < array.GetLength(1); j++)
                {    
                    while (number <= array.GetLength(0) * array.GetLength(1))
                    {   
                        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                        {
                            array[i, j] = number;
                            j++;
                        }
                        else if (i < j && i + j >= array.GetLength(0) - 1)
                        {
                            array[i, j] = number;
                            i++;
                        }                     
                        else if (i >= j && i + j > array.GetLength(1) - 1)
                        {
                            array[i, j] = number;
                            j--;
                        }
                        else
                        {
                            array[i, j] = number;
                            i--;
                        }             
                        number ++;
                    } 
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
    }
}
