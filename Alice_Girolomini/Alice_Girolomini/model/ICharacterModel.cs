using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Interface that models the characters.</summary>
    public interface ICharacterModel
    {
        /// <summary>Gets the amount of health points.</summary>
        /// <returns>the value</returns>
        int GetHealth();

        /// <summary>Gets the number of strength points.</summary>
        /// <returns>the value</returns>
        int GetStrength();

        /// <summary>Gets the number of craft points.</summary>
        /// <returns>the value</returns>
        int GetCraft();

        /// <summary>Gets the number of fate coins.</summary>
        /// <returns>the value</returns>
        int GetFate();

        /// <summary>Gets the amount of gold.</summary>
        /// <returns>the value</returns>
        int GetGold();

        /// <summary>Sets the amount of health.</summary>
        /// <param name="points">the value</param>
        void SetHealth(int points);

        /// <summary>Sets strength points value.</summary>
        /// <param name="points">the value to be set</param>
        void SetStrength(int points);

        /// <summary>Sets craft points value.</summary>
        /// <param name="points">the value to be set</param>
        void SetCraft(int points);

        /// <summary>Sets fate points value.</summary>
        /// <param name="coins">the value to be set</param>
        void SetFate(int coins);

        /// <summary>Sets the amount of gold.</summary>
        /// <param name="coins">the value to be set</param>
        void SetGold(int coins);
    }
}
