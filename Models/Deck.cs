using System;
using System.Collections.Generic;
namespace deck.Models
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>{};
        public Deck()
        {
            string[] stringVal = new string[]{"2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"};
            string[] suit = new string[]{"Clubs","Spades","Hearts","Diamonds"};
            for (int j=0 ; j<suit.Length ; j++)
            {
                for (int i = 0; i<stringVal.Length; i++)
                {
                    Cards.Add(new Card(stringVal[i],suit[j],i+1));
                }
            } 
        }
        public void ReadDeck()
        {   
            System.Console.WriteLine("**************************************");
            foreach (Card card in Cards)
            {
                card.ReadCard();
            }
        }
        public Deck CheckQuantity()
        {   
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"Has {Cards.Count} cards left in the Deck");
            return this;
        }
        public Deck DrawOne()
        {   
            System.Console.WriteLine("**************************************");
            if (Cards.Count==0){
                System.Console.WriteLine("No more card to draw");
            }
            else
            {   
                System.Console.WriteLine($"{Cards[0].StringVal} of {Cards[0].Suit} is drawed");
                Cards.Remove(Cards[0]);
            }
            return this;
        }

        public Deck Shuffle()
        {   
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine("Deck shuffled");
            for ( int i = 0 ; i<Cards.Count ; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0,Cards.Count-1);
                Card temp = Cards[i];
                Cards[i] = Cards[index];
                Cards[index] = temp;
            }
            return this;
        }

        public Deck Reset()
        {   
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine("Deck is reseted");
            Deck newdeck = new Deck();
            Cards = newdeck.Cards;
            return this;
        }
    }
}