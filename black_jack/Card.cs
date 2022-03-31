using System;
using System.Collections.Generic;


public class Card
{
    private string number;
    private string symbol;
    // private string colour;
    private int Points { get; set; }

    // Deck d = new Deck();
    // private Random generator;

    // List<string> numberList = new List<string>();


    public Card(string aSymbol, string aNumber)
    {
        number = aNumber;
        symbol = aSymbol;
        // colour = aColour;

    }

    public void PrintInfo()
    {
        Console.WriteLine($"Det här kortet är {symbol} {number}");

    }








}
