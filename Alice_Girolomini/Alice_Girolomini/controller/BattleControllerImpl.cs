using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Girolomini
{
    /// <summary>The implementation of a MVC controller for the battle.</summary>
    class BattleControllerImpl : IBattleController
    {
        private static readonly int FIRSTTURN = 1;
        private static readonly int SECONDTURN = 2;
        private readonly IBattleModel model;
        private readonly ICharacterModel firstCharacter;
        private readonly ICharacterModel secondCharacter;
        private readonly List<int> countFate;
        private int turn;
        private bool roll;

        /// <summary>
        /// Initializes a new instance of the <see cref="BattleControllerImpl{ICharacterModel firstCharacter, ICharacterModel secondCharacter, IBattleModel model}"/> class.
        /// </summary>
        public BattleControllerImpl(ICharacterModel firstCharacter, ICharacterModel secondCharacter, IBattleModel model)
        {
            this.firstCharacter = firstCharacter;
            this.secondCharacter = secondCharacter;
            this.model = model;
            this.turn = 1;
            this.roll = true;
            countFate = new List<int>(2);
            for (int i = 0; i < 2; i++)
            {
                countFate.Add(0);
            }
        }

        /// <summary>Checks which character is fighting.</summary>
        private ICharacterModel CheckTurn()
        {
            if (this.turn == FIRSTTURN)
            {
                return this.firstCharacter;
            }
            return this.secondCharacter;
        }

        /// <summary>Changes the current turn of the battle.</summary>
        private void ChangeTurn()
        {
            if (turn == FIRSTTURN)
            {
                this.turn = SECONDTURN;
            }
        }

        /// <inheritdoc />
        public bool CanRoll()
        {
            return this.roll;
        }

        /// <inheritdoc />
        public IBattleModel GetBattle()
        {
            return this.model;
        }

        /// <inheritdoc />
        public ICharacterModel GetFirstCharacter()
        {
            return this.firstCharacter;
        }

        /// <inheritdoc />
        public BattleState GetResult()
        {
            if (this.model.IsEnded())
            {
                if (this.model.GetState() == BattleState.FIRST)
                {
                    this.secondCharacter.SetHealth(this.secondCharacter.GetHealth() - 1);
                    //checkDeath(this.secondCharacter);
                }
                else if (this.model.GetState() == BattleState.SECOND)
                {
                    this.firstCharacter.SetHealth(this.firstCharacter.GetHealth() - 1);
                    //checkDeath(this.firstCharacter);
                }
            }
            return this.model.GetState();
        }

        /// <inheritdoc />
        public ICharacterModel GetSecondCharacter()
        {
            return this.secondCharacter;
        }

        /// <inheritdoc />
        public int GetTurn()
        {
            return this.turn;
        }

        /// <inheritdoc />
        public KeyValuePair<int, int> InitializeScores()
        {
            KeyValuePair<int, int> values = new KeyValuePair<int, int>(this.model.GetScore(1), this.model.GetScore(2));
            return values;
        }

        /// <inheritdoc />
        public int RequestedAttack()
        {
            int score = UpdateScore();
            this.roll = true;
            if (this.turn == SECONDTURN)
            {
                this.model.CompareScore();
            }
            ChangeTurn();
            return score;
        }

        /// <inheritdoc />
        public bool RequestedFate()
        {
            ICharacterModel character = CheckTurn();
            if (character.GetFate() > 0 && this.countFate[GetTurn()-1] == 0)
            {
                return true;
            }
            return false;
        }

        /// <inheritdoc />
        public void UpdateFate()
        {
            if (this.countFate[GetTurn() - 1] == 0)
            {
                this.roll = true;
                ICharacterModel character = CheckTurn();
                character.SetFate(character.GetFate() - 1);
                this.countFate.Insert(this.turn - 1, -1);
            }
        }

        /// <inheritdoc />
        public int UpdateRoll()
        {
            this.roll = false;
            this.model.DiceRoll(this.turn);
            return this.model.GetDiceRoll(this.turn);
        }

        /// <inheritdoc />
        public int UpdateScore()
        {
            this.model.SetScore(this.turn, this.model.GetScore(this.turn) + this.model.GetDiceRoll(this.turn));
            return this.model.GetScore(this.turn);
        }
    }
}
