using System;
using deck.Models;
namespace deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            Player One = new Player("Kenji");
            Player Two = new Player("Jin");
            
            d1.Shuffle().CheckQuantity();
            One.DrawCard(d1).DrawCard(d1).DrawCard(d1).DrawCard(d1).DrawCard(d1);
            Two.DrawCard(d1).DrawCard(d1).DrawCard(d1).DrawCard(d1).DrawCard(d1);
            d1.CheckQuantity();

            One.ReadHand().Discard(1).Discard(1).Discard(0).Discard(0).Discard(0).Discard(0).DrawCard(d1).Discard(0);
            One.ReadHand();
            


        }
    }
}
