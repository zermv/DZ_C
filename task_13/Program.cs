Console.WriteLine("Введите значение ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
Console.WriteLine("Нет третьей цифры");
else 
{
    while (number > 1000)
    {
        number = number/10;
    }
Console.WriteLine(number%10);
}


