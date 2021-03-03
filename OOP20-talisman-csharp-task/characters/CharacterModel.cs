using TalismanCSHARP.characters.defaultcharacters;

namespace TalismanCSHARP.characters
{
    public class CharacterModel : ICharacterModel
    {
        private int _health;
        private int _strength;
        private int _craft;
        private int _fate;
        private int _gold;

        private readonly InventoryModel _inventory = new InventoryModel();
        private readonly CharacterType _type;

        public CharacterModel(in int health, in int strength, in int craft, in int fate, in int gold, in CharacterType type)
        {
            _health = health;
            _strength = strength;
            _craft = craft;
            _fate = fate;
            _gold = gold;
            _type = type;
        }
        
        public ref int GetHealth()
        {
            return ref _health;
        }

        public ref int GetStrength()
        {
            return ref _strength;
        }

        public ref int GetCraft()
        {
            return ref _craft;
        }

        public ref int GetFate()
        {
            return ref _fate;
        }

        public ref int GetGold()
        {
            return ref _gold;
        }

        public void SetHealth(in int value)
        {
            _health = value;
        }

        public void SetStrength(in int value)
        {
            _strength = value;
        }

        public void SetCraft(in int value)
        {
            _craft = value;
        }

        public void SetFate(in int value)
        {
            _fate = value;
        }

        public void SetGold(in int value)
        {
            _gold = value;
        }

        /// <summary>
        /// Returns the instance of the character's inventory
        /// </summary>
        /// <returns>the instance of the inventory</returns>
        public InventoryModel GetInventory()
        {
            return _inventory;
        }

        /// <summary>
        /// Returns the the type of the base character
        /// </summary>
        /// <returns>the character's type</returns>
        public new CharacterType GetType()
        {
            return _type;
        }
    }
}