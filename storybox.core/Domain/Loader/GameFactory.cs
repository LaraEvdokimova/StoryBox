using StoryBox.Common.Domain.Loader;
using StoryBox.Data.Domain.Loader;
using System;

namespace StoryBox.Core.Domain.Loader
{
    public class GameFactory
    {
        public static IGame Create(GameLibrary gameName)
        {
            switch (gameName)
            {
                case GameLibrary.Syn:
                    return new Syn { Name ="Syn:  The Sci-Fi Adventure"};
                case GameLibrary.BubbleCommander:
                    return new BubbleCommander { Name = "Bubble Commander:  The Last Bubble" };
                default:
                    throw new ArgumentException("Game not in the library"); 
            }
        }
    }
}
