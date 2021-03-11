using TalismanCSHARP.characters;
using TalismanCSHARP.quests;
using TalismanCSHARP.quests.exceptions;

namespace TalismanCSHARP
{
    public class PlayerModel : IPlayerModel
    {
        private int _id;
        private CharacterModel _currentCharacter;
        private TalismanQuest _currentQuest;
        private bool _crown;
        private bool _talisman;

        public PlayerModel(in int id, in CharacterModel character)
        {
            _id = id;
            _currentCharacter = character;
            _crown = false;
            _talisman = false;
            _currentQuest = null;
        }
        
        public ref int GetIndex()
        {
            return ref _id;
        }

        public void SetIndex(in int id)
        {
            _id = id;
        }

        public ref CharacterModel GetCurrentCharacter()
        {
            return ref _currentCharacter;
        }

        public void SetCurrentCharacter(in CharacterModel character)
        {
            _currentCharacter = character;
        }

        public void SetCrownPlayer()
        {
            _crown = true;
        }

        public void GiveTalismanQuest(TalismanQuest quest)
        {
            _currentQuest = quest;
        }

        public void ResolveActiveQuest()
        {
            if (HasQuest()){

                _currentCharacter = null;
                _talisman = true;

                //Resolving quest with external code
                //
                //int index = Controllers.getCharactersController().getCurrentPlayer().getIndex();
                //Controllers.getBoardController().moveCharacterSection(index, 1, 8);

            } else {

                throw new NoActiveQuestException("player n. " + _id + " doesn't have an active quest");
            }
        }

        public bool HasQuest()
        {
            return _currentQuest != null;
        }

        public bool HasCrown()
        {
            return _crown;
        }

        public bool HasTalisman()
        {
            return _talisman;
        }
    }
}