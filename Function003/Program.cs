// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
/*Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int a = Convert.ToInt32(inputA);
int b = Convert.ToInt32(inputB);
if (a % b == 0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");
}
else
{
    Console.WriteLine($"Число {a} некратно числу {b}");
}*/

int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

int remainder = firstNumber % secondNumber;
if (remainder == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток от деления = " + remainder);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
