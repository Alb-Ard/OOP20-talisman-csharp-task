using System;
using System.Collections.Generic;

using Talisman.Model.Board;
using Talisman.Model.Card;
using Talisman.View.Board;

namespace Talisman.Controller.Board
{
    public interface ITalismanBoardController : IPopulatedBoardController<ITalismanBoard, TalismanBoardSection, TalismanBoardCell, TalismanBoardPawn>
    {
        event Action ActionEnded;

        void ApplyCurrentCellAction();
        ISet<int> GetCurrentCharacterOpponents();
        Optional<ICard> RemoveCurrentCard();
        void SetCurrentCharacterCellCard(ICard card);
        void TryCollectCurrentCard();
    }

    /// <summary>
    /// Since tdefault methods are available
    /// only from newer C# versions, this is needed
    /// to replace the factory method in the interface
    /// </summary>
    public static class TalismanBoardControllerFactory
    {
        public static ITalismanBoardController Create(ITalismanBoard model, IBoardView view)
        {
            return new TalismanBoardController(model, view);
        }
    }
}