using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Model.Board;

namespace Talisman.Controller.Board
{
    public interface IPopulatedBoardController<B, S, C, P> : IBoardController<B, S, C> 
        where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P : IBoardPawn
    {
        void MoveCharacterSection(int player, int section, int cell);
        S GetCharacterSection(int player);
        C GetCharacterCell(int player);
        P GetCharacterPawn(int player);
    }

    /// <summary>
    /// Used to provide the implementation of the default methods from the original code
    /// </summary>
    public static class PopulatedBoardControllerExtensions
    {
        public static void MoveCharacterCell<B, S, C, P>(this IPopulatedBoardController<B, S, C, P> controller, int player, int cell)
            where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P : IBoardPawn
        {
            int currentSection = controller.GetCharacterPawn(player).PositionSection;
            controller.MoveCharacterSection(player, currentSection, cell);
        }

        public static void MoveCharacterSection<B, S, C, P>(this IPopulatedBoardController<B, S, C, P> controller, int player, int section)
            where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P : IBoardPawn
        {
            int currentCell = controller.GetCharacterPawn(player).PositionCell;
            controller.MoveCharacterSection(player, section, currentCell);
        }

        public static ISet<int> GetCharactersInCell<B, S, C, P>(this IPopulatedBoardController<B, S, C, P> controller, int section, int cell) 
            where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P : IBoardPawn
        {
            ISet<int> result = new HashSet<int>();
            for (int i = 0; i < controller.Board.PawnsCount; i++)
                if (controller.GetCharacterPawn(i).PositionCell == cell && controller.GetCharacterPawn(i).PositionSection == section)
                    result.Add(controller.GetCharacterPawn(i).Index);
            return result;
        }
    }
}