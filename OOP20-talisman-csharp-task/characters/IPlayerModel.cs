using TalismanCSHARP.quests;

namespace TalismanCSHARP.characters
{
    public interface IPlayerModel
    {
        ref int GetIndex();
        
        void SetIndex(in int id);

        ref CharacterModel GetCurrentCharacter();

        void SetCurrentCharacter(in CharacterModel character);

        void SetCrownPlayer();

        void GiveTalismanQuest(TalismanQuest quest);

        void ResolveActiveQuest();

        bool HasQuest();

        bool HasCrown();

        bool HasTalisman();
    }
}