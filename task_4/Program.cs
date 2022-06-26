Console.Write("Введите первое значение ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье значение ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max = ");
Console.WriteLine(max);

