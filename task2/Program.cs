// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int num3 = number / 10 % 10;
    Console.WriteLine (num3);
} else
{
    Console.WriteLine ("третьей цифры нет");
}