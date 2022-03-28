using System;
using System.Collections.Generic;


public class Card
{
    private string number;
    private string symbol;
    // private string colour;
    private int Points { get; set; }


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
        Console.WriteLine($"Kortet jag skapar nu är {symbol} {number}");

    }








}
