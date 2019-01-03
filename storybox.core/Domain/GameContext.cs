using System;
using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Game;
using StoryBox.Core.Handler;

namespace StoryBox.Core.Domain
{
    public class GameContext : IGameContext
    {

        public GameHandler GameHandler { get; set; }
        public GameStateType GameStateType { get; set; }
        public GameState GameState { get; set; }
        public GameLibrary GameLibraryItem { get; set; }
        public IGame Game { get; set; }
        public string Player { get; set; }
        public string UserInput { get; set; }
        public CommandType CurrentCommand { get; set; }

        private GameHandler playerLoadHandler = new LoadHandler();
        private GameHandler gameSelectionHandler = new GameSelectionHandler();
        private GameHandler gameCommandHandler = new GameCommandHandler();

        public GameContext()
        {
            this.GameState = new LoadPlayerState();

            GameHandler = playerLoadHandler;
            GameHandler.SetSuccessor(gameSelectionHandler);
            gameSelectionHandler.SetSuccessor(gameCommandHandler);
        }

        public void SetGameSelectionHandler(GameHandler handler)
        {
            gameSelectionHandler = handler;
            gameSelectionHandler.SetSuccessor(gameCommandHandler);
        }

        public void GameStart()
        {
            GameHandler.Process(this);
        }
    }
}
