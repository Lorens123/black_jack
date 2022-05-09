
using System;
Console.WriteLine("Välkommen till Ultimate Black Jack Game");

Console.WriteLine("Tryck på space för att slumpa ett kort!");
Deck deck = new Deck();
bool game = true;
Player p1 = new Player();
Player p2 = new Opponent();

while (game)
{
    while (Console.ReadKey().Key != ConsoleKey.Spacebar)
    {

        Console.WriteLine("Tryck på space för att slumpa ett kort");
    }

    // Drar korten man får
    p1.MyDeck();


    // Skriver ut info om kortet och poängen du har fått
    // p1.myPoints += c.Value;

    Console.WriteLine($"Du har {p1.myPoints} poäng");
    Console.WriteLine($"Banken drar ett kort. Tryck Enter");
    game = p1.MyPoints();

    while (Console.ReadKey().Key != ConsoleKey.Spacebar)
    {

        Console.WriteLine("Tryck på space för att slumpa bankens kort");
    }
    p2.MyDeck();
    Console.WriteLine($"Banken har {p2.myPoints} poäng");
    Console.WriteLine($"Du drar ett nytt kort. Tryck Enter");
    game = p2.MyPoints();


}

Console.ReadLine();

// Essens poäng funkar
// Banken funkar och drar kort