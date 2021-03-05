using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public class PopulatedBoard<S, C, P> : Board<S, C>, IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P: IBoardPawn
    {
        private readonly IList<P> pawns;

        public int PawnsCount => pawns.Count;

        public PopulatedBoard(IList<S> sections, IList<P> pawns) : base(sections)
        {
            this.pawns = new List<P>(pawns);
        }

        public P GetPawn(int index)
        {
            return pawns[index];
        }

        public int GetPawnCell(int player)
        {
            return GetPawn(player).PositionCell;
        }

        public int GetPawnSection(int player)
        {
            return GetPawn(player).PositionSection;
        }

        public void MovePawnTo(int player, int cell)
        {
            ChangePawnSection(player, GetPawnSection(player), cell);
        }

        public void ChangePawnSection(int player, int section)
        {
            ChangePawnSection(player, section, GetPawn(player).PositionCell);
        }

        public void ChangePawnSection(int player, int section, int cell)
        {
            GetPawn(player).SetPosition(section % SectionsCount, cell % this[section].CellsCount);
        }
    }
}
