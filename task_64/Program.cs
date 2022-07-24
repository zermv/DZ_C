//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

namespace App_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите число начала диапазона: ");
            int start = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Введите число окончания диапазона: ");
            int finish = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Натуральные числа диапазона от {start} до {finish}: {GetRecursionNumber(start,finish)}");
        }

        static string GetRecursionNumber(int start, int finish)
        {   
            return finish == start ? $"{start} " : $"{ GetRecursionNumber( start, finish - 1 ) + finish } ";
        }
    }
}