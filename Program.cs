Double a, b, c;

Console.Write("\n(a): ");
a = Convert.ToDouble(Console.ReadLine());
 
Console.Write("(b): ");
b = Convert.ToDouble(Console.ReadLine());
 
Console.Write("(c): ");
c = Convert.ToDouble(Console.ReadLine());

double delta = Math.Pow(b, 2) - 4 * a * c;

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nNão é uma equação de segundo grau!\n");
}

else if (delta < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\nComo delta = {delta}, a equação não possui raízes reais!\n");
}

else
{
    double x1 = (-b + Math.Sqrt(delta)) / 2;
    double x2 = (-b - Math.Sqrt(delta)) / 2;

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"\nX1 = {x1} e X2 = {x2}\n");
}

Console.ResetColor();



