using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Model.Board;
using Talisman.View.Board;

namespace Talisman.Controller.Board
{
    public class PopulatedBoardController<B, S, C, P> : BoardController<B, S, C>, IPopulatedBoardController<B, S, C, P>
        where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P : IBoardPawn
    {
        public PopulatedBoardController(B board, IBoardView view) : base(board, view)
        {
        }

        public C GetCharacterCell(int player)
        {
            return GetCharacterSection(player)[GetCharacterPawn(player).PositionCell];
        }

        public P GetCharacterPawn(int player)
        {
            return Board.GetPawn(player);
        }

        public S GetCharacterSection(int player)
        {
            return Board[GetCharacterPawn(player).PositionSection];
        }

        public void MoveCharacterCell(int player, int cell)
        {
            MoveCharacterSection(player, GetCharacterPawn(player).PositionSection, cell);
        }

        public void MoveCharacterSection(int player, int section)
        {
            MoveCharacterSection(player, section, GetCharacterPawn(player).PositionCell);
        }

        public void MoveCharacterSection(int player, int section, int cell)
        {
            Board.ChangePawnSection(player, section, cell);
        }
    }
}
