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
        /**
         * String used to identify a Talisman object.
         */
        public static String TALISMAN = "Talisman";
        public static Deck CreateDeck( DeckType type)
        {
            Queue<Card> cards = new Queue<Card>();
            switch (type)
            {
                case DeckType.ADVENTURE:
                    createAdventureDeck(cards);
                    break;
                case DeckType.SPELL:
                    createSpellDeck(cards);
                    break;
                case DeckType.SHOP:
                    createShopDeck(cards);
                    break;
                case DeckType.TALISMAN:
                    createTalismanDeck(cards);
                    break;
                default:
                    break;
            }
            return new Deck(type, cards);
        }

        private static Queue<Card> createSpellDeck(Queue<Card> cards)
        {
            //cards.Enqueue(TalismanDeckFactory.createCard("bag of gold", "get 1 gold", "BagOfGold", CardType.OBJECT,
            //         new List<ITalismanAction> { new TalismanModifyStatisticAction(-1, TalismanActionStatistic.GOLD) }));
            return cards;
        }

        private static Queue<Card> createAdventureDeck(Queue<Card> cards)
        {
            //cards.Enqueue(TalismanDeckFactory.createCard("bag of gold", "get 1 gold", "BagOfGold", CardType.OBJECT,
            //        new List<ITalismanAction> { new TalismanModifyStatisticAction(-1, TalismanActionStatistic.GOLD) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Pitfiend", "Pitfiend", "Pitfiend", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(0) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Wild Boar", "Enemy", "WildBoar", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(1) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Wolf", "Enemy", "Wolf", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(2) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Serpent", "Enemy", "Serpent", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(3) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Dragon", "Enemy", "Dragon", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(4) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Lemure", "Enemy", "Lemure", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(5) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Shadow", "Enemy", "Shadow", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(6) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Wraith", "Enemy", "Wraith", CardType.ENEMY,
                    new List<ITalismanAction> { new TalismanFightAction(7) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Mule", "Follower ", "Mule", CardType.FOLLOWER,
                    new List<ITalismanAction> { new TalismanFightAction(8) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Maiden", "Follower, Add 2 to your craft", "Maiden", CardType.FOLLOWER,
                    new List<ITalismanAction> { new TalismanFightAction(9) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Sword", "Equipment ", "Sword", CardType.OBJECT,
                    new List<ITalismanAction> { new TalismanFightAction(10) }));
            cards.Enqueue(TalismanDeckFactory.createCard("Magic Sword", "Equipment ", "MagicSword", CardType.OBJECT,
                    new List<ITalismanAction> { new TalismanFightAction(0) }));
            cards.Concat(cards);
            return cards;
        }

        private static Queue<Card> createShopDeck(Queue<Card> cards)
        {
            //cards.Enqueue(TalismanDeckFactory.createCard("Axe", "Equipment", "Axe", CardType.OBJECT,
            //        List.of(new TalismanModifyStatisticAction(2, TalismanActionStatistic.STRENGTH))));
            //cards.Enqueue(TalismanDeckFactory.createCard("Sword", "Equipment ", "Sword", CardType.OBJECT,
            //        List.of(new TalismanModifyStatisticAction(1, TalismanActionStatistic.STRENGTH))));
            //cards.Enqueue(TalismanDeckFactory.createCard("Magic Sword", "Equipment ", "MagicSword", CardType.OBJECT,
            //        List.of(new TalismanModifyStatisticAction(1, TalismanActionStatistic.CRAFT))));
            return cards;
        }

        private static Queue<Card> createTalismanDeck(Queue<Card> cards)
        {
           // cards.Enqueue(TalismanDeckFactory.createCard(TALISMAN, "One of the legendary talismans", "Talisman",
           //         CardType.OBJECT, List.of(new TalismanEmptyAction())));
            cards.Concat(cards);
            cards.Concat(cards);
            return cards;
        }

        public static Card createCard(String name, String text, String imageName,  CardType type,
                 IEnumerable<ITalismanAction> actions)
        {
            return Card.createCard(name, text, PathUtils.getPathToCard(type, imageName), type, actions);
        }
    }
}
