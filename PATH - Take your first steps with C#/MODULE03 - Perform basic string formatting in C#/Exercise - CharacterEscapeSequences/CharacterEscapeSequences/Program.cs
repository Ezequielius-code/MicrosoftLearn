// See https://aka.ms/new-console-template for more information

//Las secuencias de escape comienzan con '\' y luego incluyen otro caracter.

/*Por ejemplo, la secuencia '\n' agrega una nueva línea y, 
 * la secuencia '\t' agrega una tabulación.*/
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

/*También usamos cadena de escape para incluir una doble
 * comilla en una cadena de literal.*/
Console.WriteLine("Hello \"World\"!");

/*Si se necesita incluir en la cadena de literal una barra
 * invertida, la secuencia de escape a utilizar es '\\'*/
Console.WriteLine("C:\\source\\repos");
Console.WriteLine();

/*Formatee la salida de la aplicación de línea de comandos
 * utilizando secuencias de escape de caracteres.*/
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine();

//Literal de cadena textual.
/*Se realiza usando la directiva '@' antes de la cadena de
 * literal. Mantiene espacios en blanco, caracteres, etc.*/
Console.WriteLine(@"    C:\source\repos
        (this is where your code goes)");
Console.WriteLine();

/*Formatee la salida de la aplicación de línea de de 
 * comandos usando una cadena literal.*/
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"C:\invoices");
Console.WriteLine();

//Caracteres de escape Unicode.
//Kon´nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
Console.WriteLine();

/*NOTA:
 *  Algunas consolas, como el símbolo del sistema de Windows, 
 *  no mostrarán todos los caracteres Unicode. En su lugar, 
 *  reemplazará esos caracteres con caracteres de signo de 
 *  interrogación.*/

/*Formatee la salida de la aplicación de línea de comandos
 * utilizando caracteres de escape Unicode.*/
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");