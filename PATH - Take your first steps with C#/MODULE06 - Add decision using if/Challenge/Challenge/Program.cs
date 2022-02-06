// See https://aka.ms/new-console-template for more information

/*Se le ha pedido que agregue una función al software de su empresa. 
 * La función está destinada a mejorar la tasa de renovación de las suscripciones al software. 
 * Su tarea es mostrar un mensaje de renovación cuando un usuario inicie sesión en el sistema 
 * de software y se le notifique que su suscripción finalizará pronto. Deberá agregar un par 
 * de declaraciones de decisión para agregar correctamente la lógica de bifurcación a la 
 * aplicación para satisfacer los requisitos.*/

/* Regla 1 . Si la suscripción del usuario expirará en 10 días o menos, muestre el mensaje:
 * Your subscription will expire soon. Renew now!
 * 
 * Regla 2 . Si la suscripción del usuario expirará en cinco días o menos, muestre los mensajes:
 * Your subscription expires in _ days.
 * Renew now and save 10%!
 * 
 * Asegúrese de sustituir _ por el valor almacenado en la variable daysUntilExpiration.
 * 
 * Regla 3 . Si la suscripción del usuario expirará en un día, muestre el mensaje:
 * Your subscription expires within a day!
 * Renew now and save 20%!
 * 
 * Regla 4 . Si la suscripción del usuario ha caducado, muestra el mensaje:
 * Your subscription has expired.
 * 
 * Regla 5 . Si la suscripción del usuario no vence en 10 días o menos, no muestre nada.*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if ((daysUntilExpiration <= 10) && (daysUntilExpiration >= 6))
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if ((daysUntilExpiration <= 5) && (daysUntilExpiration >= 2))
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.Write($"Renew now and save {discountPercentage}%!");
}
else if ((daysUntilExpiration == 1) || (daysUntilExpiration == 0))
{
    if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine("Your subscription expires within a day!");
        Console.Write($"Renew now and save {discountPercentage}%!");
    }
    else
    {
        Console.WriteLine("Your subscription has expired.");
    }
}
