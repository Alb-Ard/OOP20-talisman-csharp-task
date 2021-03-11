using System.Collections.Generic;

namespace TalismanCSHARP.characters.controllers
{
    public class CharacterController : ICharacterController
    {
        
        private int _currentPlayer;
        private int _activePlayers;

        public CharacterController()
        {
            _currentPlayer = 0;
            _activePlayers = 0;
        }
        
        public PlayerModel GetCurrentPlayer()
        {
            return Players.GetPlayer(_currentPlayer);
        }

        public int GetActivePlayers()
        {
            return _activePlayers;
        }

        public void SetCurrentPlayer(int index)
        {
            _currentPlayer = index >= _activePlayers ? 0 : index;
        }

        public void AddPlayer(CharacterModel character)
        {
            Players.AddPlayer(character, ++_activePlayers);
        }

        public void RemovePlayer(int index)
        {
            Players.RemovePlayer(index);
            _activePlayers--;
        }

        public List<PlayerModel> GetPlayers()
        {
            return Players.GetPlayers();
        }

        public PlayerModel GetCrownPlayer()
        {
            foreach (PlayerModel player in GetPlayers())
            {
                if (player.HasCrown()) return player;
            }

            return null;
        }
    }
    
    class Players {

        private static readonly List<PlayerModel> players = new List<PlayerModel>();
        private static int _lastId = 0;

        public static void AddPlayer(CharacterModel character, int activePlayers)
        {
            players.Add(new PlayerModel(_lastId++, character));
        }

        public static PlayerModel GetPlayer(int index)
        {
            return players[index];
        }

        public static void RemovePlayer(int index)
        {
            players.RemoveAt(index);
        }

        public static List<PlayerModel> GetPlayers()
        {
            return new List<PlayerModel>(players);
        }
    }
}