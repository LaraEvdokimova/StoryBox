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
        public abstract void DisplayPrompt(IGameContext context);
        public abstract void DisplayResponse(IGameContext context);

        public virtual void LoadState(IGameContext context)
        {
            //empty on purpose
        }
        public virtual void UnLoadState(IGameContext context)
        {
            //empty on purpose
        }
      
       
    }
}
