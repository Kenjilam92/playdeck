using System.Collections.Generic;
namespace deck.Models
{
    public class Player 
    {
        public string Name;
        public List<Card> Hand = new List<Card>{};
        public Player (string name)
        {   
            Name=name;
        }
        public Player DrawCard (Deck a)
        {   
            System.Console.WriteLine("################################");
            System.Console.WriteLine($"{Name} is drawing");
            Hand.Add(a.Cards[0]);
            a.DrawOne();
            return this;
        }

        public Player ReadHand ()
        {
            System.Console.WriteLine("################################");
            System.Console.WriteLine($"Looking {Name}'s cards");
            if(Hand.Count==0)
            {
                System.Console.WriteLine($"{Name}'s hand is empty");
            }
            else
            {   
                System.Console.WriteLine($"{Name} has {Hand.Count} cards:");
                foreach (Card card in Hand)
                {
                    card.ReadCard();
                }
            }
            return this;   
        }

        public Player Discard (int index)
        {
            if (Hand.Count==0)
            {
                System.Console.WriteLine($"{Name} has nothing to discard");
            }
            else
            {    
                if (index > Hand.Count-1)
                {    
                    return null;
                }
                else 
                {
                    System.Console.Write($"{Name} discarded ");
                    Hand[index].ReadCard();
                    Hand.RemoveAt(index);
                }
            }
            return this;
        }
    }
}