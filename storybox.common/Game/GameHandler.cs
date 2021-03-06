﻿using StoryBox.Common.Domain.Loader;
using System;

namespace StoryBox.Common.Game
{
    public abstract class GameHandler
    {
        protected GameHandler successor;
        public void SetSuccessor(GameHandler handler)
        {
            successor = handler;
        }
        public void Process(IGameContext gameContext)
        {
            HandleRequest(gameContext);

            gameContext.GameState.LoadState(gameContext);
            gameContext.GameState.DisplayPrompt(gameContext);
            gameContext.UserInput = Console.ReadLine();
            gameContext.GameState.Interpret(gameContext);
            gameContext.GameState.DisplayResponse(gameContext);
            gameContext.GameState.UnLoadState(gameContext);

            successor.Process(gameContext);

        }
        public abstract void HandleRequest(IGameContext request);
    }
}
