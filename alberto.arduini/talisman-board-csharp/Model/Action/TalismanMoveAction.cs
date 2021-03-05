using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Action
{
    public class TalismanMoveAction : ITalismanAction
    {
        public event System.Action OnApplied;

        private Tuple<int, int> destination;

        public string Description => "Skip your turn.";
        public bool CanBeApplied => true;
        public int Section => destination.Item1;
        public int Cell => destination.Item2;

        public TalismanMoveAction(int section, int cell)
        {
            destination = new Tuple<int, int>(section, cell);
        }

        public void Apply()
        {
        }
    }
}
