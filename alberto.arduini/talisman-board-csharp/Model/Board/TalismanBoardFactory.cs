using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talisman.Model.Action;

namespace Talisman.Model.Board
{
    public static class TalismanBoardFactory
    {
        public static ITalismanBoard CreateDefaultBoard()
        {
            // For testing i create for identical sections instead of four unique ones
            IList<TalismanBoardSection> sections = new List<TalismanBoardSection>() {
                CreateTestSection(),
                CreateTestSection(),
                CreateTestSection(),
                CreateTestSection(),
            };
            // Since there is no game startup sequence the pawns are hard-coded
            IList<TalismanBoardPawn> pawns = new List<TalismanBoardPawn>()
            {
                new TalismanBoardPawn(0, ""),
                new TalismanBoardPawn(1, ""),
                new TalismanBoardPawn(2, ""),
            };
            return new TalismanBoard(sections, pawns);
        }

        private static TalismanBoardSection CreateTestSection()
        {
            return new TalismanBoardSection(new List<TalismanBoardCell>()
            {
                CreateCell("TestUp", "", CellType.Up, TalismanCellType.Biome, CreateTestActions()),
                CreateCell("TestRight", "", CellType.Right, TalismanCellType.Biome, CreateTestActions()),
                CreateCell("TestDown", "", CellType.Down, TalismanCellType.Biome, CreateTestActions()),
                CreateCell("TestLeft", "", CellType.Left, TalismanCellType.Biome, CreateTestActions()),
            });
        }

        private static TalismanBoardCell CreateCell(string text, string image, CellType type, TalismanCellType talismanType, IList<ITalismanAction> actions)
        {
            return new TalismanBoardCell(text, image, type, talismanType, actions);
        }

        private static IList<ITalismanAction> CreateTestActions()
        {
            return new List<ITalismanAction>() { new TalismanMoveAction(1, 1) };
        }
    }
}
