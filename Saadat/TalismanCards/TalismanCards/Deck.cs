using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalismanCards
{
    class Deck : IDeck
    {
        private Queue<Card> cards;
        private DeckType type;
        public int NumberOfCards => cards.Count;

        public DeckType Type => type;

        public IList<Card> Cards => (IList<Card>) cards;

        public Card Draw()
        {
            return cards.Dequeue();
        }

        public void Shuffle()
        {
            //TODO 
           //cards.OrderBy
        }
    }
}
