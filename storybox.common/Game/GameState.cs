using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;

namespace StoryBox.Common.Game
{
    public abstract class GameState
    {
        protected Expression Interpreter { get; }
        protected GameState(Expression Interpreter)
        {
            this.Interpreter = Interpreter;
        }

        public abstract void Interpret(IGameContext context);
    }
}
