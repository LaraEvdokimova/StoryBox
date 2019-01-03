using StoryBox.Core.Domain;
using StoryBox.Core.Handler;
using System;

namespace StoryBox.Cli
{
    public  class AppContext
    {
        private GameContext gameContext = new GameContext();
        private AppState AppState { get; set; }

        public AppContext()
        {
            gameContext.SetGameSelectionHandler(new GameSelectionHandler());
            AppState = AppState.Stopped;
        }

        private void GameStart()
        {
            AppState = AppState.Running;
            gameContext.GameStart();
        }

        public void Start()
        {
            GameStart();
        }

        public void Stop()
        {
            if(AppState != AppState.Running)
            {
                Console.WriteLine("Applicationus not in a running state.");
            }
        }
    }
}
