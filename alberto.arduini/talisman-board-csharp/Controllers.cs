using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Controller.Board;
using Talisman.Controller.Character;
using Talisman.Controller.Card;
using Talisman.Model.Card;

namespace Talisman
{
    public static class Controllers
    {
        private static ITalismanBoardController boardController;
        private static ICharactersController characterController;

        public static ITalismanBoardController BoardController 
        {
            get => boardController; 
            set => boardController = boardController == null ? value : throw new ArgumentException("Controller already set");
        }
        public static Dictionary<DeckType, IDeckController> DeckControllers { get; } = new Dictionary<DeckType, IDeckController>();
        public static ICharactersController CharacterController 
        {
            get => characterController; 
            set => characterController = characterController == null ? value : throw new ArgumentException("Controller already set");
        }

        public static void SetDeckController(DeckType type, IDeckController controller)
        {
            if (DeckControllers.ContainsKey(type))
                throw new ArgumentException("Controller already set");
            DeckControllers.Add(type, controller);
        }

        public static void Reset()
        {
            boardController = null;
            characterController = null;
            DeckControllers.Clear();
        }
    }
}
