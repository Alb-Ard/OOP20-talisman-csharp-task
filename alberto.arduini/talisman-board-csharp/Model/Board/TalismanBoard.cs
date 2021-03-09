using System.Collections.Generic;

namespace Talisman.Model.Board
{
    public class TalismanBoard : PopulatedBoard<TalismanBoardSection, TalismanBoardCell, TalismanBoardPawn>, ITalismanBoard
    {
        public TalismanBoard(IList<TalismanBoardSection> sections, IList<TalismanBoardPawn> pawns) : base(sections, pawns)
        {
        }
    }
}