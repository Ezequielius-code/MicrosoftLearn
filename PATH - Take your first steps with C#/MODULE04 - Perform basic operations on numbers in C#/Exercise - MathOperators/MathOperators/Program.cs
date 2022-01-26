// See https://aka.ms/new-console-template for more information

//Realizar sumas, restas, multiplicaciones y divisiones con enteros.
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//División usando datos literales para evitar el truncamiento del resultado.
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

//Otros modos de obtener el decimal que son correctos y funcionan bien.
decimal firstDecimalQuotient = 7 / 8.0m;
decimal secondDecimalQuotient = 7.0m / 4.0m;
Console.Write($@"   Quotients:
        1st decimal quotient: {firstDecimalQuotient}
        2nd decimal quotient: {secondDecimalQuotient}");
Console.WriteLine();

//División usando conversión de datos.
int first = 7;
int second = 5;
decimal castedQuotient = (decimal)first / (decimal)second;
Console.WriteLine("Casted quotient: " + castedQuotient);
Console.WriteLine();

//Determinar el resto de una división.
Console.WriteLine("Modulus of 200 / 5: " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

//Orden de operaciones.
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);