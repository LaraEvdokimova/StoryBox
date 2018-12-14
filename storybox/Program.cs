using StoryBox.Core.Domain;
using StoryBox.Core.Domain.Interpreter;
using StoryBox.Core.Domain.Loader;
using System;

namespace StoryBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new GameContext();

            Console.WriteLine("Please input the player name:");
            Console.Write(">");
            context.UserInput = Console.ReadLine();
            context.Interpreter = new PlayerNameInterpreter();
            context.Interpreter.Interpret(context);

            Console.WriteLine($"Welcome {context.Player}");

            Console.WriteLine("Please type the game you want to play");
            Console.WriteLine("1. Bubble Commander");
            Console.WriteLine("2. Syn");
            Console.Write(">");
            context.UserInput = Console.ReadLine();
            context.Interpreter = new GameSelectionInterpreter();
            context.Interpreter.Interpret(context);

            context.Game = GameFactory.Create(context.GameLibraryItem);
            Console.WriteLine($"You chose:{context.Game.Name}");

            Console.WriteLine("Please input a command");
            Console.Write(">");
            context.UserInput = Console.ReadLine();
            context.Interpreter = new CommandInterpreter();
            context.Interpreter.Interpret(context);

            Console.ReadKey();
        }
    }
}
