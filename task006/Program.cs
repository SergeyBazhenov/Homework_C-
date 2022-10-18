/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 (Использовать только математические операции, нельзя использовать число как строку по типу number[2])

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
Console.Write("Введите число: ");
string number = Console.ReadLine();
int thirdDigit = Convert.ToInt32(number);
if (thirdDigit > 100)
{
    while (thirdDigit > 1000)
    {
        thirdDigit /= 10;
    }
    thirdDigit %= 10;
    Console.WriteLine($"Третья цифра чила {number} -> {thirdDigit}");


}
else
{
    Console.WriteLine($"В числе {number} нет третьей цифры!");
}

