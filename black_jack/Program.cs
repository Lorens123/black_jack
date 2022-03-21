string[] suits = { "Spader", "Klöver", "Hjärter", "Ruter" };
string[] numbers = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
List<Card> cards = new List<Card>();

// foreach (string suit in suits)
// {
//     cards.Add(new Card(suit, "A"));
// }
foreach (string number in numbers)
{
    cards.Add(new Card("Spader", number));
    cards.Add(new Card("Klöver", number));
    cards.Add(new Card("Hjärter", number));
    cards.Add(new Card("Ruter", number));
}

Console.WriteLine(cards.Count);



Console.ReadLine();
