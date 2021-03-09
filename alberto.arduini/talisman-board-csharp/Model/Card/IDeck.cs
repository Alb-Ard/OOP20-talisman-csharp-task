using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Card
{
    public enum DeckType { Adventure, Talisman, Shop }

    interface IDeck
    {
        DeckType Type { get; }
    }
}
