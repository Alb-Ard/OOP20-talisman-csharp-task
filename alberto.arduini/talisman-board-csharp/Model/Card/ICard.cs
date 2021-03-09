using System.Collections.Generic;
using Talisman.Model.Action;

namespace Talisman.Model.Card
{
    public enum CardType { Item, Follower, Enemy }

    public interface ICard
    {
        IEnumerable<ITalismanAction> Actions { get; }
        CardType CardType { get; }
        string ImagePath { get; }
        string Name { get; }
    }
}