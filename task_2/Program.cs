Console.Write("Введите первое значение ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Максимальное значение ");
    Console.WriteLine(numberA);
} 
else
{
    Console.Write("Максимальное значение ");
    Console.WriteLine(numberB);
}
