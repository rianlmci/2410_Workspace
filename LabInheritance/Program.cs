// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Inheritance!");

using LabInheritance;

Pet[] pets = new Pet[] {
new Dog ("Snoopy"),
new Pet ("Furry"),
new Cat ( "Sylvester" )};

Console.WriteLine("= = = = = Pets before: = = = = =");
foreach (Pet pet in pets)
{
    Console.WriteLine($"{pet} says {pet.Communicate()}");
}
Array.Sort(pets);

Console.WriteLine(" = = = = = Pets after: = = = = = ");
foreach (Pet pet in pets)
{
    Console.WriteLine($"{pet} says {pet.Communicate()}");   
}

Console.WriteLine($"{((Dog)pets[1]).Fetch()}");


