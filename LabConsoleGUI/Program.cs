// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Globalization;
using System.Text;

int leftMargin = 7;
int topMargin = 2;
int size = 18;
Console.CursorLeft = (leftMargin + 3);
Console.WriteLine("Hello, Console GUI!\n");
Console.WriteLine();

for (int i = 0; i < ((size + 1)/2); i++){
    Console.CursorTop = topMargin + i;
    Console.BackgroundColor = (i % 2 == 0) ? ConsoleColor.Blue : ConsoleColor.Cyan;
    for (int j = 0; j < size - 2 * i; j++) {
        Console.CursorLeft = leftMargin + 2 * i;
        Console.WriteLine(new string(' ', (size - 2 * i) * 2));
    }
}

Console.BackgroundColor= ConsoleColor.Black;
Console.CursorTop = size + 2;

