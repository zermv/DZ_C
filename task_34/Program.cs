//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Задайте длину массива");
int d = Convert.ToInt32(Console.ReadLine());
int[] array = new int[d];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(99, 1000);   
        index++;
    }    
}
void PrintArray(int[] col)
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

int i = 0;
int n = 0;

while (i < d)
{
    if (array[i]%2 == 0) 
    n++;
    i++;
}
Console.WriteLine("Колличество четных чисел");
Console.WriteLine(n);