//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


double[, ] CreateMass(int n, int m)
{
    double[, ] mass = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mass[i, j] = new Random().NextDouble() * 10;
        }
    }
    return mass;
}

void PrintMass(double [, ] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
         for (int j = 0; j < mass.GetLength(1); j++)
         {
            Console.Write(mass[i, j] + " ");
         }
         Console.WriteLine();
    }
}
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());   
Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());  
PrintMass(CreateMass(n, m));    
       