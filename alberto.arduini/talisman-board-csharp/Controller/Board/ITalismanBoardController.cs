using System;
using System.Collections.Generic;

using Talisman.Model.Board;
using Talisman.Model.Card;

namespace Talisman.Controller.Board
{
    public interface ITalismanBoardController : IPopulatedBoardController<TalismanBoard, TalismanBoardSection, TalismanBoardCell, TalismanBoardPawn>
    {
        event Action ActionEnded;

        void ApplyCurrentCellAction();
        ISet<int> GetCurrentCharacterOpponents();
        Optional<ICard> RemoveCurrentCard();
        void SetCurrentCharacterCellCard(ICard card);
        void TryCollectCurrentCard();
    }
}