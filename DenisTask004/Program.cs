/* 4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля */
string[] help = { "Help –> Вывести список команд", "SetName –> Установить имя", "SetPassword –> Установить пароль", "ResetPassword –> Сбросить пароль",
                "ShowPassword -> Показать пароль", "WriteName –> Вывести имя после ввода пароля ", "Exit –> Выход"};
string name = "";
string password = "";

while (1 > 0)
{
    Console.Write("Введите команду (посмотеть список доступных команд \"Help\"): ");
    string command = Console.ReadLine();
    if (command.ToLower() == "help")
    {
        int i = 0;
        while (i < help.Length)
        {
            Console.WriteLine(help[i]);
            i++;
        }
    }
    else if (command == "SetName")
    {
        Console.Write("Введите Ваше имя: ");
        name = Console.ReadLine();
    }
    else if (command == "SetPassword")
    {
        Console.Write("Введите пароль: ");
        password = Console.ReadLine();
    }
    else if (command == "ResetPassword")
    {
        password = "";
    }
    else if (command == "ShowPassword")
    {
        Console.WriteLine(password);
    }
    else if (command == "WriteName")
    {
        Console.Write("Для того чтобы увидеть Имя нужно ввести пароль: ");
        string passwordUser = Console.ReadLine();
        if (passwordUser == password)
        {
            Console.WriteLine(name);
        }
        else
        {
            Console.WriteLine("Пароль не верен!");
        }

    }
    else if (command.ToLower() == "exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Cписок доступных команд - введите \"Help\"");
    }
}