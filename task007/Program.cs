/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число: ");
string inputDay = Console.ReadLine();
int day = Convert.ToInt32(inputDay);
if (day > 5 && day < 8)
{
    Console.WriteLine($"{day} -> да");
}
else if (day >= 1 && day <=5)
{
    Console.WriteLine($"{day} -> нет");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}