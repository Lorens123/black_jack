using System;
using System.Collections.Generic;

public class Deck
{
    // private int size;
    private Random generator = new Random();
    List<Card> cards = new List<Card>();

    public Deck()
    {
        string[] suits = { "Spader", "Klöver", "Hjärter", "Ruter" };
        string[] numbers = { "Ess", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knekt", "Dam", "Kung" };

        foreach (string suit in suits)
        {
            foreach (string number in numbers)
            {
                // Console.WriteLine($"Kortet jag skapar nu är {suit} {number}");
                cards.Add(new Card(suit, number));
                // Draw();
            }
        }

    }

    public Card Draw()
    {
        int i = generator.Next(0, cards.Count);
        Card card = cards[i];
        // card.PrintInfo();
        return card;
    }

}
