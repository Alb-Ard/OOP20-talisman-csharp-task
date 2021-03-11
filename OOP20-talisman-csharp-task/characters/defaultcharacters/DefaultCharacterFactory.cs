namespace TalismanCSHARP.characters.defaultcharacters
{
    public class DefaultCharacterFactory
    {
        public static CharacterModel createAssassinCharacter()
        {
            Assassin assassin = new Assassin();
            
            return new CharacterModel(assassin.GetHealth(), assassin.GetStrength(), assassin.GetCraft(), assassin.GetFate(), 0, assassin.GetType());
        }

        public static CharacterModel createDruidCharacter()
        {
            Druid druid = new Druid();

            return new CharacterModel(druid.GetHealth(), druid.GetStrength(), druid.GetCraft(), druid.GetFate(), 0, druid.GetType());
        }

        public static CharacterModel createDwarfCharacter()
        {
            Dwarf dwarf = new Dwarf();

            return new CharacterModel(dwarf.GetHealth(), dwarf.GetStrength(), dwarf.GetCraft(), dwarf.GetFate(), 0, dwarf.GetType());
        }

        public static CharacterModel createElfCharacter()
        {
            Elf elf = new Elf();
            
            return new CharacterModel(elf.GetHealth(), elf.GetStrength(), elf.GetCraft(), elf.GetFate(), 0, elf.GetType());
        }

        public static CharacterModel createGhoulCharacter()
        {
            Ghoul ghoul = new Ghoul();

            return new CharacterModel(ghoul.GetHealth(), ghoul.GetStrength(), ghoul.GetCraft(), ghoul.GetFate(), 0, ghoul.GetType());
        }
    }
}