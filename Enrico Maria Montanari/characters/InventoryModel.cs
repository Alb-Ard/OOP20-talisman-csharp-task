using System;
using System.Collections.Generic;
using TalismanCSHARP.cards;
using TalismanCSHARP.characters.exceptions;

namespace TalismanCSHARP.characters
{
    public class InventoryModel : IInventoryModel
    {
        private List<Card> _cards = new List<Card>();
        
        public void AddCard(ref Card card)
        {
            if (Size() < 4) _cards.Add(card);
            else throw new NotEnoughSpaceInventoryException();
        }

        public void RemoveCard(ref int index)
        {
            _cards.RemoveAt(index);
        }

        public void RemoveCard(ref Card card)
        {
            _cards.Remove(card);
        }

        public ref List<Card> ListCards()
        {
            return ref _cards;
        }

        public bool HasMule()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return _cards.Count;
        }
    }
}