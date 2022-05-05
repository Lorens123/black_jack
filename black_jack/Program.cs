
using System;
Console.WriteLine("Välkommen till Ultimate Black Jack Game");

Console.WriteLine("Tryck på space för att slumpa ett kort!");
Deck deck = new Deck();
bool game = true;
Player p1 = new Player();

while (game)
{
    while (Console.ReadKey().Key != ConsoleKey.Spacebar)
    {

        Console.WriteLine("Tryck på space för att slumpa ett kort");
    }



    // Drar korten man får
    Card c = deck.Draw();
    // Skriver ut info om kortet och poängen du har fått
    p1.myPoints += c.Value;
    c.PrintInfo();
    Console.WriteLine($"Du har {p1.myPoints} poäng");
    Console.WriteLine($"Välj ett nytt kort. Tryck Enter");

    game = p1.MyPoints();


}

Console.ReadLine();