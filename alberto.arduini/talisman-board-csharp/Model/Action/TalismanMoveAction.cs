using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talisman.Model.Action
{
    public class TalismanMoveAction : TalismanAction
    {
        private static readonly string[] SectionNames = new string[]
        {
            "Outer",
            "Middle",
            "Inner",
            "Crown",
        };

        private readonly Tuple<int, int> destination;

        public override string Description => $"Move to cell {Cell} in the {SectionNames[Section]} section";
        public int Section => destination.Item1;
        public int Cell => destination.Item2;

        public TalismanMoveAction(int section, int cell)
        {
            destination = new Tuple<int, int>(section, cell);
        }

        public override void Apply()
        {
            Controllers.BoardController.MoveCharacterSection(Controllers.CharacterController.CurrentPlayer, destination.Item1, destination.Item2);
            base.Apply();
        }
    }
}