using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Model.Action;
using Talisman.Model.Card;

namespace Talisman.Model.Board
{
    public enum TalismanCellType { Biome, Zone, Enemy }

    public class TalismanBoardCell : BoardCell
    {
        private readonly TalismanCellType talismanType;
        private readonly IEnumerable<ITalismanAction> actions;

        private Optional<ICard> card;

        public TalismanCellType TalismanType => talismanType;
        public IEnumerable<ITalismanAction> Actions => new List<ITalismanAction>(actions);

        public ICard Card { get => card.Value; set => card = Optional<ICard>.Of(value); }

        public TalismanBoardCell(string text, string imagePath, CellType cellType, TalismanCellType talismanType, IEnumerable<ITalismanAction> actions) : base(text, imagePath, cellType)
        {
            this.actions = new List<ITalismanAction>(actions);
            this.talismanType = talismanType;
        }

        public void ClearCard()
        {
            card = Optional<ICard>.Empty();
        }

        public void ApplyActions()
        {
            Actions.ToList().ForEach(a => a.Apply());
        }
    }
}
