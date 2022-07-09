//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Задайте длину массива");
int d = Convert.ToInt32(Console.ReadLine());
double[] array = new double[d];
void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-99, 100);   
        index++;
    }    
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"{col[position]}");
        position++;
    }  
}
FillArray(array);
PrintArray(array);

int i = 1;
double max = array[0];
double min = array[0];

while (i < d)
{
    if (array[i] > max)
    max = array[i];
    if (array[i] < min)
    min = array[i];
    i++;
}

Console.WriteLine("Разница между максимальным и минимальным элементов массива");
Console.WriteLine(max-min);
