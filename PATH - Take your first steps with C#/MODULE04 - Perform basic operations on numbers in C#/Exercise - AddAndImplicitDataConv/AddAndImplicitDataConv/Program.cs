// See https://aka.ms/new-console-template for more information

//Sumar dos valores numéricos.
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//Mezclar tipos de datos para forzar conversiones de tipos implícitas.
//Se convertirá un dato de tipo int a otro de tipo string.
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//Un caso más avanzado de sumar números y concatenar cadenas.
//Se fuerza la falla al implementar erróneamente la cadena.
string firstName1 = "Bob";
int widgetsSold1 = 7;
Console.WriteLine(firstName1 + " sold " + widgetsSold1 + 7 + " widgets.");

//Agregar paréntesis para dejar clara la intención de la operatoria al compilador.
string firstName2 = "Bob";
int widgetsSold2 = 7;
Console.WriteLine(firstName2 + " sold " + (widgetsSold2 + 7) + " widgets.");