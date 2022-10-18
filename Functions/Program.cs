// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int min = 10;
int max = 99;
int randomNumber = new Random().Next(min, max + 1);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

int maxDigit = Max(firstDigit, secondDigit);

Console.WriteLine($"{randomNumber} -> {maxDigit}");


int Max(int a, int b)
{
    if(a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
