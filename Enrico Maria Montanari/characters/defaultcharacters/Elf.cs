namespace TalismanCSHARP.characters.defaultcharacters
{
    public class Elf : IDefaultCharacter
    {
        public new CharacterType GetType()
        {
            return CharacterType.Elf;
        }

        public string[] GetLore()
        {
            throw new System.NotImplementedException();
        }

        public int GetHealth()
        {
            return 4;
        }

        public int GetStrength()
        {
            return 3;
        }

        public int GetCraft()
        {
            return 3;
        }

        public int GetFate()
        {
            return 3;
        }
    }
}