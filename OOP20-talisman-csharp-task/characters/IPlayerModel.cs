namespace TalismanCSHARP
{
    public interface IPlayerModel
    {
        ref int GetIndex();
        
        void SetIndex(in int id);

        ref CharacterModel GetCurrentCharacter();

        void SetCurrentCharacter(in CharacterModel character);

        void SetCrownPlayer();

        void GiveTalismanQuest(); //TODO Add Quest

        void ResolveActiveQuest();
        
        //TODO get current quest

        bool HasQuest();

        bool HasCrown();

        bool HasTalisman();
    }
}