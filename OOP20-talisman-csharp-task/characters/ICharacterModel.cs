namespace TalismanCSHARP
{
    public interface ICharacterModel
    {
        /**
         * Get current character's health
         *
         * @return the value
         */
        ref int GetHealth();

        /**
         * Get current character's strength
         *
         * @return the value
         */
        ref int GetStrength();

        /**
         * Get current character's craft points
         *
         * @return the value
         */
        ref int GetCraft();

        /**
         * Get current character's fate points
         *
         * @return the value
         */
        ref int GetFate();

        /**
         * Get current character's gold
         *
         * @return the value
         */
        ref int GetGold();

        /**
         * Set current character's health
         *
         * @param the value
         */
        void SetHealth(in int value);

        /**
         * Set current character's strength
         *
         * @param the value
         */
        void SetStrength(in int value);

        /**
         * Set current character's craft points
         *
         * @param the value
         */
        void SetCraft(in int value);
        
        /**
         * Set current character's fate points
         *
         * @param the value
         */
        void SetFate(in int value);

        /**
         * Set current character's gold
         *
         * @param the value
         */
        void SetGold(in int value);
    }
}