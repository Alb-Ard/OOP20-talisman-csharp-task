using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>A MVC controller for the battle.</summary>
    interface IBattleController
    {
        /// <summary>Gets the model of the battle.</summary>
        /// <returns>the model of the battle</returns>
        IBattleModel GetBattle();

        /// <summary>Initializes the scores of the opponents in the view.</summary>
        /// <returns>the model</returns>
        KeyValuePair<int, int> InitializeScores();

        /// <summary>Gets the current turn.</summary>
        /// <returns>the turn</returns>
        int GetTurn();

        /// <summary>Checks whether the opponent can roll the dice or not.</summary>
        /// <returns>true if it's possible to roll the dice</returns>
        bool CanRoll();

        /// <summary>Gets the first opponent's model.</summary>
        /// <returns>the model of the opponent</returns>
        ICharacterModel GetFirstCharacter();

        /// <summary>Gets the second opponent's model.</summary>
        /// <returns>the model of the opponent</returns>
        ICharacterModel GetSecondCharacter();

        /// <summary>Gets the outcome of the battle.</summary>
        /// <returns>the state associated to the outcome of the battle</returns>
        BattleState GetResult();

        /// <summary>Checks whether the opponents can use a fate token.</summary>
        /// <returns>true if the character can use a fate token</returns>
        bool RequestedFate();

        /// <summary>Uses a fate token.</summary>
        void UpdateFate();

        /// <summary>Rolls the dice for one of the opponents.</summary>
        /// <returns>the result</returns>
        int UpdateRoll();

        /// <summary>Sums the score to the dice result for one of the opponents.</summary>
        /// <returns>the final score</returns>
        int UpdateScore();

        /// <summary>Updates the score and passes the turn.</summary>
        /// <returns>the final score</returns>
        int RequestedAttack();

    }
}
