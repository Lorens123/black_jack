
using System;
Console.WriteLine("Välkommen till Ultimate Black Jack Game");

Console.WriteLine("Tryck på space för att slumpa ett kort!");

while (Console.ReadKey().Key != ConsoleKey.Spacebar)
{
    Console.WriteLine("Tryck på space för att slumpa ett kort");
}

Deck deck = new Deck();


// Console.WriteLine(deck)
Card c = deck.Draw();


c.PrintInfo();



Console.ReadLine();
