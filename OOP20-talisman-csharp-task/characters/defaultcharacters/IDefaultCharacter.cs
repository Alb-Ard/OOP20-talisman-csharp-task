namespace TalismanCSHARP.characters.defaultcharacters
{
    public interface IDefaultCharacter
    {
       CharacterType GetType();

       string[] GetLore();

       int GetHealth();

       int GetStrength();

       int GetCraft();

       int GetFate();
    }
}