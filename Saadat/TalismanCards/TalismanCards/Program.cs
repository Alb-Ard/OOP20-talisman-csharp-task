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

            Console.WriteLine(TalismanDeckFactory.CreateDeck(DeckType.ADVENTURE));
            Console.In.Read();
        }
    }
}
