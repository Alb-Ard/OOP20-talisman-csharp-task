using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Board
{
    public class BoardCell : IBoardCell
    {
        private readonly string txt;
        private readonly string imgPath;
        private readonly CellType cellOrientationType;

        public string Text => txt; 
        public string ImagePath => imgPath;
        public CellType CellOrientationType => cellOrientationType;

        public BoardCell(string text, string imagePath, CellType cellType)
        {
            txt = text;
            imgPath = imagePath;
            cellOrientationType = cellType;
        }
    }
}
