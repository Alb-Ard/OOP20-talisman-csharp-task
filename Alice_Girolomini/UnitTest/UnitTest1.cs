using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alice_Girolomini;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BattleModelTest()
        {
            //Initialization of the two characters
            int firstCharacterStrength = 3;
            int secondCharacterStrength = 4;
            IBattleModel battle = new BattleModelImpl(firstCharacterStrength, secondCharacterStrength);
            //Checks the state of the battle
            Assert.AreEqual(false, battle.IsEnded());
            //first rolls the die
            battle.DiceRoll(1);
            //second rolls the die
            battle.DiceRoll(2);
            //adds the roll to the initial score
            int firstCharacterScore = battle.GetDiceRoll(1) + firstCharacterStrength;
            int secondCharacterScore = battle.GetDiceRoll(2) + secondCharacterStrength;
            battle.CompareScore();
            Assert.AreEqual(firstCharacterScore, battle.GetScore(1) + battle.GetDiceRoll(1));
            Assert.AreEqual(secondCharacterScore, battle.GetScore(2) + battle.GetDiceRoll(2));
            Assert.AreEqual(true, battle.IsEnded());
        }
    }
}
