using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public interface IPopulatedBoard<S, C, P> : IBoard<S, C> where S: IBoardSection<C> where C: IBoardCell where P: IBoardPawn
    {
        int PawnsCount { get; }

        P GetPawn(int index);
        int GetPawnCell(int player);
        int GetPawnSection(int player);
        void MovePawnTo(int player, int cell);
        void ChangePawnSection(int player, int section);
        void ChangePawnSection(int player, int section, int cell);
    }
}
