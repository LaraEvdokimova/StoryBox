using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Interpreter;

namespace StoryBox.Core.Domain.Game
{
    public class GameSelectionState : GameState
    {
        public GameSelectionState() : base(new GameSelectionInterpreter())
        {
        }

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.GameSelection;
            Interpreter.Interpret(context);
        }
    }
}
