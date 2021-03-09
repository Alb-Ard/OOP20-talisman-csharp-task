using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public interface IBoardPawn
    {
        string ImagePath { get; }
        int Index { get; }
        int PositionSection { get; }
        int PositionCell { get; }

        void SetPosition(int section, int cell);
    }
}
