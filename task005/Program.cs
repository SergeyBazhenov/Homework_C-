/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
(Использовать только математические операции, нельзя использовать число как строку по типу number[1])
456 -> 5
782 -> 8
918 -> 1 */
Console.Write("Введите трёхзначное число: ");
string number = Console.ReadLine();
int digitNumber = Convert.ToInt32(number);
int secondDigit = digitNumber / 10 % 10;
//int lastdDigit = randomNumber % 10;
Console.WriteLine(secondDigit);