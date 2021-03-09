using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Interface that models battles.</summary>
    public interface IBattleModel
    {
        /// <summary>Calculates the opponent's dice roll.</summary>
        /// <param name="character" >the opponent</param>
        void DiceRoll(int character);

        /// <summary>Compares the opponents' scores.</summary>
        void CompareScore();

        /// <summary>Checks whether the battle is ended or not.</summary>
        /// <returns>true if the battle is ended</returns>
        bool IsEnded();

        /// <summary>Gets the current state of the battle.</summary>
        /// <returns>the current BattleState</returns>
        BattleState GetState();

        /// <summary>Gets the current score for the specified character.</summary>
        /// <param name="character">the character</param>
        /// <returns>the value</returns>
        int GetScore(int character);

        /// <summary>Gets the value of the last dice roll from the specified opponent.</summary>
        /// <param name="character">the opponent</param>
        /// <returns>the value</returns>
        int GetDiceRoll(int character);

        /// <summary>Sets the opponent's score.</summary>
        /// <param name="character">the opponent</param>
        /// <param name="value">the value to be set</param>
        void SetScore(int character, int value);

    }
}
