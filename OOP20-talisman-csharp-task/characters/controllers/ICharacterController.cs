using System.Collections.Generic;

namespace TalismanCSHARP.characters.controllers
{
    public interface ICharacterController
    {
        /**
     * Gets an instance of the player who is their turn to play
     *
     * @return the player
     */
        PlayerModel GetCurrentPlayer();

        /**
     * Gets the amount of players currently registered in the game session
     *
     * @return the amount of players
     */
        int GetActivePlayers();

        /**
     * Sets the player who is their turn to play
     *
     * @param index The id of the player
     */
        void SetCurrentPlayer(int index);

        /**
     * Add a player to the game
     *
     * @param character the instance of the player
     */
        void AddPlayer(CharacterModel character);

        /**
     * Remove a player from the game
     *
     * @param index the id of the player
     */
        void RemovePlayer(int index);

        /**
     * Get all the registered players
     *
     * @return the array of players
     */
        List<PlayerModel> GetPlayers();

        /**
     * Gets the player who currently owns a crown
     *
     * @return the instance of the player or null if no player
     */
        PlayerModel GetCrownPlayer();
    }
}