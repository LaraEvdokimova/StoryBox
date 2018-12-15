
using StoryBox.Common.Game;

namespace StoryBox.Common.Domain.Loader
{
    public interface IGameContext
    {
        GameLibrary GameLibraryItem { get; set; }
        GameState GameState {  get;  set; }
        GameStateType GameStateType { get; set; }
        IGame Game { get; set; }
        string Player { get; set; }
        string UserInput { get; set; }
    }
}
