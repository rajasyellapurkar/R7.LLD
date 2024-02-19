using R7.TicTacToe.Strategy.Model;

namespace R7.TicTacToe.Strategy.AutoMoveStrategy
{
    public interface IAutoMoveStrategy
    {
        MoveDetails MakeMove();
    }
}
