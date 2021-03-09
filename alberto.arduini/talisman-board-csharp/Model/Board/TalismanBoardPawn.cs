using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public class TalismanBoardPawn : IBoardPawn
    {
        private readonly int index;
        private readonly string imagePath;

        private Tuple<int, int> position;

        public string ImagePath => imagePath;
        public int Index => index;
        public int PositionCell => position.Item2;
        public int PositionSection => position.Item1;

        public TalismanBoardPawn(int index, string imagePath)
        {
            this.index = index;
            this.imagePath = imagePath;
            position = new Tuple<int, int>(0, 0);
        }

        public void SetPosition(int section, int cell)
        {
            position = new Tuple<int, int>(section, cell);
        }
    }
}
