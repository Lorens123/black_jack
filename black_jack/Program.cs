
using System;




Console.WriteLine("Välkommen till Ultimate Black Jack Game");

Console.WriteLine("Tryck på space för att slumpa ett kort!");
Deck deck = new Deck();

bool game = true;
Player p1 = new Player();
Player p2 = new Opponent();

while (game)
{
    // Denna kod säger att man ska trycka Space för att kunna dra ett kort
    while (Console.ReadKey().Key != ConsoleKey.Spacebar)
    {

        Console.WriteLine("Fel inmatning");
    }

    // Drar korten man får


    Console.WriteLine("--------------------------------------------");
    p1.MyDeck();

    Console.WriteLine($"Du har {p1.myPoints} poäng");
    Console.WriteLine($"Banken drar ett kort. Tryck Space");
    game = p1.MyPoints();
    Console.WriteLine("-------------------------------------------");

    while (Console.ReadKey().Key != ConsoleKey.Spacebar)
    {

        Console.WriteLine("Tryck på space för att slumpa bankens kort");
    }


    p2.MyDeck();

    Console.WriteLine($"Banken har {p2.myPoints} poäng");
    Console.WriteLine($"Du drar ett nytt kort. Tryck Space");
    game = p2.MyPoints();
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Utmanare " + p1.myPoints + " - " + p2.myPoints + " Banken ");

    if (p1.cardsInHand == 5 || p2.cardsInHand == 5)
    {
        game = false;
    }

}

Console.ReadLine();

// Essens poäng funkar
// Banken funkar och drar kort