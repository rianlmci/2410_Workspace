// See https://aka.ms/new-console-template for more information
using LabStruct;

Card [] cards = { 
    new Card(Rank.Queen, Suit.Spades),
    new Card(Rank.Ten, Suit.Diamonds)
};   

Console.WriteLine("Hello, Struct");

foreach (Card card in cards) {
    Console.WriteLine(card);
}

//press any key message
Console.WriteLine("\n\n");
Console.ForegroundColor = ConsoleColor.DarkGray;