using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Model.Board;
using Talisman.View.Board;

namespace Talisman.Controller.Board
{
    public interface IPopulatedBoardController<B, S, C, P> : IBoardController<B, S, C> 
        where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P : IBoardPawn
    {
        void MoveCharacterCell(int player, int cell);
        void MoveCharacterSection(int player, int section);
        void MoveCharacterSection(int player, int section, int cell);
        S GetCharacterSection(int player);
        C GetCharacterCell(int player);
        P GetCharacterPawn(int player);
    }

    /// <summary>
    /// Used to provide the default implementation of the interface methods from the original code
    /// </summary>
    public static class PopulatedBoardControllerExtensions
    {
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

    /// <summary>
    /// Used to replace the static factory methods from the original code interface
    /// </summary>
    public static class PopulatedBoardControllerFactory
    {
        public static IPopulatedBoardController<B, S, C, P> Create<B, S, C, P>(B model, IBoardView view)
            where B : IPopulatedBoard<S, C, P> where S : IBoardSection<C> where C : IBoardCell where P: IBoardPawn
        {
            return new PopulatedBoardController<B, S, C, P>(model, view);
        }
    }
}