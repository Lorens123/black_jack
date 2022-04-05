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

        // for (int i = 1; i < 10; i++)
        // {

        // }

        // Detta betyder att alla kort från 2-10 har alla poäng för varje nummer. Ruter 5 är det 5 poäng
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


            // foreach (string number in numbers)
            // {
            //     // Console.WriteLine($"Kortet jag skapar nu är {suit} {number}");

            //     if ()

            //     // Draw();
            // }
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
