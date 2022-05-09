using System;


// Opponent klassen skall vara en basklass för Banken och eventuellt en motståndare som är en person som man möter. 
// Tanken här är att detta Blackjack spel skall vara mer kamp och som ett spel.


// Om man väljer att spela med banken så är spelet endast att du försöker vinna mot banken med en mål summa eller förlora under en viss summa. 
// Här är målet att komma över 2000 poäng för att vinna mot banken. Om man kommer under 100 förlorar man.

// För multiplayern är reglerna lite breddare. Man ska nå över 5000 för att vinna och om man når 0 alltså bankrupt förlorar man.

public class Opponent : Player
{

    protected int startCapital = 1000;
    protected string name = "";
   

    
    // public int theirPoints = 0;


    
    
    
    // private 


}
