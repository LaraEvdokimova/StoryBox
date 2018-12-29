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

        public override void DisplayPrompt(IGameContext context)
        {
            Console.WriteLine("Please input the player name:");
            Console.Write(">");
        }

        public override void DisplayResponse(IGameContext context)
        {
             Console.WriteLine($"Welcome {context.Player}");
        }

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.LoadPlayer;
            Interpreter.Interpret(context);
        }

        public override void LoadState(IGameContext context)
        {
            //empty on purpose
        }

        public override void UnLoadState(IGameContext context)
        {
            //empty on purpose
        }
    }
}
