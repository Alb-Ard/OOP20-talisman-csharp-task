namespace TalismanCSHARP.characters
{
    public interface ICharacterModel
    {
     
        /// <summary>
        /// Get current character's health
        /// </summary>
        /// <returns>the value</returns>
        ref int GetHealth();

        /// <summary>
        /// Get current character's strength
        /// </summary>
        /// <returns>the value</returns>
        ref int GetStrength();

        /// <summary>
        /// Get current character's craft points
        /// </summary>
        /// <returns>the value</returns>
        ref int GetCraft();

        /// <summary>
        /// Get current character's fate points
        /// </summary>
        /// <returns>the value</returns>
        ref int GetFate();

        /// <summary>
        /// Get current character's gold
        /// </summary>
        /// <returns>the value</returns>
        ref int GetGold();

        /// <summary>
        /// Set current character's health
        /// </summary>
        /// <param name="value">the value</param>
        void SetHealth(in int value);

        /// <summary>
        /// Set current character's strength
        /// </summary>
        /// <param name="value">the value</param>
        void SetStrength(in int value);

        /// <summary>
        /// Set current character's craft points
        /// </summary>
        /// <param name="value">the value</param>
        void SetCraft(in int value);
        
        /// <summary>
        /// Set current character's fate points
        /// </summary>
        /// <param name="value">the value</param>
        void SetFate(in int value);

        /// <summary>
        /// Set current character's gold
        /// </summary>
        /// <param name="value">the value</param>
        void SetGold(in int value);
    }
}