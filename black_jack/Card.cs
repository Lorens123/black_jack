using System.Xml.Serialization;
using System;
using System.Collections.Generic;


public class Card
{
    private string number;
    private string symbol;
    // private string colour;
    public int Value { get; set; }
    // Dictionary<string, int> valueDict = new Dictionary<string, int>();


    // Kortens struktur och karaktär
    public Card(string aSymbol, string aNumber, int points)
    {
        number = aNumber;
        symbol = aSymbol;
        // colour = aColour;
        Value = points;

    }

    public int GetPoints()
    {
        return Value;
    }
    // Denna kod skriver information om kortet som du har på handen. Samt värdet på kortet
    public void PrintInfo()
    {
        Console.WriteLine($"{symbol} {number}");
        // Console.WriteLine($"Du har {Value} poäng");



    }

    // public void GetPoints()
    // {
    //     // return valueDict[number];
    //     if (Value > 21)
    //     {
    //         Console.WriteLine("Du har förlorat!");
    //     }
    //     else if (Value == 21)
    //     {
    //         Console.WriteLine("Black Jack!!!! You won!!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Dra ett nytt kort tryck space igen!");
    //     }

    // }






}
