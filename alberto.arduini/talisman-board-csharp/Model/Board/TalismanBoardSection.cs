using System.Collections.Generic;

namespace Talisman.Model.Board
{
    public class TalismanBoardSection : BoardSection<TalismanBoardCell>
    {
        public TalismanBoardSection(IList<TalismanBoardCell> cells) : base(cells)
        {
        }
    }
}