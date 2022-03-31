using System.Threading.Tasks.Dataflow;
Console.WriteLine("Tryck på tangentbordet för att slumpa ett kort!");


Deck deck = new Deck();

// Console.WriteLine(deck)
Card c = deck.Draw();
c.PrintInfo();




Console.ReadLine();
