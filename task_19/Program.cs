Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int numberA = n%10;
int numberB = n/10%10;
int numberC = n/1000%10;
int numberD = n/10000;
if (numberA == numberD && numberB == numberC)
    Console.WriteLine("Палиндром");
else 
    Console.WriteLine("Не палиндром");
