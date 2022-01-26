// See https://aka.ms/new-console-template for more information

//Concatenar una cadena literal y una variable.
string firstName = "Bob";
string message = "Hello" + firstName;
Console.WriteLine(message);

//Concatenar múltiples variables y cadenas literales.
string firstName1 = "Sean";
string greeting1 = "Hi";
string message1 = greeting1 + " " + firstName1 + "!";
Console.WriteLine(message1);

//Evitar variables intermedias.
string firstName2 = "Emma";
string greeting2 = "Welcome";
Console.WriteLine(greeting2 + " " + firstName2 + "!");
