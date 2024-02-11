// See https://aka.ms/new-console-template for more information
Console.Write("Enter a real number : ");
int userNumber = int.Parse(Console.ReadLine());
if ((userNumber >= 2 && userNumber < 3) || (userNumber > 0 && userNumber <= 1) ||
    (userNumber >= -10 && userNumber <= -2))
{
    Console.Write($" x belongs to I ... ");
}
else
{
    Console.Write(" X does not belong to I...");
}
    