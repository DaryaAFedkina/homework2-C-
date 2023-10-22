// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите порядковый номер дня недели: ");
int weekDay = Int32.Parse(Console.ReadLine());
if (weekDay > 5)
{
    System.Console.WriteLine("Да, этот день - выходной");    
} else
 {
    System.Console.WriteLine("Нет, это будний день");    
 }
