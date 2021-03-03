namespace TalismanCSHARP.characters.defaultcharacters
{
    public interface IDefaultCharacter
    {
       string GetType();

       string[] GetLore();

       int GetHealth();

       int GetStrength();

       int GetCraft();

       int GetFate();
    }
}