using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public interface IBoard<S, C> where S: IBoardSection<C> where C: IBoardCell
    {
        S this[int index] { get; }

        int SectionsCount { get; }
    }
}
