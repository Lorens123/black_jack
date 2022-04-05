using System.Xml.Serialization;
using System;
using System.Collections.Generic;


public class Card
{
    private string number;
    private string symbol;
    // private string colour;
    private int Points { get; set; }
    Dictionary<string, int> valueDict = new Dictionary<string, int>();



    public Card(string aSymbol, string aNumber, int points)
    {
        number = aNumber;
        symbol = aSymbol;
        // colour = aColour;
        Points = points;

    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ditt kort är {symbol} {number}");
        Console.WriteLine($"Du har {Points} poäng");

    }

    public void GetPoints()
    {
        // return valueDict[number];
        if (Points! <= 21)
        {
            Console.WriteLine("Tryck space");
        }



    }






}
