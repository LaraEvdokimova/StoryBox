using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Interpreter;
using System;

namespace StoryBox.Core.Domain.Game
{
    public class GameCommandState : GameState
    {
        public GameCommandState() : base(new CommandInterpreter())
        {
        }

        public override void DisplayPrompt(IGameContext context)
        {
            Console.WriteLine("Please input a command");
            Console.Write(">");
        }

        public override void DisplayResponse(IGameContext context)
        {
           
        }

        public override void Interpret(IGameContext context)
        {
          
        }

       }
}
