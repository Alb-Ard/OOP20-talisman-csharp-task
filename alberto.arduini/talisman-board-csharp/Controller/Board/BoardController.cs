using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talisman.Model.Board;
using Talisman.View.Board;

namespace Talisman.Controller.Board
{
    public class BoardController<B, S, C> : IBoardController<B, S, C> where B : IBoard<S, C> where S : IBoardSection<C> where C : IBoardCell
    {
        private readonly B board;
        private readonly IBoardView view;

        public B Board => board;
        public IBoardView View => view;

        public BoardController(B board, IBoardView view)
        {
            this.board = board;
            this.view = view;
        }
    }
}
