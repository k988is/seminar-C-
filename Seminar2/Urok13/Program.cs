//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
int number3 = (num / 100) % 10;
Console.WriteLine($"Третья цифра числа {num} -> {number3}");