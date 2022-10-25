// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Main()
{
    int[] newArray = GetArray(10, 0, 100);
    int maximum = MaxNumber(newArray);
    int minimum = MinNumber(newArray);
    int result = Subtraction(maximum, minimum);
    WriteArray(newArray);
    WriteResult(result);
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

int MaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int MinNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

int Subtraction(int max, int min)
{
    int result1 = max - min;
    return result1;
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

void WriteResult(int res1)
{
    Console.WriteLine($"Разница = {res1}.");
}
Main();
