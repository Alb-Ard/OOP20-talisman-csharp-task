using System.Collections.Generic;

namespace Talisman.Model.Board
{
    public class TalismanBoard : PopulatedBoard<TalismanBoardSection, TalismanBoardCell, TalismanBoardPawn>
    {
        public TalismanBoard(IList<TalismanBoardSection> sections, IList<TalismanBoardPawn> pawns) : base(sections, pawns)
        {
        }
    }
}