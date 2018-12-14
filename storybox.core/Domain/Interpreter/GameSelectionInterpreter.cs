using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;


namespace StoryBox.Core.Domain.Interpreter
{
    public class GameSelectionInterpreter : Expression
    {
        public override void Interpret(IGameContext context)
        {
            context.GameLibraryItem = (GameLibrary)int.Parse(context.UserInput);
        }
    }
}
