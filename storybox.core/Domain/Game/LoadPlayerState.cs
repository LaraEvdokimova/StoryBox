using System;
using System.Collections.Generic;
using System.Text;
using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Interpreter;

namespace StoryBox.Core.Domain.Game
{
    public class LoadPlayerState : GameState
    {
        public LoadPlayerState() : base(new PlayerNameInterpreter())
        {
        }
        
        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.LoadPlayer;
            Interpreter.Interpret(context);
        }
    }
}
