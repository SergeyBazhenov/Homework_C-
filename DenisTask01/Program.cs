// 1. В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.
string secret = "У меня нет от Вас секретов ;)!";
int count = 3;
while (count > 0)
{
Console.WriteLine("У Вас есть " + count + " попытки чтоб узать секрет!");
Console.Write("Введите пароль: ");
string Pass = Console.ReadLine();
if (Pass == "QWERTY")
{
    Console.WriteLine(secret);
    break;
}
else
{
    Console.WriteLine("Пароль не подходит!");
}
count--;
}