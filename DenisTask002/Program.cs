// 2. Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
while (1 > 0)
{
Console.WriteLine("Эта програма тестирования бесконечного цикла, когда надоест введите \"exit\"");
Console.Write("Введите что-нибудь: ");
string endProgram = Console.ReadLine();
if (endProgram.ToLower() == "exit")
{
    break;
}

}
