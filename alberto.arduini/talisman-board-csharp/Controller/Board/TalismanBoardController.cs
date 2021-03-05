using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talisman.Controller.Character;
using Talisman.Model.Action;
using Talisman.Model.Board;
using Talisman.Model.Card;
using Talisman.View.Board;

namespace Talisman.Controller.Board
{
    public class TalismanBoardController : PopulatedBoardController<TalismanBoard, TalismanBoardSection, TalismanBoardCell, TalismanBoardPawn>, ITalismanBoardController
    {
        public event Action ActionEnded;

        public TalismanBoardController(TalismanBoard board, IBoardView view) : base(board, view)
        {
            for (int i = 0; i < Board.SectionsCount; i++)
            {
                TalismanBoardSection section = Board[i];
                for (int j = 0; j < section.CellsCount; j++)
                    foreach(ITalismanAction action in section[i].Actions)
                        action.OnApplied += () => ActionEnded?.Invoke();
            } 
        }

        public void ApplyCurrentCellAction()
        {
            GetCharacterCell(Controllers.CharacterController.CurrentPlayer).ApplyActions();
        }

        public void SetCurrentCharacterCellCard(ICard card)
        {
            GetCharacterCell(Controllers.CharacterController.CurrentPlayer).Card = card;
        }

        public void TryCollectCurrentCard()
        {
            Optional<ICard> card = RemoveCurrentCard();
            card.IfPresent(c => {
                Console.WriteLine($"Card {c.Name} collected!");
            });
        }

        public Optional<ICard> RemoveCurrentCard()
        {
            return Optional<ICard>.OfNullable(GetCharacterCell(Controllers.CharacterController.CurrentPlayer).Card);
        }

        public ISet<int> GetCurrentCharacterOpponents()
        {
            IBoardPawn pawn = GetCharacterPawn(Controllers.CharacterController.CurrentPlayer);
            ISet<int> cellPlayers = PopulatedBoardControllerExtensions.GetCharactersInCell(this, pawn.PositionSection, pawn.PositionCell);
            return new HashSet<int>(cellPlayers.Where(p => p != pawn.Index));
        }
    }
}
