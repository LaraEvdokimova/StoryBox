using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using StoryBox.Core.Domain.Interpreter;
using StoryBox.Core.Domain.Loader;
using System;

namespace StoryBox.Core.Domain.Game
{
    public class GameSelectionState : GameState
    {
        public GameSelectionState() : base(new GameSelectionInterpreter())
        {
        }

        public override void DisplayPrompt(IGameContext context)
        {
            Console.WriteLine("Please type the game you want to play");
            Console.WriteLine("1. Bubble Commander");
            Console.WriteLine("2. Syn");
            Console.Write(">");
        }

        public override void DisplayResponse(IGameContext context)
        {
            Console.WriteLine($"You chose:{context.Game.Name}");
        }

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.GameSelection;
            Interpreter.Interpret(context);
            context.Game = GameFactory.Create(context.GameLibraryItem);
        }
    }
}
