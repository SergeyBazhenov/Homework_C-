/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
(Использовать только математические операции, нельзя использовать число как строку по типу number[1])
14212 -> нет
12821 -> да
23432 -> да
*/

int number = ReadInt("Введите пятизначное число: ");
int[] palindrome = new int[5];
int i = 4;

if (number > 10000 && number < 100000)
{
    NumArr(number);
    if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
    {
        Console.WriteLine($"{number} -> палиндром!");
    }

    else
    {
        Console.WriteLine($"{number} -> не палиндром!");
    }
}
else
{
    Console.WriteLine($"Вы ввели число: {number}, это не пятизначное чило!");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] NumArr(int num)
{
    while (num != 0)
    {
        palindrome[i] = num % 10;
        num /= 10;
        i -= 1;
    }
    return palindrome;
}