using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public enum CellType { Up, Down, Left, Right }

    public interface IBoardCell
    {
        string Text { get; }
        string ImagePath { get; }
        CellType CellOrientationType { get; }
    }
}
