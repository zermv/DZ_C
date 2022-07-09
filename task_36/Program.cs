//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте длину массива");
int d = Convert.ToInt32(Console.ReadLine());
int[] array = new int[d];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next();   
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

int i = 1;
int sum = 0;

while (i < d)
{
    sum = sum + array[i];
    i = i+2;
}
Console.WriteLine("Сумма нечетных элементов массива");
Console.WriteLine(sum);