//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Zero(int X)
{
int i = 0;
int n = 0;
while (i < X)
{
    Console.WriteLine("Введите " + (i+1) + " число");
    int d = Convert.ToInt32(Console.ReadLine());
    if (d > 0)  
        n++;  
    i++;
}
return n;
}
Console.WriteLine("Введите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество чисел больше 0: " + (Zero(M)));

//Второй вариант решения без функции.

//int i = 0;
//int n = 0;
//while (i < M)
//{
//    Console.WriteLine("Введите " + (i+1) + " число");
//    int d = Convert.ToInt32(Console.ReadLine());
//    if (d > 0)  
//        n++;  
//    i++;
//}
//Console.WriteLine("Колличество чисел больше 0: " + (n));




