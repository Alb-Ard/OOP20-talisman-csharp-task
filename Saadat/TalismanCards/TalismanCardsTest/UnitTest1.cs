using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TalismanCards;

namespace TalismanCardsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CardCountInDeck()
        {
            int expected = 24;
            int actual = TalismanDeckFactory.CreateDeck(DeckType.ADVENTURE).NumberOfCards;

            Assert.AreEqual(expected, actual);
        }
    }
}
