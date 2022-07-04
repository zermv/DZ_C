Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i < (n + 1))
{
  Console.WriteLine(Math.Pow(i, 3));
  i++;
}