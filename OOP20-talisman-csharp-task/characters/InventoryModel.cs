using System;
using System.Collections.Generic;
using TalismanCSHARP.cards;
using TalismanCSHARP.characters.exceptions;

namespace TalismanCSHARP.characters
{
    public class InventoryModel : IInventoryModel
    {
        private List<Card> cards = new List<Card>();
        
        public void AddCard(ref Card card)
        {
            if (Size() < 4) cards.Add(card);
            else throw new NotEnoughSpaceInventoryException();
        }

        public void RemoveCard(ref int index)
        {
            cards.RemoveAt(index);
        }

        public void RemoveCard(ref Card card)
        {
            cards.Remove(card);
        }

        public ref List<Card> ListCards()
        {
            return ref cards;
        }

        public bool HasMule()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return cards.Count;
        }
    }
}