using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalismanCards
{
    public interface ICard
    {
        String Name { get; }
        String Text { get; }
        String ImagePath { get; }
        CardType Type { get; }
    }

}
