using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryBox.Core.Handler
{
    public class LoadHandler : GameHandler
    {
        public override void HandleRequest(IGameContext gameContext)
        {
            if (!string.IsNullOrWhiteSpace(gameContext.Player))
            {
                gameContext.GameStateType = GameStateType.GameSelection;
            }
        }
    }
}
