/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */
/*int x = 7;
int y = 23;
Console.Write("Введите число: ");
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);

if (a % x == 0 && a % y == 0)
{
    Console.WriteLine($"Число {a} кратно числу 7 и 23");
}
else
{
    Console.WriteLine($"Число {a} некратно числам 7 и 23");
} Моё решение*/

int number = ReadInt("Введите число: ");
int firstDivider = 7;
int secondDivider = 23;

if(IsMultiply(number, firstDivider) && IsMultiply(number, secondDivider))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


bool IsMultiply(int a, int div)
{
    return a % div == 0;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

