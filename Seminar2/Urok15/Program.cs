// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите число (1-7) дня недели: ");
int num = int.Parse(Console.ReadLine());
if ((num > 7) || (num <1 ))
{
    Console.WriteLine("Неверный день недели");
    return;
}
if ((num > 5))
{
    Console.WriteLine("Да, это выходной день");
}
else
{
    Console.WriteLine("Нет, это рабочий день");
}