// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    int[] newArray = GetArray(10, 100, 999);
    int count = CountNumbers(newArray);
    WriteArray(newArray);
    WriteResult(count);
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CountNumbers(int[] array)
{
    int result = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

void WriteResult(int count1)
{
    Console.WriteLine($"Количество четных чисел = {count1}.");
}
Main();