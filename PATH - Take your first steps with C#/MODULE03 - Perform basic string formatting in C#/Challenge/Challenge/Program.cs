// See https://aka.ms/new-console-template for more information

//Challenge completo: https://docs.microsoft.com/en-us/learn/modules/csharp-basic-formatting/5-challenge

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.Write($"View English output:\n\t\tc:\\Exercise\\{projectName}\\data.txt\n\n");
Console.WriteLine($@"{russianMessage}:
        c:\Exercise\{projectName}\ru-RU\data.txt");