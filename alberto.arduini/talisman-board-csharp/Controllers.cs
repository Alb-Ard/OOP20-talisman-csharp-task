using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talisman.Controller.Board;
using Talisman.Controller.Character;
using Talisman.Model.Card;

namespace Talisman
{
    public static class Controllers
    {
        private static ITalismanBoardController boardController;
        private static Dictionary<DeckType, IDeckController> deckControllers = new Dictionary<DeckType, IDeckController>();
        private static ICharactersController characterController;

        public static ITalismanBoardController BoardController 
        {
            get => boardController; 
            set => boardController = boardController == null ? value : throw new ArgumentException("Controller already set");
        }
        public static Dictionary<DeckType, IDeckController> DeckControllers { get => deckControllers; }
        public static ICharactersController CharacterController 
        {
            get => characterController; 
            set => characterController = characterController == null ? value : throw new ArgumentException("Controller already set");
        }

        public static void SetDeckController(DeckType type, IDeckController controller)
        {
            if (deckControllers.ContainsKey(type))
                throw new ArgumentException("Controller already set");
            deckControllers.Add(type, controller);
        }

        public static void Reset()
        {
            boardController = null;
            characterController = null;
            deckControllers.Clear();
        }
    }
}
