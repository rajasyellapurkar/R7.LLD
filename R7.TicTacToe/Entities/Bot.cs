using R7.TicTacToe.Strategy.AutoMoveStrategy;
using R7.TicTacToe.Strategy.Model;

namespace R7.TicTacToe.Entities
{
    public class Bot: Player
    {
        IAutoMoveStrategy _autoMoveStrategy = null!;

        public override Cell MakeMove()
        {
           MoveDetails moveDetails = _autoMoveStrategy.MakeMove();
            return new Cell
            {
                Symbol = Symbol,
                X = moveDetails.X,
                Y = moveDetails.Y
            };
        }

        private Bot()
        {
            
        }

        public static BotBuilder GetBuilder()
        {
            return new BotBuilder();
        }

        public class BotBuilder
        {
            private Bot _bot;
            public BotBuilder()
            {
                _bot = new Bot();
            }

            public BotBuilder WithAutoMoveStrategy(IAutoMoveStrategy autoMoveStrategy)
            {
                _bot._autoMoveStrategy = autoMoveStrategy;
                return this;
            }

            public BotBuilder WithSymbol(char symbol)
            {
                _bot.Symbol = symbol;
                return this;
            }

            public Bot Build()
            {
                return _bot;
            }
        }
    }
}
