using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Game;
using StoryBox.Core.Handler;

namespace StoryBox.Core.Domain
{
    public class GameContext : IGameContext
    {
        public GameContext()
        {
            this.GameState = new LoadPlayerState();

            GameHandler = new LoadHandler();

            var gameSelectionHandler = new GameSelectionHandler();
            var gameCommandHandler = new GameCommandHandler();

            GameHandler.SetSuccessor(gameSelectionHandler);
            gameSelectionHandler.SetSuccessor(gameCommandHandler);
        }

        public GameHandler GameHandler { get; set; }
        public GameStateType GameStateType { get; set; }
        public GameState GameState { get; set; }
        public GameLibrary GameLibraryItem { get; set; }
        public IGame Game { get; set; }
        public string Player { get; set; }
        public string UserInput { get; set; }
        public CommandType CurrentCommand { get; set; }
     
        public void Process()
        {
            GameHandler.Process(this);
        }
    }
}
