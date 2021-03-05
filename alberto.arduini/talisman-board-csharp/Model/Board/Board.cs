using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public class Board<S, C> : IBoard<S, C> where S : IBoardSection<C> where C : IBoardCell
    {
        private IList<S> sections;

        public S this[int index] => sections[index];

        public int SectionsCount => sections.Count;

        public Board(IList<S> sections)
        {
            this.sections = new List<S>(sections);
        }
    }
}
