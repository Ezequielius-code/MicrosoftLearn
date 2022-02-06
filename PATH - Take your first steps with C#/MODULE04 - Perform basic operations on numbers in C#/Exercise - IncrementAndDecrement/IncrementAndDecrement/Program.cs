// See https://aka.ms/new-console-template for more information

//Escribir código para incrementar y disminuir un valor.
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

//Usar el operador de incremento antes y después del valor.
int value1 = 1;

value1++;
Console.WriteLine("First: " + value1);
Console.WriteLine("Second: " + value1++);
Console.WriteLine("Third: " + value1);
Console.WriteLine("Fourth: " + (++value1));