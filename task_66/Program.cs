//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

namespace App_5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите число начала диапазона: ");
            int start = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Введите число окончания диапазона: ");
            int finish = Convert.ToInt32(Console.ReadLine());

            GetRecursionNumber(start,finish) ;
        }

        static void GetRecursionNumber(int start, int finish, int result = 0)
        {   
            if (start > finish) 
            {   
                Console.WriteLine($"Cумма натуральных элементов в диапазоне: {result}");   
                return;
            }

            result = result + (start++);
            GetRecursionNumber(start, finish, result);
        }
    }
}