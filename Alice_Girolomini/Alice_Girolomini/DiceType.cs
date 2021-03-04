using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Enum type that specifies if the player needs one or two dices</summary>
    public enum DiceType { SIX = 6, DOUBLE_SIX = 12 }

    static class DiceExtension
    {

        public static int GetMinValue(this DiceType diceType)
        {
            return (int)diceType/(int)DiceType.SIX;
        }

        public static int GetFaces(this DiceType diceType)
        {
            return (int)diceType;
        }
    }
}
