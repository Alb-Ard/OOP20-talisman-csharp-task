using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public class BoardSection<C> : IBoardSection<C> where C: IBoardCell
    {
        private readonly IList<C> cells;

        public C this[int index] => cells[index];

        public int CellsCount => cells.Count;

        public BoardSection(IList<C> cells)
        {
            this.cells = new List<C>(cells);
        }
    }
}
