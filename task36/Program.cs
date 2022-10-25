// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    int[] newArray = GetArray(10, -100, 100);
    int sum = SumElements(newArray);
    WriteArray(newArray);
    WriteResult(sum);
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

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int res = i % 2;
        if (res == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

void WriteResult(int sum1)
{
    Console.WriteLine($"Сумма чисел = {sum1}.");
}
Main();
