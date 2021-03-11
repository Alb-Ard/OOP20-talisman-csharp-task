using System.Collections.Generic;
using TalismanCSHARP.cards;

namespace TalismanCSHARP.characters
{
    public interface IInventoryModel
    {
        /// <summary>
        /// Ass a card to the inventory
        /// </summary>
        /// <param name="card">instance of the card to add</param>
        void AddCard(ref Card card);

        /// <summary>
        /// Remove a card from the inventory
        /// </summary>
        /// <param name="index">index of the card in the inventory</param>
        void RemoveCard(ref int index);

        /// <summary>
        /// Remove a card from the inventory
        /// </summary>
        /// <param name="card">instance of the card to remove</param>
        void RemoveCard(ref Card card);

        /// <summary>
        /// List all the cards in the inventory
        /// </summary>
        /// <returns>a list of all the cards in the inventory</returns>
        ref List<Card> ListCards();

        /// <summary>
        /// Check if the player has the "Mule" card in his inventory
        /// </summary>
        /// <returns>true if the card is in the inventory</returns>
        bool HasMule();

        /// <summary>
        /// Returns how many cards are in the player's inventory
        /// </summary>
        /// <returns>the amount of cards</returns>
        int Size();
    }
}