using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalismanCards.Actions;
using TalismanCards.Utils;

namespace TalismanCards
{
    public class TalismanDeckFactory
    {
        public static String TALISMAN = "Talisman";
        public static int CARDMULTIPLIER = 4;
        public static Deck CreateDeck( DeckType type)
        {
            Queue<Card> cards = new Queue<Card>();
            switch (type)
            {
                case DeckType.ADVENTURE:
                    cards = CreateAdventureDeck(cards);
                    break;
                case DeckType.SPELL:
                    cards = CreateSpellDeck(cards);
                    break;
                case DeckType.SHOP:
                    cards = CreateShopDeck(cards);
                    break;
                case DeckType.TALISMAN:
                    cards = CreateTalismanDeck(cards);
                    break;
                default:
                    break;
            }
            return new Deck(type, cards);
        }

        private static Queue<Card> CreateSpellDeck(Queue<Card> cards)
        {
            for (int i = 0; i < CARDMULTIPLIER; i++)
            {
                cards.Enqueue(TalismanDeckFactory.CreateCard("bag of gold", "get 1 gold", "BagOfGold", CardType.OBJECT,
                     new List<ITalismanAction> { new TalismanModifyStatisticAction(-1, TalismanActionStatistic.GOLD) }));
            }
            return cards;
        }

        private static Queue<Card> CreateAdventureDeck(Queue<Card> cards)
        {
            for (int i = 0; i < CARDMULTIPLIER; i++)
            {
                cards.Enqueue(TalismanDeckFactory.CreateCard("bag of gold", "get 1 gold", "BagOfGold", CardType.OBJECT,
                    new List<ITalismanAction> { new TalismanModifyStatisticAction(-1, TalismanActionStatistic.GOLD) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Pitfiend", "Pitfiend", "Pitfiend", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(0) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Wild Boar", "Enemy", "WildBoar", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(1) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Wolf", "Enemy", "Wolf", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(2) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Serpent", "Enemy", "Serpent", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(3) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Dragon", "Enemy", "Dragon", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(4) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Lemure", "Enemy", "Lemure", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(5) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Shadow", "Enemy", "Shadow", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(6) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Wraith", "Enemy", "Wraith", CardType.ENEMY,
                        new List<ITalismanAction> { new TalismanFightAction(7) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Mule", "Follower ", "Mule", CardType.FOLLOWER,
                        new List<ITalismanAction> { new TalismanEmptyAction() }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Maiden", "Follower, Add 2 to your craft", "Maiden", CardType.FOLLOWER,
                        new List<ITalismanAction> { new TalismanModifyStatisticAction(2, TalismanActionStatistic.CRAFT) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Sword", "Equipment ", "Sword", CardType.OBJECT,
                        new List<ITalismanAction> { new TalismanModifyStatisticAction(1, TalismanActionStatistic.STRENGTH) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Magic Sword", "Equipment ", "MagicSword", CardType.OBJECT,
                        new List<ITalismanAction> { new TalismanModifyStatisticAction(1, TalismanActionStatistic.CRAFT) }));
            }
            return cards;
        }

        private static Queue<Card> CreateShopDeck(Queue<Card> cards)
        {
            for (int i = 0; i < CARDMULTIPLIER; i++)
            {
                cards.Enqueue(TalismanDeckFactory.CreateCard("Axe", "Equipment", "Axe", CardType.OBJECT,
                    new List<ITalismanAction> { new TalismanModifyStatisticAction(2, TalismanActionStatistic.STRENGTH) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Sword", "Equipment ", "Sword", CardType.OBJECT,
                        new List<ITalismanAction> { new TalismanModifyStatisticAction(1, TalismanActionStatistic.STRENGTH) }));
                cards.Enqueue(TalismanDeckFactory.CreateCard("Magic Sword", "Equipment ", "MagicSword", CardType.OBJECT,
                        new List<ITalismanAction> { new TalismanModifyStatisticAction(1, TalismanActionStatistic.CRAFT) }));
            }
            return cards;
        }

        private static Queue<Card> CreateTalismanDeck(Queue<Card> cards)
        {
            for(int i = 0; i<CARDMULTIPLIER; i++) 
            {
                cards.Enqueue(TalismanDeckFactory.CreateCard(TALISMAN, "One of the legendary talismans", "Talisman",
                        CardType.OBJECT, new List<ITalismanAction> { new TalismanEmptyAction() }));
            }
            return cards;
        }

        public static Card CreateCard(String name, String text, String imageName,  CardType type,
                 IEnumerable<ITalismanAction> actions)
        {
            return Card.createCard(name, text, PathUtils.getPathToCard(type, imageName), type, actions);
        }
    }
}
