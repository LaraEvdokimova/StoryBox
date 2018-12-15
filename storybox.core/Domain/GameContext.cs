using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Game;

namespace StoryBox.Core.Domain
{
    public class GameContext : IGameContext
    {
        public GameContext()
        {
            this.GameState = new LoadPlayerState();
        }

        public GameStateType GameStateType { get; set; }
        public GameState GameState { get; set; }
        public GameLibrary GameLibraryItem { get; set; }
        public IGame Game { get; set; }
        public string Player { get; set; }
        public string UserInput { get; set; }
        public CommandType CurrentCommand { get; set; }
     
        public void Interpret()
        {
            GameState.Interpret(this);
        }
    }
}
