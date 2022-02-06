// See https://aka.ms/new-console-template for more information

//Ejemplo de utilización del foreach.
string[] names = { "Bob", "Conrad", "Grant" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n\n\n");

//Ejercicio.
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");