// See https://aka.ms/new-console-template for more information
using DemoEnum;

Console.WriteLine("Hello, Enum!");

Direction d = Direction.Up;
Console.WriteLine($"number value of d: {(int)d} char value of d: {(char)d}");

string [] directionNames = Enum.GetNames(typeof(Direction)); //get names 
Console.Write("All Directions: ");
foreach (string directionName in directionNames) {
    Console.Write($"{directionName} ");
}

Console.WriteLine();

Console.Write("All Values: ");
foreach (int value in Enum.GetValues(typeof(Direction)))
{
    Console.Write($"{value} ");
}

//press any key message
Console.WriteLine("\n\n");
Console.ForegroundColor = ConsoleColor.DarkGray;
