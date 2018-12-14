using StoryBox.Common.Domain.Interpreter;
using StoryBox.Common.Domain.Loader;
using StoryBox.Common.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryBox.Core.Domain
{
    public class GameContext : IGameContext
    {
        public Expression Interpreter { get; set; }
        public GameLibrary GameLibraryItem { get; set; }
        public IGame Game { get; set; }
        public string Player { get; set; }
        public string UserInput { get; set; }
        public CommandType CurrentCommand { get; set; }

    }
}
