using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Utility used to roll the dice</summary>
    class DiceUtils
    {
        private static readonly Random RAND = new Random();

        private DiceUtils()
        {
        }

        public static int RollDice(DiceType diceType)
        {
            return RAND.Next(DiceExtension.GetFaces(diceType) - DiceExtension.GetMinValue(diceType) + 1) + DiceExtension.GetMinValue(diceType);
        }
    }
}
