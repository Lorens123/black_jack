using System.Dynamic;
using System;


public class Player
{
    private int startCapital = 1000;
    private string name = "";
    public int myPoints = 0;




    Deck myDeck = new Deck();


    public Player()
    {

        if (myPoints > 21)
        {
            Console.WriteLine("Du har förlorat");
        }
        if (myPoints == 21)
        {
            Console.WriteLine("BlackJack!! Du vann!!");
        }
    }

    // Metod för att sköta bettningen
    public void Bet(int amountMoney)
    {

    }
    // Användarens egna kortlek
    public void MyPoints()
    {

    }







}
