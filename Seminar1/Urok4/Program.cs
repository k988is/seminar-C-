// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();
Console.Write("Введите A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите C: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine($"максимальное число = {max}");