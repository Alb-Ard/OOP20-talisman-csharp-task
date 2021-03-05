using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Model.Action;

namespace Talisman.Model.Card
{
    /// <summary>
    /// <see cref="ICard"/> implentation that does nothing, is just to show the functionality of <see cref="Board.TalismanBoardCell"/>
    /// </summary>
    public class PlaceholderCard : ICard
    {
        private readonly string name;
        private readonly IEnumerable<ITalismanAction> actions;
        private readonly string imagePath;
        private readonly CardType cardType;

        public string Name => name;
        public IEnumerable<ITalismanAction> Actions => actions;
        public string ImagePath => imagePath;
        public CardType CardType => cardType;

        public PlaceholderCard(string name, string imagePath, CardType cardType, IEnumerable<ITalismanAction> actions)
        {
            this.name = name;
            this.actions = actions;
            this.imagePath = imagePath;
            this.cardType = cardType;
        }
    }
}
