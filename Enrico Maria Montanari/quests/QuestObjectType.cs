using System;

namespace TalismanCSHARP.quests
{
    public class QuestObjectType
    {

        private static Type _selectedType;

        public QuestObjectType(Type type)
        {
            _selectedType = type;
        }

        public QuestObjectType()
        {
            _selectedType = GetRandom();
        }

        public enum Type
        {
            FOLLOWER,
            TWO_COINS,
            THREE_COINS,
            MAGIC_OBJECT
        }
        
        private Type GetRandom()
        {
            switch (new Random().Next(4)){

                case 0:
                {
                    _selectedType = Type.FOLLOWER;
                    return Type.FOLLOWER;
                }
                case 1:
                {
                    _selectedType = Type.TWO_COINS;
                    return Type.TWO_COINS;
                }
                case 2:
                {
                    _selectedType = Type.THREE_COINS;
                    return Type.THREE_COINS;
                }
                case 3:
                {
                    _selectedType = Type.MAGIC_OBJECT;
                    return Type.MAGIC_OBJECT;
                }
            }

            return Type.FOLLOWER;
        }

        public Type GetType()
        {
            return _selectedType;
        }
        
        public String toString()
        {
            switch (_selectedType){

                case Type.FOLLOWER: return "Deliver (discard) 1 Follower";
                case Type.TWO_COINS: return "Deliver (discard) 2 Gold Coins";
                case Type.THREE_COINS: return "Deliver (discard) 3 Gold Coins";
                case Type.MAGIC_OBJECT: return "Deliver (discard) 1 Magic Object";
                default: return null;
            }
        }
    }
}