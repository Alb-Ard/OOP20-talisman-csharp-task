using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Controller.Board;
using Talisman.Controller.Character;
using Talisman.Model.Board;

namespace Talisman.Test
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void TestMovement()
        {
            SetupControllers();
            ITalismanBoardController controller = Controllers.BoardController;
            // Starts from 0, 0
            AssertPosition(controller, 0, 0, 0);
            // Moves to 0, 1
            controller.MoveCharacterCell(0, 1);
            AssertPosition(controller, 0, 0, 1);
            // Moves to 1, 0
            controller.MoveCharacterSection(0, 1);
            AssertPosition(controller, 0, 1, 0);
            // Moves to 2, 1
            controller.MoveCharacterSection(0, 2, 1);
            AssertPosition(controller, 0, 2, 1);
            Controllers.Reset();
        }

        [TestMethod]
        public void TestMoveAction()
        {
            SetupControllers();
            ITalismanBoardController controller = Controllers.BoardController;
            // Starts from 0, 0
            AssertPosition(controller, Controllers.CharacterController.CurrentPlayer, 0, 0);
            // Applies the test movement action
            controller.ApplyCurrentCellAction();
            // Now the player should be in 1, 1
            AssertPosition(controller, Controllers.CharacterController.CurrentPlayer, 1, 1);
            Controllers.Reset();
        }

        private void AssertPosition(ITalismanBoardController controller, int player, int expectedSection, int expectedCell)
        {
            Assert.AreEqual(expectedSection, controller.GetCharacterPawn(player).PositionSection);
            Assert.AreEqual(expectedCell, controller.GetCharacterPawn(player).PositionCell);
        }

        private void SetupControllers()
        {
            Controllers.BoardController = TalismanBoardControllerFactory.Create(TalismanBoardFactory.CreateDefaultBoard(), null);
            Controllers.CharacterController = new CharacterController();
        }
    }
}
