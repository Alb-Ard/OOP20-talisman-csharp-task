using TalismanCSHARP.characters;

namespace TalismanCSHARP
{
    public class PlayerModel : IPlayerModel
    {
        private int _id;
        private CharacterModel _currentCharacter;
        //private TalismanQuest _currentQuest;
        private bool _crown;
        private bool _talisman;

        public PlayerModel(in int id, in CharacterModel character)
        {
            _id = id;
            _currentCharacter = character;
            _crown = false;
            _talisman = false;
            //_currentQuest = null;
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

        public void GiveTalismanQuest()
        {
            throw new System.NotImplementedException();
        }

        public void ResolveActiveQuest()
        {
            throw new System.NotImplementedException();
        }

        public bool HasQuest()
        {
            throw new System.NotImplementedException();
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