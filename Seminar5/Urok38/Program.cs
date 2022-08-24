//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();
int[] startArray = GetArray(6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница элементов = {GetDifference(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetDifference(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}