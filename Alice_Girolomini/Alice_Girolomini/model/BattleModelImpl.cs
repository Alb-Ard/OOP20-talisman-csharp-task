using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>Implementation of the model of the battle.</summary>
    public class BattleModelImpl : IBattleModel
    {
        private int firstCharScore;
        private int secondCharScore;
        private int firstDice;
        private int secondDice;
        private BattleState currentState;
        private bool end;

        /// <summary>
        /// Initializes a new instance of the <see cref="BattleModelImpl{int firstCharScore, int secondCharScore}"/> class.
        /// </summary>
        public BattleModelImpl(int firstCharScore, int secondCharScore)
        {
            this.firstCharScore = firstCharScore;
            this.secondCharScore = secondCharScore;
            this.firstDice = 0;
            this.secondDice = 0;
            this.currentState = BattleState.START;
            this.end = false;
        }

        /// <inheritdoc />
        public void CompareScore()
        {
            if (this.firstCharScore > this.secondCharScore)
            {
                this.currentState = BattleState.FIRST;
            }
            else if (this.firstCharScore < this.secondCharScore)
            {
                currentState = BattleState.SECOND;
            }
            else if (this.firstCharScore == this.secondCharScore)
            {
                this.currentState = BattleState.STAND_OFF;
            }
            this.end = true;
        }

        /// <inheritdoc />
        public void DiceRoll(int character)
        {
            if (character == 1)
            {
                this.firstDice = DiceUtils.RollDice(DiceType.SIX);
            }
            else
            {
                this.secondDice = DiceUtils.RollDice(DiceType.SIX);
            }
        }

        /// <inheritdoc />
        public int GetDiceRoll(int character)
        {
            if (character == 1)
            {
                return this.firstDice;
            }
            return this.secondDice;
        }

        /// <inheritdoc />
        public int GetScore(int character)
        {
            if (character == 1)
            {
                return this.firstCharScore;
            }
            return this.secondCharScore;
        }

        /// <inheritdoc />
        public BattleState GetState()
        {
            return this.currentState;
        }

        /// <inheritdoc />
        public bool IsEnded()
        {
            return this.end;
        }

        /// <inheritdoc />
        public void SetScore(int character, int value)
        {
            if (character == 1)
            {
                this.firstCharScore = value;
            }
            else
            {
                this.secondCharScore = value;
            }
        }
    }
}
