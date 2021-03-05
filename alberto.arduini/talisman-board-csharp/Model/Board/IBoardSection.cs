namespace Talisman.Model.Board
{
    public interface IBoardSection<C> where C: IBoardCell
    {
        C this[int index] { get; }

        int CellsCount { get; }
    }
}