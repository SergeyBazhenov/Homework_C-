/* 4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля */
string[] help = { "Help – Вывести список команд", "SetName – Установить имя", "SetPassword – Установить пароль", "ResetPassword - Сбросить пароль",
                "WriteName – Вывести имя после ввода пароля ", "Exit – Выход"};
string secret = "У меня нет от Вас секретов ;)!";
string correctPassword = "QWERTY";

int i = 0;
while (i < help.Length)
{
    Console.WriteLine(help[i]);
    i++;
}


/*int count = 3;
while (count > 0)
{
    Console.WriteLine("У Вас есть " + count + " попытки чтоб узать секрет! Список доступных комманд введите Help.");
    Console.Write("Введите пароль: ");
    string password = Console.ReadLine();
    if (password == correctPassword)
    {
        Console.WriteLine(secret);
        break;
    }
    else
    {
        Console.WriteLine("Пароль не подходит!");
    }
count--;
}*/