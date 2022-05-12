using System.Dynamic;
using System;


public class Player
{
    private string name = "";
    public int myPoints = 0;
    public int cardsInHand = 0;
    private int startCapital = 1000;
    private int spendMoney = 0;

    Deck myDeck = new Deck();





    // Denna kod sköter funktionerna bakom spelarens deck.  
    public void MyDeck()
    {
        // Denna kod gör ett spelaren har sitt egna deck 
        Card c = myDeck.Draw();

        // Logiken om Ess. Koden säger om kortets värde är 1 poäng (Ess) medans spelarens poäng är lägre än 12, så blir 1 = 11 då blir esset värd 11 poäng
        // Det betyder om spelaren har 10 poäng i början så blir Ess 11 poäng och då blir det BlackJack (21 poäng).
        if (c.Value == 1 && myPoints <= 12)
        {
            c.Value = 11;
        }

        // Spelarens poäng adderas av kortens värde
        myPoints += c.Value;
        // Kontrollerar hur många kort spelarens hand har det är för att man ska inte kunna få mer en 5 kort. Koden betyder att ett kort adderas på din hand.  
        cardsInHand++;
        Console.WriteLine("Du har " + cardsInHand + " kort ");


        c.PrintInfo();
    }

    // Metod för att sköta bettningen där man i början av varje spel ska välja den summan man vill betta på.
    // Man kommer endast kunna betta (50, 100, 250, 500 och 1000). 
    // Twisten är om man satsar 1000 alltså hela capitalet får man dubbla summan tillbaka
    // Alltså 2000 om man vinner annars så blir man bankrupt
    public void Bet()
    {


    }
    // Poäng systemet för spelaren. 
    // Koden betyder om du får mer än 21 poäng så ska det stå "du har förlorat denna hand". Hand betyder ofta i kortspel en rond.
    // För att vinna så är det efter 5 kort dragningar ska man ha högst poäng om man är under 22. Om man får 21 poäng först så vinner man direkt
    public bool MyPoints()
    {

        if (myPoints > 21)
        {
            Console.WriteLine("Du har förlorat denna hand");


            return false;

        }
        else if (myPoints == 21)
        {
            Console.WriteLine("BlackJack!! Du vann denna hand!!");
            return false;
        }
        return true;
    }







}
