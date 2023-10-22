// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
    number = number / 10;
}
if (number > 99 && number < 1000)
{
    int num3 = number % 10;
    Console.WriteLine (num3);
} else
{
    Console.WriteLine ("третьей цифры нет");
}