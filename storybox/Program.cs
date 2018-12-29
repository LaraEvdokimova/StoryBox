using StoryBox.Core.Domain;
using StoryBox.Core.Domain.Loader;
using System;

namespace StoryBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new GameContext();

            context.Process();
            Console.ReadKey();
        }
    }
}
