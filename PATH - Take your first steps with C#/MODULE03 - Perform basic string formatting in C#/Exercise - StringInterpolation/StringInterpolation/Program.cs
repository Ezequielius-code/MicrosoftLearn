// See https://aka.ms/new-console-template for more information

/*Uso de la interpolación de cadenas para combinar una cadena
 * literal y un valor variable.*/
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

/*Uso de la interpolación de cadenas con múltiples variables
 * y cadenas literales*/
string firstName1 = "Sharon";
string greeting1 = "Hi";
string message1 = $"{greeting1} {firstName1}!";
Console.WriteLine(message1);

//Evitando las variables intermedias.
string firstName2 = "Zoe";
string greeting2 = "Welcome";
Console.WriteLine($"{greeting2} {firstName2}!");

//Combinar literales textuales e interpolación de cadenas.
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");