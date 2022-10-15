/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
Console.Write("Введите третье число: ");
string inputC = Console.ReadLine();
int a = Convert.ToInt32(inputA);
int b = Convert.ToInt32(inputB);
int c = Convert.ToInt32(inputC);
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);