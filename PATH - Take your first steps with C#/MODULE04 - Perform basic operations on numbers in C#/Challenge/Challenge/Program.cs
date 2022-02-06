// See https://aka.ms/new-console-template for more information

//Escriba el código para calcular Celsius dada la temperatura en Fahrenheit.

//Comience con esta línea de código:
int fahrenheit = 94;

/*Para convertir temperaturas en grados Fahrenheit a Celsius, 
 * primero reste 32, luego multiplique por cinco novenos (5 / 9).*/

//Muestre el resultado de la conversión en un mensaje formateado.

/*Finalmente, combinará las variables con cadenas literales pasadas 
 * a una serie de Console.WriteLine()comandos para formar el mensaje 
 * completo.Cuando haya terminado, el mensaje debería parecerse al 
 * siguiente resultado:
 *     "The temperature is 34.444444444444444444444444447 Celsius."*/

decimal celsius = (fahrenheit - 32) * 5 / 9.0m;
Console.WriteLine("The temperature is " + celsius + " Celsius.");