using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Talisman.Model.Board;
using Talisman.View.Board;

namespace Talisman.Controller.Board
{
    public interface IBoardController<B, S, C>
        where B : IBoard<S, C> where S : IBoardSection<C> where C : IBoardCell
    {
        B Board { get; }
        IBoardView View { get; }
    }

    /// <summary>
    /// Since tdefault methods are available
    /// only from newer C# versions, this is needed
    /// to replace the factory method in the interface
    /// </summary>
    public static class BoardControllerFactory
    {
        public static IBoardController<B, S, C> Create<B, S, C>(B model, IBoardView view) 
            where B : IBoard<S, C> where S : IBoardSection<C> where C : IBoardCell
        {
            return new BoardController<B, S, C>(model, view);
        }
    }
}