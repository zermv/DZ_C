Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 1) || (number > 7))
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (number > 5)
    Console.WriteLine("Выходной день");
    else 
    Console.WriteLine("Будний день");

}
