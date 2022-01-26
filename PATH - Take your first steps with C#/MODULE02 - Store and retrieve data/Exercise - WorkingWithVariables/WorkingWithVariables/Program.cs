// See https://aka.ms/new-console-template for more information

//Declarar una variable y asignarle un valor.
string firstName;
firstName = "Bob";

//Recuperar valor almacenado en la variable declarada.
/*Simplemente, se debe usar el nombre de la variable,
en este caso se recupera el valor y se imprime por consola.*/
Console.WriteLine(firstName);

//Reasignar un valor a una variable.
/*Se puede reutilizar y reasignar la variable tantas veces 
 * como se desee.
 * Utilizo la salida por consola para mostrar el resultado.*/
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);

//Inicialización de una variable.
//Se declara la variable y se le asigna valor en una sola línea.
string lastName = "Oswald";
Console.WriteLine(lastName);