using System;
using System.Collections.Generic;

public class Deck
{
    // private int size;
    private Random generator = new Random();
    List<Card> cards = new List<Card>();
    public List<Card> GetCards()
    {
        return cards;
    }


    public Deck()
    {
        string[] suits = { "Spader", "Klöver", "Hjärter", "Ruter" };
        string[] numbers = { "Ess", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knekt", "Dam", "Kung" };

        // Detta betyder att alla kort från 2-10 har alla poäng för varje nummer. Ruter 5 är det 5 poäng
        // Kläda kort är värda 10
        // Ess är just nu värt 1 poäng och i blackjack så kan ess antingen bli 11 eller 1. För att en så kallad Blackjack krävs det 
        // 21 poäng
        foreach (string suit in suits)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i];

                int v = 0;
                if (i == 0) v = 1;
                else if (i > 9) v = 10;
                else v = int.Parse(number);


                cards.Add(new Card(suit, number, v));
            }

        }   // return valueDict[number];




    }

    // Här är koden för själva slumpandet av korten
    public Card Draw()
    {
        int i = generator.Next(0, cards.Count);
        Card card = cards[i];
        // card.PrintInfo();
        return card;
    }

}
