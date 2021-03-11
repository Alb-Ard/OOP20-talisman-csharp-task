using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalismanCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Il main del programma pesca una carta da un deck mischiato e mostra i valori della carta, a scopo di test aggiuntivo oltre a quelli di MSTest.
            var deck = TalismanDeckFactory.CreateDeck(DeckType.ADVENTURE);
            deck.Shuffle();
            var card = deck.Draw();
            Console.WriteLine(card.Name + "\n" + card.Text + "\n" + card.Type + "\n" + card.ImagePath);
            Console.ReadLine();
        }
    }
}
