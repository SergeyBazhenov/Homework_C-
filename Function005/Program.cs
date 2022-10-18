/* 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */
/* Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int a = Convert.ToInt32(inputA);
int b = Convert.ToInt32(inputB);
if (a * a == b || b * b == a)
{
    Console.WriteLine($"Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine($"Ни одно из чисел неявляется квадратом другого");
}
*/
int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

if(Pow(firstNumber) == secondNumber || Pow(secondNumber) == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int Pow(int a)
{
    return a * a;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
