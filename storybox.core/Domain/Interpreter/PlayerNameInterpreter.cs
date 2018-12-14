using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;

namespace StoryBox.Core.Domain.Interpreter
{
    public class PlayerNameInterpreter : Expression
    {
        public override void Interpret(IGameContext context)
        {
            context.Player = context.UserInput;
        }
    }
}
