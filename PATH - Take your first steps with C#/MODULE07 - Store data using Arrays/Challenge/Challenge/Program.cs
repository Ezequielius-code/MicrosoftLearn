// See https://aka.ms/new-console-template for more information

string[] suspiciousOrdersIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
string[] fraudulentOrdersIDs = new string[suspiciousOrdersIDs.Length];
int fraudulentOrder = 0;

foreach (string orderID in suspiciousOrdersIDs)
{
    if (orderID.StartsWith("B"))
    {
        fraudulentOrdersIDs[fraudulentOrder] = orderID;
        fraudulentOrder++;
    }
}

if (fraudulentOrder > 0)
{
    Console.WriteLine($"{fraudulentOrder} fraudulent orders were detected: ");
    foreach (string item in fraudulentOrdersIDs)
    {
        Console.WriteLine($"{item}");
    }
}
else
{
    Console.WriteLine("No fraudulent orders were detedted.");
}