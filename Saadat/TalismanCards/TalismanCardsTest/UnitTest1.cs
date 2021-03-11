using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TalismanCards;

namespace TalismanCardsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CardCountInAdventureDeck()
        {
            int expected = 13 * TalismanDeckFactory.CARDMULTIPLIER;
            int actual = TalismanDeckFactory.CreateDeck(DeckType.ADVENTURE).NumberOfCards;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CardCountInTalismanDeck()
        {
            int expected = 1 * TalismanDeckFactory.CARDMULTIPLIER;
            int actual = TalismanDeckFactory.CreateDeck(DeckType.TALISMAN).NumberOfCards;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CardCountInShopDeck()
        {
            int expected = 3 * TalismanDeckFactory.CARDMULTIPLIER;
            int actual = TalismanDeckFactory.CreateDeck(DeckType.SHOP).NumberOfCards;
            Assert.AreEqual(expected, actual);
        }

    }
}
