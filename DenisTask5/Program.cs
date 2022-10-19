/* 4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля 
Добавить switch и проверку на пустое имя и пароль */
string[] help = { "Help –> Вывести список команд", "SetName –> Установить имя", "SetPassword –> Установить пароль", "ResetPassword –> Сбросить пароль",
                "ShowPassword -> Показать пароль", "WriteName –> Вывести имя после ввода пароля ", "Exit –> Выход"};
string name = "";
string password = "";

while (1 > 0)
{
    Console.Write("Введите команду (посмотеть список доступных команд \"Help\"): ");
    string command = Console.ReadLine();
    switch (command.ToLower())
    {
        case "help":
            int i = 0;
            while (i < help.Length)
            {
                Console.WriteLine(help[i]);
                i++;
            }
            break;

        case "setname":
            Console.Write("Введите Ваше имя: ");
            name = Console.ReadLine();
            break;

        case "setpassword":
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
            break;

        case "resetpassword":
            if (password == "")
            {
                Console.WriteLine("Пароль не установлен");
            }
            else
            {
                password = "";
            }
            break;

        case "showpassword":
            if (password == "")
            {
                Console.WriteLine("Пароль не установлен");
            }
            else
            {
                Console.WriteLine(password);
            }
            break;

        case "writename":
            if (name == "")
            {
                Console.WriteLine("Имя не определено");
            }
            else
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
            break;

        case "exit":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Неизвестная команда");
            Console.WriteLine("Cписок доступных команд - введите \"Help\"");
            break;

    }
    
}