using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalismanCards
{
    public class Deck : IDeck
    {
        private Queue<Card> cards;
        private DeckType type;
        public Deck(DeckType type, Queue<Card> cards)
        {
            this.type = type;
            this.cards = new Queue<Card>(cards);
        }
        public int NumberOfCards => cards.Count;

        public DeckType Type => type;

        public Queue<Card> Cards =>  cards;

        public Card Draw()
        {
            return cards.Dequeue();
        }

        public void Shuffle()
        {
            var rnd = new Random();
            cards = new Queue<Card>(cards.OrderBy(card => rnd.Next()));
        }
    }
}
