using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalismanCards
{
    interface IDeck
    {
        Card Draw();
        int NumberOfCards { get; }
        DeckType Type { get; }
        void Shuffle();
        Queue<Card> Cards { get; }
    }
}
