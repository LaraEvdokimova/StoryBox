using StoryBox.Common.Domain.Loader;

namespace StoryBox.Common.Domain.Interpreter
{
    public abstract class Expression
    {
        public abstract void Interpret(IGameContext context);
    }
}
